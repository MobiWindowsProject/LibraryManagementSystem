using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getID()
        {
            // Fetch data from database

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (username.ToLower() == "mubashir" && password == "abc123")
            { // Correct credentials logic
                this.lblError.Hide();
                this.tbPassword.Text = "";
                this.tbUsername.Text = "";
                MessageBox.Show("Login Successful");
                
            }
            else 
            { // Wrong credentials logic 
                this.lblError.Show();
                this.tbPassword.Text = "";
                this.tbUsername.Text = "";
            }
        }
    }
}
