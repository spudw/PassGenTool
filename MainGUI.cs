using Microsoft.Win32;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PassGenTool
{
    public partial class MainGUI : Form
    {
        //Declare GUI Message Constants
        const string MSG_PASSPHRASE_SHORT = "Passphrase is too short\r\n8 characters minimum";
        const string MSG_PASSWORD_GENERATING = "Generating Password";
        const string MSG_PASSWORD_MISSING_KEY = "Missing Key";
        const string MSG_PASSWORD_COPIED = "Copied to Clipboard";

        //Declare GUI Control Text Constants
        const string TEXT_KEY_CHANGE = "&Change";
        const string TEXT_KEY_SAVE = "&Save";
        const string TEXT_REVEAL_ACCEL_S = "&Show";
        const string TEXT_REVEAL_ACCEL_W = "Sho&w";

        //Additional Constants
        const string REGSUBKEY = "SOFTWARE\\PassGenTool";
        static byte[] PROTECTEntropy = { 211, 103, 137, 67, 29, 59, 47, 181 };
        static char[] PASSWORDCHARACTERS = "ABCEFGHKLMNPQRSTUVWXYZ0987654321abdefghjmnqrtuwy".ToCharArray();

        public MainGUI()
        {
            InitializeComponent();
            FetchKey();
        }

        #region GUI Event Handlers
        private void btnKey_Click(object sender, EventArgs e)
        {
            string btnText = btnKey.Text;
            switch (btnText)
            {
                case TEXT_KEY_CHANGE:
                    ChangeKey();
                    break;
                case TEXT_KEY_SAVE:
                    SaveKey();
                    break;
            }
        }

        private void btnKeyReveal_Click(object sender, EventArgs e)
        {
            bool bState = btnKeyReveal.Checked;
            switch (bState)
            {
                case true:
                    txtKey.UseSystemPasswordChar = false;
                    break;
                case false:
                    txtKey.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void btnPassphrase_Click(object sender, EventArgs e)
        {
            CopyPassphrase();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            CopyPassword();
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            if (KeyIsEmpty())
            {
                SetPasswordMsg(MSG_PASSWORD_MISSING_KEY);
            }
            else
            {
                SetPasswordMsg("");
            }
        }

        private void txtPassphrase_TextChanged(object sender, EventArgs e)
        {
            string sPassphrase = GetPassphrase();
            int iLen = sPassphrase.Length;
            switch (iLen)
            {
                case 0:
                    SetPassphraseMsg("");
                    SetPasswordMsg("");
                    ClearPassword();
                    break;
                case int iSize when (iSize <= 7):
                    SetPassphraseMsg(MSG_PASSPHRASE_SHORT);
                    SetPasswordMsg("");
                    ClearPassword();
                    break;
                default:
                    SetPassphraseMsg("");
                    GeneratePassword();
                    break;
            }
        }
        #endregion

        #region Additional GUI Functions
        private void ClearPassword()
        {
            txtPassword.Text = "";
            Clipboard.Clear();
            btnPassphrase.Enabled = false;
            btnPassword.Enabled = false;
        }

        private void CopyPassphrase()
        {
            Clipboard.Clear();
            Clipboard.SetText(GetPassphrase());
            SetPassphraseMsg(MSG_PASSWORD_COPIED);
            SetPasswordMsg("");
        }

        private void CopyPassword()
        {
            Clipboard.Clear();
            Clipboard.SetText(GetPassword());
            SetPasswordMsg(MSG_PASSWORD_COPIED);
            SetPassphraseMsg("");
        }

        private string GetPassphrase()
        {
            return txtPassphrase.Text.Trim();
        }

        private string GetPassword()
        {
            return txtPassword.Text;
        }

        private bool PassphraseIsEmpty()
        {
            if (GetPassphrase().Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SetPassphraseMsg(string sMsg)
        {
            lblPassphraseMsg.Text = sMsg;
        }

        private void SetPasswordMsg(string sMsg)
        {
            lblPasswordMsg.Text = sMsg;
        }
        #endregion

        #region Key Functions
        private void ChangeKey()
        {
            ClearPassword();
            btnKey.Text = TEXT_KEY_SAVE;
            btnKeyReveal.Checked = true;
            btnKeyReveal.Text = TEXT_REVEAL_ACCEL_W;
            txtPassphrase.Enabled = false;
            txtPassword.Enabled = false;
            txtPassword.BackColor = System.Drawing.SystemColors.Window;
            txtKey.Enabled = true;
            txtKey.Focus();
        }

        private void CheckKey()
        {
            if (KeyIsEmpty() == true)
            {
                SetPasswordMsg(MSG_PASSWORD_MISSING_KEY);
                ChangeKey();
            }
            else
            {
                SetPasswordMsg("");
            }
        }

        private void FetchKey()
        {
            string sKey = GetKeyFromReg();
            if (sKey != "")
            {
                SetKey(sKey);
                txtPassphrase.Focus();
            }
            else
            {
                CheckKey();
            }
        }

        private string GetKey()
        {
            return txtKey.Text.Trim();
        }

        private bool KeyIsEmpty()
        {
            if (GetKey().Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SaveKey()
        {
            if (KeyIsEmpty() == false)
            {
                SaveKeyToReg(GetKey());
                txtKey.Enabled = false;
                btnKey.Text = TEXT_KEY_CHANGE;
                btnKeyReveal.Checked = false;
                btnKeyReveal.Text = TEXT_REVEAL_ACCEL_S;
                txtPassword.Enabled = true;
                txtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
                txtPassphrase.Enabled = true;
                txtPassphrase.Focus();
                GeneratePassword();
            }
            else
            {
                SaveKeyToReg("");
            }
        }

        private void SetKey(string sKey)
        {
            txtKey.Text = sKey;
        }
        #endregion

        #region Registry Functions
        private string GetKeyFromReg()
        {
            string sKey = "";
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey(REGSUBKEY);
            if (regKey is Object)
            {
                object ProtectedKey = regKey.GetValue("Key");
                if (ProtectedKey is Object)
                {
                    byte[] key = (byte[])ProtectedKey;
                    sKey = UnprotectKey(key);
                }
                regKey.Close();
            }
            return sKey;
        }

        private void SaveKeyToReg(string sValue)
        {
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey(REGSUBKEY);
            byte[] ProtectedKey = ProtectKey(sValue);
            regKey.SetValue("Key", ProtectedKey, RegistryValueKind.Binary);
            regKey.Close();
        }

        private byte[] ProtectKey(string sValue)
        {
            return ProtectedData.Protect(Encoding.UTF8.GetBytes(sValue), PROTECTEntropy, DataProtectionScope.CurrentUser);
        }

        private string UnprotectKey(byte[] ProtectedKey)
        {
            byte[] Key = ProtectedData.Unprotect(ProtectedKey, PROTECTEntropy, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(Key);
        }
        #endregion

        #region Password Functions
        private void GeneratePassword()
        {
            if (KeyIsEmpty() || PassphraseIsEmpty()) { return; }
            SetPasswordMsg(MSG_PASSWORD_GENERATING);
            byte[] dHash = Hash(GetKey() + "-" + GetPassphrase());
            int iCharListLen = PASSWORDCHARACTERS.Length;
            string sPassword = "";
            for (int iX = 0; iX <= 19; iX++)
            {
                int iChar = dHash[iX] % iCharListLen;
                sPassword += PASSWORDCHARACTERS[iChar];
                if ((iX + 1) % 4 == 0 && iX < 19) { sPassword += "-"; }
            }
            txtPassword.Text = sPassword;
            btnPassphrase.Enabled = true;
            btnPassword.Enabled = true;
            CopyPassword();
        }

        private byte[] Hash(string sHashData)
        {
            SHA1Managed sha1 = new SHA1Managed();
            return sha1.ComputeHash(Encoding.UTF8.GetBytes(GetKey() + "-" + GetPassphrase()));
        }

        #endregion
    }
}
