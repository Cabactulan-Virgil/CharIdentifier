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
    public partial class CharIndentifier : Form
    {
        public CharIndentifier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string inputText = tb1INPUT.Text;

            if (string.IsNullOrEmpty(tb1INPUT.Text))
            {
                MessageBox.Show("Input Error", "Please enter a character.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (char.IsDigit(tb1INPUT.Text[0]))
            {
                MessageBox.Show("Character Identification", $"You entered a digit: {tb1INPUT.Text}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (char.IsLetter(tb1INPUT.Text[0]))
            {
                MessageBox.Show("Character Identification", $"You entered a character: {tb1INPUT.Text}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (char.IsPunctuation(tb1INPUT.Text[0]) || char.IsSymbol(tb1INPUT.Text[0]))
            {
                MessageBox.Show("Character Identification", $"You entered a special character: {tb1INPUT.Text}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Character Identification", $"You entered an invalid character: {tb1INPUT.Text}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tb1INPUT.Text = "";
        }

        private void tb1INPUT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
