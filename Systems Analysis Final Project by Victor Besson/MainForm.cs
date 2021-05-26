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
    public partial class MainForm : Form
    {
        db tempdb = new db();
        public MainForm()
        {
            InitializeComponent();
            if (tempdb.testConnection())
            {
                LoadPosts();
                LoadPages();
            }
            else
            {
                MessageBox.Show("Cannot connect to server");
                this.Close();
            }
        }
        public static User currentUser;
        public static string CurrentOpenedFormID;
        public static string LastWhisperID = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form tmp = new LoginForm();
            tmp.ShowDialog();
            if (LoginForm.LoggedIn)
            {
                btnLogin.Hide();
                btnRegister.Hide();
                btnLogOut.Show();
                pbAvatar.Show();
                lblCurrentUser.Show();
                lblCurrentUser.Text = currentUser.UserName;
                pbAvatar.Image = currentUser.Avatar;
                btnUserList.Show();
                btnWhispers.Show();
            }
            if(currentUser != null)
                if (currentUser.Admin)
                {
                    btnAddPage.Show();
                    btnAddPost.Show();
                }
            LoadPosts();
            LoadPages();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form tmp = new RegisterForm();
            tmp.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            btnLogin.Show();
            btnRegister.Show();
            btnLogOut.Hide();
            pbAvatar.Image = null;
            pbAvatar.Hide();
            lblCurrentUser.Hide();
            LoginForm.LoggedIn = false;
            btnAddPage.Hide();
            btnAddPost.Hide();
            currentUser = null;
            btnUserList.Hide();
            btnWhispers.Hide();
            LoadPosts();
            LoadPages();
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            Form tmp = new CreatePageForm();
            tmp.ShowDialog();
            pnPages.Controls.Clear();
            LoadPages();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            Form tmp = new CreatePostForm();
            tmp.ShowDialog();
            pnPosts.Controls.Clear();
            LoadPosts();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<UserListForm>().Count() < 1)
            {
                Form tmp = new UserListForm();
                tmp.Show();
            }
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }
        private void LoadPosts()
        {
            pnPosts.Controls.Clear();
            DataTable dat01 = tempdb.LoadPostInfo();
            int alternatingColor = 1;
            foreach(DataRow row in dat01.Rows)
            {
                Panel tmpPanel = new Panel();
                Label lblTitle = new Label();
                Label lblPostDate = new Label();
                Label lblUser = new Label();
                lblTitle.AutoSize = true;
                lblTitle.Font = new Font("Impact", 12, FontStyle.Regular);
                lblTitle.Text = row["Title"].ToString();
                lblTitle.Top = 0;
                lblTitle.Left = 0;
                tmpPanel.Width = pnPosts.Width - 6;
                tmpPanel.Height = pnPosts.Height / 8;
                lblTitle.MaximumSize = new Size(tmpPanel.Width, tmpPanel.Height / 2);
                lblTitle.Width = tmpPanel.Width;
                lblTitle.Height = tmpPanel.Height / 2;
                lblTitle.TextAlign = ContentAlignment.MiddleLeft;
                lblTitle.Tag = "Post";
                lblTitle.Cursor = Cursors.Hand;
                if (alternatingColor == 1)
                    tmpPanel.BackColor = Color.Plum;
                else
                    tmpPanel.BackColor = Color.Thistle;
                alternatingColor *= -1;
                tmpPanel.Controls.Add(lblTitle);
                lblUser.Text = "Posted By: " + row["UserName"].ToString();
                lblPostDate.Text = row["TimeAgo"].ToString();
                lblUser.Top = tmpPanel.Height - lblUser.Height;
                lblUser.Left = 0;
                lblUser.Font = new Font("Impact", 9, FontStyle.Regular);
                lblUser.Width = TextRenderer.MeasureText(lblUser.Text, lblUser.Font, lblUser.MaximumSize).Width;
                lblPostDate.Top = lblUser.Top;
                lblPostDate.Left = lblUser.Width;
                lblPostDate.Font = new Font("Impact", 8, FontStyle.Regular);
                lblTitle.Click += new EventHandler((sender, e) => Title_Click(sender, e, row["PostID"].ToString(), lblTitle, tmpPanel));
                lblTitle.MouseEnter += new EventHandler((sender, e) => Title_Enter(sender, e, lblTitle));
                lblTitle.MouseLeave += new EventHandler((sender, e) => Title_Leave(sender, e, lblTitle));
                if (currentUser != null)
                {
                    if(currentUser.Admin)
                    {
                        Button btnDelete = new Button();
                        btnDelete.Width = tmpPanel.Width / 8;
                        btnDelete.Height = tmpPanel.Height / 2;
                        btnDelete.Text = "Delete";
                        btnDelete.FlatStyle = FlatStyle.Flat;
                        btnDelete.BackColor = Color.Violet;
                        btnDelete.Font = new Font("Impact", 10, FontStyle.Regular);
                        btnDelete.Left = tmpPanel.Width - btnDelete.Width - 5;
                        btnDelete.Top = (tmpPanel.Height / 2) - (btnDelete.Height / 2);
                        btnDelete.Click += new EventHandler((sender, e) => btnDelete_Click(sender, e, row["PostID"].ToString(), tmpPanel, "Post"));
                        tmpPanel.Controls.Add(btnDelete);
                    }
                }
                tmpPanel.Controls.Add(lblPostDate);
                tmpPanel.Controls.Add(lblUser);
                pnPosts.Controls.Add(tmpPanel);
            }
        }
        private void LoadPages()
        {
            pnPages.Controls.Clear();
            DataTable dat01 = tempdb.LoadPageInfo();
            int alternatingColor = 1;
            foreach (DataRow row in dat01.Rows)
            {
                Panel tmpPanel = new Panel();
                Label lblTitle = new Label();
                Label lblPostDate = new Label();
                Label lblUser = new Label();
                Label lblDesc = new Label();
                lblTitle.Font = new Font("Impact", 12, FontStyle.Regular);
                lblTitle.Text = row["Title"].ToString();
                lblTitle.Top = 0;
                lblTitle.Left = 0;
                lblTitle.Cursor = Cursors.Hand;
                tmpPanel.Width = pnPages.Width;
                tmpPanel.Height = 0;
                lblTitle.Width = TextRenderer.MeasureText(lblTitle.Text, lblTitle.Font, lblTitle.MaximumSize).Width;
                lblTitle.Height = TextRenderer.MeasureText(lblTitle.Text, lblTitle.Font, lblTitle.MaximumSize).Height;
                lblTitle.Tag = "Page";
                lblTitle.TextAlign = ContentAlignment.MiddleLeft;
                if (alternatingColor == 1)
                    tmpPanel.BackColor = Color.Pink;
                else
                    tmpPanel.BackColor = Color.LightPink;
                alternatingColor *= -1;
                lblDesc.Text = row["Description"].ToString();
                lblDesc.Top = lblTitle.Height;
                lblDesc.Left = 0;
                lblDesc.Font = new Font("Arial", 8, FontStyle.Regular);
                //lblDesc.Width = TextRenderer.MeasureText(lblDesc.Text, lblDesc.Font, lblDesc.MaximumSize).Width;
                lblDesc.Height = TextRenderer.MeasureText(lblDesc.Text, lblDesc.Font, lblDesc.MaximumSize).Height;
                lblDesc.MaximumSize = new Size(tmpPanel.Width, 0);
                lblDesc.AutoSize = true;
                lblUser.Text = "Created By: " + row["UserName"].ToString();
                lblPostDate.Text = row["TimeAgo"].ToString();
                tmpPanel.Controls.Add(lblDesc);
                lblUser.Left = 0;
                lblUser.Font = new Font("Impact", 9, FontStyle.Regular);
                lblUser.Width = TextRenderer.MeasureText(lblUser.Text, lblUser.Font, lblUser.MaximumSize).Width;
                lblUser.Height = TextRenderer.MeasureText(lblUser.Text, lblUser.Font, lblUser.MaximumSize).Height;
                lblUser.Top = lblDesc.Top + lblDesc.Height;
                lblPostDate.Top = lblUser.Top + lblUser.Height;
                lblPostDate.Left = 0;
                lblPostDate.Font = new Font("Impact", 8, FontStyle.Regular);
                lblPostDate.Height = TextRenderer.MeasureText(lblPostDate.Text, lblPostDate.Font, lblPostDate.MaximumSize).Height;
                lblTitle.Click += new EventHandler((sender, e) => Title_Click(sender, e, row["PageID"].ToString(), lblTitle, tmpPanel));
                lblTitle.MouseEnter += new EventHandler((sender, e) => Title_Enter(sender, e, lblTitle));
                lblTitle.MouseLeave += new EventHandler((sender, e) => Title_Leave(sender, e, lblTitle));
                if (currentUser != null)
                {
                    if (currentUser.Admin)
                    {
                        Button btnDelete = new Button();
                        btnDelete.Width = tmpPanel.Width / 4;
                        btnDelete.Height = (lblPostDate.Top + lblPostDate.Height) - lblUser.Top;
                        btnDelete.Text = "Delete";
                        btnDelete.FlatStyle = FlatStyle.Flat;
                        btnDelete.BackColor = Color.FromArgb(255, 128, 128);
                        btnDelete.Font = new Font("Impact", 10, FontStyle.Regular);
                        btnDelete.Left = tmpPanel.Width - btnDelete.Width - 5;
                        btnDelete.Top = lblUser.Top;
                        btnDelete.Click += new EventHandler((sender, e) => btnDelete_Click(sender, e, row["PageID"].ToString(), tmpPanel, "Page"));
                        tmpPanel.Controls.Add(btnDelete);
                    }
                }
                tmpPanel.Controls.Add(lblTitle);
                tmpPanel.Controls.Add(lblUser);
                tmpPanel.Controls.Add(lblPostDate);
                tmpPanel.Height += lblPostDate.Top + lblPostDate.Height + 5;
                pnPages.Controls.Add(tmpPanel);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e, string ID, Panel pn, string type)
        {
                tempdb.DeletePostorPage(type, ID);
            pn.Dispose();
        }
        private void Title_Click(object sender, EventArgs e, string tmpID, Label lbl, Panel pn)
        {
            Form tmpForm = null;
            CurrentOpenedFormID = tmpID;
            if (lbl.Tag.ToString() == "Post")
            {
                if (tempdb.CheckPost(CurrentOpenedFormID) == 1)
                {
                    tmpForm = new PostForm();
                    tmpForm.ShowDialog();
                    pnPosts.Controls.Clear();
                    LoadPosts();
                }
                else
                {
                    MessageBox.Show("This Post Does Not Exist");
                    pn.Dispose();
                }
            }
            else if (lbl.Tag.ToString() == "Page")
            {
                if (tempdb.CheckPage(CurrentOpenedFormID) == 1)
                {
                    tmpForm = new PageForm();
                    tmpForm.ShowDialog();
                    pnPages.Controls.Clear();
                    LoadPages();
                }
                else
                {
                    MessageBox.Show("This Page Does Not Exist");
                    pn.Dispose();
                }
            }
            lbl.ForeColor = Color.Black;
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }
        private void Title_Enter(object sender, EventArgs e, Label lbl)
        {
                if(lbl.Tag.ToString() == "Page")
                    lbl.ForeColor = Color.Firebrick;
                else if(lbl.Tag.ToString() == "Post")
                    lbl.ForeColor = Color.Indigo;
        }
        private void Title_Leave(object sender, EventArgs e, Label lbl)
        {
            Cursor.Current = Cursors.Arrow;
            lbl.ForeColor = Color.Black;
        }
        private void btnWhispers_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<WhisperForm>().Count() < 1)
            {
                Form tmpForm = new WhisperForm();
                tmpForm.Show();
            }
        }
        private void reload_Click(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Tag.ToString() == "Posts")
            {
                pnPosts.Controls.Clear();
                LoadPosts();
            }
            else if(((PictureBox)sender).Tag.ToString() == "Pages")
            {
                pnPages.Controls.Clear();
                LoadPages();
            }
        }
    }
}
