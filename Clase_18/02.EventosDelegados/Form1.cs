using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.Eventos_y_delegados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void ClickEventHandler(object sender, EventArgs e);

        public event ClickEventHandler Click;

        private void OnClick(object sender, EventArgs e)
        {
            Click.Invoke(this, e);
        } 
    }
}
