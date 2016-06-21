namespace Myword
{
    partial class New_File
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctlModernBlack1 = new jSkin.ctlModernBlack();
            this.panel1.SuspendLayout();
            this.ctlModernBlack1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "انشاء";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(22, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 77);
            this.panel1.TabIndex = 1;
            // 
            // ctlModernBlack1
            // 
            this.ctlModernBlack1.Controls.Add(this.panel1);
            this.ctlModernBlack1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlModernBlack1.FixedSingle = false;
            this.ctlModernBlack1.Location = new System.Drawing.Point(0, 0);
            this.ctlModernBlack1.Name = "ctlModernBlack1";
            this.ctlModernBlack1.Size = new System.Drawing.Size(357, 140);
            this.ctlModernBlack1.Stretch = false;
            this.ctlModernBlack1.TabIndex = 2;
            // 
            // New_File
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 140);
            this.Controls.Add(this.ctlModernBlack1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New_File";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_File";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ctlModernBlack1.ResumeLayout(false);
            this.ctlModernBlack1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private jSkin.ctlModernBlack ctlModernBlack1;

        public System.Windows.Forms.TextBox TextBox1
        {
            get { return textBox1; }
            set { textBox1 = value; }
        }
    }
}