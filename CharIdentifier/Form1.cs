using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharIdentifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void START_Click(object sender, EventArgs e)
        {
            CharIndentifier start = new CharIndentifier();
            start.Show();
            this.Hide();
        }
    }
}
