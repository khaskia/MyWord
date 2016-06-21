using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myword
{

    




    public partial class FormMain : Form
    {
        public  string NumofChar
        {
            set { Lbl_Char.Text=value; }

        }

        public  string Numoflines
        {
           set { lbl_line.Text = value; }
        }

        


        public FormMain()
        {
            InitializeComponent();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            New_File nf = new New_File();
            nf.MdiParent = this;
            nf.Show();


        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // menue Style
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.ForeColor = Color.Gold;
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Height = 45;
            menuStrip1.Font = new Font("arial", 10);


            // State bar

            lbl_Time.Text = DateTime.Now.ToLongTimeString();


            // change the stupid  Gray color 
            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.Purple;
                }


            }



        }

        private void Arrange_click(object sender, EventArgs e)
        {
            if(sender==verticalToolStripMenuItem){
                this.LayoutMdi(MdiLayout.TileVertical);
            }

            if (sender == horzintalToolStripMenuItem)
            {
                this.LayoutMdi(MdiLayout.TileHorizontal);
            }

            if (sender == cascadeToolStripMenuItem)
            {
                this.LayoutMdi(MdiLayout.Cascade);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormChild child = this.ActiveMdiChild as FormChild;

            saveFileDialog1.Filter = "Documents|*.doc";
            saveFileDialog1.FileName = child.Text; 
            DialogResult res =  saveFileDialog1.ShowDialog();
            
            if (res == DialogResult.OK)
            {
               
                child.TextControl.SaveFile(saveFileDialog1.FileName);
            }
            else
            {
                // DoNothing
            }


        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Documets|*.doc;*.docx";
             DialogResult res= openFileDialog1.ShowDialog();
             if (res == DialogResult.OK)
             {
                 FormChild ch = new FormChild();
                 ch.MdiParent = this;
                 ch.Show();
                 ch.TextControl.LoadFile(openFileDialog1.FileName);
             }
             else
             {
                 // DonNoThing
             }

        }

        private void Edit(object sender, EventArgs e)
        {
            FormChild ch = this.ActiveMdiChild as FormChild;
            if (sender == cutToolStripMenuItem)
            {
                ch.TextControl.Cut();
            }
            if (sender == copyToolStripMenuItem)
            {
                ch.TextControl.Copy();
            }
            if (sender == pasteToolStripMenuItem)
            {
                ch.TextControl.Paste();
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            FormChild ch = this.ActiveMdiChild as FormChild;
            if (sender == cutToolStripMenuItem1)
            {
                ch.TextControl.Cut();
            }
            if (sender == copyToolStripMenuItem1)
            {
                ch.TextControl.Copy();
            }
            if (sender == pasteToolStripMenuItem1)
            {
                ch.TextControl.Paste();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fontDialog1.ShowDialog();
                FormChild child = this.ActiveMdiChild as FormChild;
                child.TextControl.SelectionFont = fontDialog1.Font;
            }
            catch { }
            

            




        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1.ShowDialog();
                FormChild child = this.ActiveMdiChild as FormChild;
                child.TextControl.SelectionColor = colorDialog1.Color;
            }
            catch { }
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                fontDialog1.ShowDialog();
                FormChild child = this.ActiveMdiChild as FormChild;
                child.TextControl.SelectionFont = fontDialog1.Font;
            }
            catch { }
            

        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1.ShowDialog();
                FormChild child = this.ActiveMdiChild as FormChild;
                child.TextControl.SelectionColor = colorDialog1.Color;
            }
            catch { }
        }
    }
}
