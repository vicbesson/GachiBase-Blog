using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systems_Analysis_Final_Project_by_Victor_Besson
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static bool LoggedIn = false;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            db tmpdb = new db();
            try
            {
                if (tmpdb.Login(txtUsername.Text, txtPassword.Text))
                {
                    MainForm.currentUser = new User(tmpdb.LoadUser(txtUsername.Text, txtPassword.Text));
                    if (MainForm.currentUser.Banned)
                    {
                        MainForm.currentUser = null;
                        throw new Exception("This User Is Banned");
                    }
                    else
                        LoggedIn = true;
                    this.Close();
                }
                else
                {
                    throw new Exception("Username or password is incorrect");
                }
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
