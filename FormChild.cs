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
    public partial class FormChild : Form
    {
        public FormChild()
        {
            InitializeComponent();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // label1 = " nom of char"  نحدد عدد الحروف الي في ليبول واحد 

           // FormMain.Lbl_Char1.Text = richTextBox1.TextLength.ToString() + "chars";
           //FormMain.Numoflines = richTextBox1.Lines.Length.ToString() +"lines";

             // without Using Static 
            (this.MdiParent as FormMain).NumofChar = "       " + richTextBox1.TextLength.ToString() + " chars       ";
            (this.MdiParent as FormMain).Numoflines = richTextBox1.Lines.Length.ToString() + " lines       ";
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void FormChild_Load(object sender, EventArgs e)
        {
            
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == cutToolStripMenuItem)
            {
                richTextBox1.Cut();
            }
            if (sender == copyToolStripMenuItem)
            {
                richTextBox1.Copy();
            }
            if (sender == pasteToolStripMenuItem)
            {
                richTextBox1.Paste();
            }
        }
    }
}
