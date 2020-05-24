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

namespace InputValidater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_Validating(object sender, CancelEventArgs e)
        {

           //must have at least 2 digits, 2 upper case and 2 lower case letters, 2 chars that are not letters, 10 chars long
            string passPattern = @"^(?=(.*\d){2})(?=(.*[A-Z]){2})(?=(.*[a-z]){2})(?=(.*[^0-9a-zA-Z]){2}).{10,}";


            Regex regex = new Regex(passPattern);


            if (regex.IsMatch(txtInput.Text))
            {
                errInput.Clear();                   //no error
                lblError.Text = "Input is valid";
            }
            else
            {                
                errInput.SetError(this.txtInput, "  "); //dispay error message
                lblError.Text = "Not a valid password!";
                txtInput.Text = String.Empty;   //clear bad input from textbox
                txtInput.Focus();               //set focus on testbox
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            //add code here
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            errInput.Clear();
            lblError.Text = String.Empty;
        }
    }
}
