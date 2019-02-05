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
            this.components = new System.ComponentModel.Container();
            this.storageLabel = new System.Windows.Forms.Label();
            this.labelFuseStatus = new System.Windows.Forms.Label();
            this.fsUpdateTimer = new System.Windows.Forms.Timer(this.components);
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
            this.storageLabel.Click += new System.EventHandler(this.storageLabel_Click);
            // 
            // labelFuseStatus
            // 
            this.labelFuseStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFuseStatus.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelFuseStatus.ForeColor = System.Drawing.Color.Orange;
            this.labelFuseStatus.Location = new System.Drawing.Point(25, 111);
            this.labelFuseStatus.Name = "labelFuseStatus";
            this.labelFuseStatus.Size = new System.Drawing.Size(350, 23);
            this.labelFuseStatus.TabIndex = 1;
            this.labelFuseStatus.Text = "FUSE Status: Unknown";
            this.labelFuseStatus.Click += new System.EventHandler(this.labelFuseStatus_Click);
            // 
            // fsUpdateTimer
            // 
            this.fsUpdateTimer.Enabled = true;
            this.fsUpdateTimer.Interval = 6000;
            this.fsUpdateTimer.Tick += new System.EventHandler(this.fsUpdateTimer_Tick);
            // 
            // MgmtPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelFuseStatus);
            this.Controls.Add(this.storageLabel);
            this.Name = "MgmtPanel";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Size = new System.Drawing.Size(400, 500);
            this.Load += new System.EventHandler(this.MgmtPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label storageLabel;
        public System.Windows.Forms.Label labelFuseStatus;
        private System.Windows.Forms.Timer fsUpdateTimer;
    }
}
