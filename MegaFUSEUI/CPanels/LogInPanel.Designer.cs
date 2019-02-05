namespace MegaFUSEUI.CPanels
{
    partial class LogInPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logInLbl = new System.Windows.Forms.Label();
            this.uiDescriptionLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.unameUilabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.quitbtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logInLbl
            // 
            this.logInLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.logInLbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.logInLbl.Location = new System.Drawing.Point(25, 25);
            this.logInLbl.Name = "logInLbl";
            this.logInLbl.Size = new System.Drawing.Size(350, 41);
            this.logInLbl.TabIndex = 0;
            this.logInLbl.Text = "Log In to Mega";
            // 
            // uiDescriptionLabel
            // 
            this.uiDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiDescriptionLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uiDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.uiDescriptionLabel.Location = new System.Drawing.Point(25, 66);
            this.uiDescriptionLabel.Name = "uiDescriptionLabel";
            this.uiDescriptionLabel.Size = new System.Drawing.Size(350, 23);
            this.uiDescriptionLabel.TabIndex = 1;
            this.uiDescriptionLabel.Text = "Enter your username and password.";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(27, 193);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(344, 20);
            this.usernameInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(27, 250);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(344, 20);
            this.passwordInput.TabIndex = 3;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // unameUilabel
            // 
            this.unameUilabel.AutoSize = true;
            this.unameUilabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.unameUilabel.Location = new System.Drawing.Point(23, 171);
            this.unameUilabel.Name = "unameUilabel";
            this.unameUilabel.Size = new System.Drawing.Size(80, 19);
            this.unameUilabel.TabIndex = 4;
            this.unameUilabel.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(23, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.Location = new System.Drawing.Point(305, 449);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(66, 23);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // quitbtn
            // 
            this.quitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitbtn.Location = new System.Drawing.Point(233, 449);
            this.quitbtn.Name = "quitbtn";
            this.quitbtn.Size = new System.Drawing.Size(66, 23);
            this.quitbtn.TabIndex = 7;
            this.quitbtn.Text = "Quit";
            this.quitbtn.UseVisualStyleBackColor = true;
            this.quitbtn.Click += new System.EventHandler(this.quitbtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.statusLabel.Location = new System.Drawing.Point(21, 423);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(350, 23);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.quitbtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unameUilabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.uiDescriptionLabel);
            this.Controls.Add(this.logInLbl);
            this.Name = "LogInPanel";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Size = new System.Drawing.Size(400, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logInLbl;
        private System.Windows.Forms.Label uiDescriptionLabel;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label unameUilabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button quitbtn;
        private System.Windows.Forms.Label statusLabel;
    }
}
