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
            // LogInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiDescriptionLabel);
            this.Controls.Add(this.logInLbl);
            this.Name = "LogInPanel";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Size = new System.Drawing.Size(400, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label logInLbl;
        private System.Windows.Forms.Label uiDescriptionLabel;
    }
}
