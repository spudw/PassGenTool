namespace PassGenTool
{
    partial class MainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKeyReveal = new System.Windows.Forms.CheckBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnKey = new System.Windows.Forms.Button();
            this.lblPassphrase = new System.Windows.Forms.Label();
            this.txtPassphrase = new System.Windows.Forms.TextBox();
            this.btnPassphrase = new System.Windows.Forms.Button();
            this.lblPassphraseMsg = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.lblPasswordMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKeyReveal
            // 
            this.btnKeyReveal.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnKeyReveal.AutoSize = true;
            this.btnKeyReveal.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKeyReveal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKeyReveal.Location = new System.Drawing.Point(14, 34);
            this.btnKeyReveal.Name = "btnKeyReveal";
            this.btnKeyReveal.Size = new System.Drawing.Size(44, 23);
            this.btnKeyReveal.TabIndex = 0;
            this.btnKeyReveal.Text = "&Show";
            this.btnKeyReveal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKeyReveal.UseVisualStyleBackColor = true;
            this.btnKeyReveal.CheckedChanged += new System.EventHandler(this.btnKeyReveal_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(65, 37);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(38, 16);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Key:";
            this.lblKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKey
            // 
            this.txtKey.Enabled = false;
            this.txtKey.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(109, 30);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(276, 30);
            this.txtKey.TabIndex = 1;
            this.txtKey.UseSystemPasswordChar = true;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // btnKey
            // 
            this.btnKey.Location = new System.Drawing.Point(395, 30);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(54, 30);
            this.btnKey.TabIndex = 2;
            this.btnKey.Text = "&Change";
            this.btnKey.UseVisualStyleBackColor = true;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // lblPassphrase
            // 
            this.lblPassphrase.AutoSize = true;
            this.lblPassphrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassphrase.Location = new System.Drawing.Point(8, 92);
            this.lblPassphrase.Name = "lblPassphrase";
            this.lblPassphrase.Size = new System.Drawing.Size(95, 16);
            this.lblPassphrase.TabIndex = 6;
            this.lblPassphrase.Text = "Passphrase:";
            this.lblPassphrase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassphrase
            // 
            this.txtPassphrase.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassphrase.Location = new System.Drawing.Point(109, 85);
            this.txtPassphrase.Name = "txtPassphrase";
            this.txtPassphrase.Size = new System.Drawing.Size(276, 30);
            this.txtPassphrase.TabIndex = 3;
            this.txtPassphrase.TextChanged += new System.EventHandler(this.txtPassphrase_TextChanged);
            // 
            // btnPassphrase
            // 
            this.btnPassphrase.Location = new System.Drawing.Point(402, 85);
            this.btnPassphrase.Name = "btnPassphrase";
            this.btnPassphrase.Size = new System.Drawing.Size(40, 30);
            this.btnPassphrase.TabIndex = 4;
            this.btnPassphrase.Text = "C&opy";
            this.btnPassphrase.UseVisualStyleBackColor = true;
            this.btnPassphrase.Click += new System.EventHandler(this.btnPassphrase_Click);
            // 
            // lblPassphraseMsg
            // 
            this.lblPassphraseMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassphraseMsg.ForeColor = System.Drawing.Color.Red;
            this.lblPassphraseMsg.Location = new System.Drawing.Point(109, 116);
            this.lblPassphraseMsg.Name = "lblPassphraseMsg";
            this.lblPassphraseMsg.Size = new System.Drawing.Size(276, 35);
            this.lblPassphraseMsg.TabIndex = 8;
            this.lblPassphraseMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(23, 161);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 16);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(109, 154);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(276, 30);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(402, 154);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(40, 30);
            this.btnPassword.TabIndex = 6;
            this.btnPassword.Text = "Co&py";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // lblPasswordMsg
            // 
            this.lblPasswordMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordMsg.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordMsg.Location = new System.Drawing.Point(109, 185);
            this.lblPasswordMsg.Name = "lblPasswordMsg";
            this.lblPasswordMsg.Size = new System.Drawing.Size(276, 34);
            this.lblPasswordMsg.TabIndex = 12;
            this.lblPasswordMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainGUI
            // 
            this.AcceptButton = this.btnKey;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 228);
            this.Controls.Add(this.lblPasswordMsg);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassphraseMsg);
            this.Controls.Add(this.btnPassphrase);
            this.Controls.Add(this.lblPassphrase);
            this.Controls.Add(this.txtPassphrase);
            this.Controls.Add(this.btnKeyReveal);
            this.Controls.Add(this.btnKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtKey);
            this.MaximizeBox = false;
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassGenTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button btnKey;
        private System.Windows.Forms.CheckBox btnKeyReveal;
        private System.Windows.Forms.TextBox txtPassphrase;
        private System.Windows.Forms.Label lblPassphrase;
        private System.Windows.Forms.Button btnPassphrase;
        private System.Windows.Forms.Label lblPassphraseMsg;
        private System.Windows.Forms.Label lblPasswordMsg;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

