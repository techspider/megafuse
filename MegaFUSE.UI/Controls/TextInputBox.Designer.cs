namespace MegaFUSE.UI.Controls
{
    partial class TextInputBox
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
            this.inputControl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputControl
            // 
            this.inputControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.inputControl.Location = new System.Drawing.Point(5, 5);
            this.inputControl.Multiline = true;
            this.inputControl.Name = "inputControl";
            this.inputControl.Size = new System.Drawing.Size(173, 29);
            this.inputControl.TabIndex = 0;
            // 
            // TextInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.inputControl);
            this.Name = "TextInputBox";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(183, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputControl;
    }
}
