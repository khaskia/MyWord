namespace jSkinExample
{
    partial class frmExample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExample));
            this.ctlModernBlack1 = new jSkin.ctlModernBlack();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctlModernBlack1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlModernBlack1
            // 
            this.ctlModernBlack1.Controls.Add(this.pictureBox1);
            this.ctlModernBlack1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlModernBlack1.FixedSingle = false;
            this.ctlModernBlack1.Location = new System.Drawing.Point(0, 0);
            this.ctlModernBlack1.Name = "ctlModernBlack1";
            this.ctlModernBlack1.Size = new System.Drawing.Size(309, 117);
            this.ctlModernBlack1.Stretch = true;
            this.ctlModernBlack1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 117);
            this.Controls.Add(this.ctlModernBlack1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(309, 117);
            this.Name = "frmExample";
            this.Text = "jSkin Example";
            this.ctlModernBlack1.ResumeLayout(false);
            this.ctlModernBlack1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private jSkin.ctlModernBlack ctlModernBlack1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

