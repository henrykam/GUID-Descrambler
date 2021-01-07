using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UUID_Descrambler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void includeDashesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            inputTextBox_TextChanged(sender, e);
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = inputTextBox.Text.Trim();
            if (ValidateFormat(inputTextBox.Text))
            {
                if (TryScramble(input, out string output, includeDashesCheckBox.Checked))
                {
                    outputTextBox.Text = output;
                    validLabel.Text = "Valid";
                }
                else
                {
                    validLabel.Text = "UUID cannot be descrambled";
                    validLabel.ForeColor = Color.Red;
                    return;
                }

                validLabel.ForeColor = Color.Green;
            }
            else
            {
                validLabel.Text = "Invalid";
                validLabel.ForeColor = Color.Red;
            }                        
        }

        private bool ValidateFormat(string input)
        {
            if (!Regex.IsMatch(input, "^[a-zA-Z0-9]{8}-?[a-zA-Z0-9]{4}-?[a-zA-Z0-9]{4}-?[a-zA-Z0-9]{4}-?[a-zA-Z0-9]{12}$"))
            {
                return false;
            }            
            return true;
        }

        private bool TryScramble(string input, out string output, bool addDashes = false)
        {
            // remove dashes
            string temp = input.Replace("-", "").Trim();
            output = temp.Substring(6, 2) 
                + temp.Substring(4, 2) 
                + temp.Substring(2, 2) 
                + temp.Substring(0, 2)
                + (addDashes ? "-" : "")
                + temp.Substring(10, 2)
                + temp.Substring(8, 2)
                + (addDashes ? "-" : "")
                + temp.Substring(14, 2) 
                + temp.Substring(12, 2)
                + (addDashes ? "-" : "")
                + temp.Substring(16, 4)
                + (addDashes ? "-" : "")
                + temp.Substring(20, 12);
            return Guid.TryParse(output, out Guid res);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputTextBox.Text);
        }
    }
}
