namespace MegaFUSEUI.CPanels
{
    partial class MgmtPanel
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
            this.storageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // storageLabel
            // 
            this.storageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.storageLabel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.storageLabel.Location = new System.Drawing.Point(25, 25);
            this.storageLabel.Name = "storageLabel";
            this.storageLabel.Size = new System.Drawing.Size(350, 86);
            this.storageLabel.TabIndex = 0;
            this.storageLabel.Text = "Loading quota...";
            // 
            // MgmtPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.storageLabel);
            this.Name = "MgmtPanel";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Size = new System.Drawing.Size(400, 500);
            this.Load += new System.EventHandler(this.MgmtPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label storageLabel;
    }
}
