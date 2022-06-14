using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoStringFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length == 0)
                return;

            if(double.TryParse(inputTextBox.Text, out double result))
            {
                //Convert number to string with decimal formatting
                resultLabel.Text = result.ToString("N4");
            }
            else
            {
                MessageBox.Show(this, "Invalid input", "Please input a valid string that representate as number.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                inputTextBox.Text = string.Empty;
            }
        }
    }
}
