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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            db tmpdb = new db();
            try
            {
                if ((txtEmail.Text == txtEmailCheck.Text) && (txtPassword.Text == txtPasswordCheck.Text) && (txtPassword.Text.Trim() != "") && (txtEmail.Text.Trim() != "") && (txtUser.Text.Trim() != "") && (txtEmail.Text.Trim().Contains(" ") == false) && (txtUser.Text.Trim().Contains(" ") == false))
                    createUser(tmpdb);
                else
                {
                    if ((txtEmail.Text != txtEmailCheck.Text) || (txtPassword.Text != txtPasswordCheck.Text))
                        throw new Exception($"Emails or passwords {Environment.NewLine} do not match!");
                    else if (txtUser.Text.Trim() == "")
                        throw new Exception("Must enter username!");
                    else if (txtEmail.Text.Trim() == "")
                        throw new Exception("Must enter email!");
                    else if (txtPassword.Text.Trim() == "")
                        throw new Exception("Must enter password!");
                    else if (txtUser.Text.Trim().Contains(" "))
                        throw new Exception($"Username can not{Environment.NewLine}contain spaces!");
                    else if (txtEmail.Text.Trim().Contains(" "))
                        throw new Exception("Invalid Email!");
                    else if (txtEmail.Text.Trim().Length > 64)
                        throw new Exception("Max Email Length is 64");
                    else if (txtUser.Text.Trim().Length > 20)
                        throw new Exception("Max Username Length is 20");
                    else if (txtPassword.Text.Trim().Length > 255)
                        throw new Exception("Max Password Length is 255");
                }
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
        private void createUser(db tmpdb)
        {
            try
            {
                if (pbAvatar.Image == null)
                {
                    if (tmpdb.CreateUser(txtUser.Text, txtPassword.Text, txtEmail.Text) == false)
                        throw new Exception($"Username or{Environment.NewLine}Email Already Taken!");
                    else
                        this.Close();
                }
                else
                {
                    if (tmpdb.CreateUser(txtUser.Text, txtPassword.Text, txtEmail.Text, pbAvatar.Image) == false)
                        throw new Exception($"Username or{Environment.NewLine}Email Already Taken!");
                    else
                        this.Close();
                }
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All Files| *.*| Image Files | *.jpg; *.gif; *.png; *.bmp";
            fd.FilterIndex = 2;
            DialogResult check = fd.ShowDialog();
            if (check is DialogResult.OK)
            {
                pbAvatar.Image = new Bitmap(fd.FileName);
            }
            
        }
    }
}
