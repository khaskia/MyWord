namespace Myword
{
    partial class Form2
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
            this.ctlModernBlack1 = new jSkin.ctlModernBlack();
            this.SuspendLayout();
            // 
            // ctlModernBlack1
            // 
            this.ctlModernBlack1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlModernBlack1.FixedSingle = false;
            this.ctlModernBlack1.Location = new System.Drawing.Point(0, 0);
            this.ctlModernBlack1.Name = "ctlModernBlack1";
            this.ctlModernBlack1.Size = new System.Drawing.Size(292, 269);
            this.ctlModernBlack1.Stretch = false;
            this.ctlModernBlack1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.ctlModernBlack1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private jSkin.ctlModernBlack ctlModernBlack1;


    }
}