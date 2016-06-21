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
    public partial class New_File : Form
    {
        public New_File()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormChild c = new FormChild();
            c.MdiParent = (this.MdiParent as FormMain) ;
            c.Text = textBox1.Text;
            c.Show();
            textBox1.Clear();
            this.Hide();
        }
    }
}
