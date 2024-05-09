using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07.Checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.checkBox1.CheckState = CheckState.Checked;
            this.checkBox2.CheckState = CheckState.Unchecked;
            this.checkBox3.CheckState = CheckState.Indeterminate;
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.checkBox4.Checked.ToString());
        }
    }
}
