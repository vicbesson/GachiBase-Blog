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
    public partial class UserListForm : Form
    {
        db tmpdb = new db();
        public UserListForm()
        {
            InitializeComponent();
            LoadUsers();
        }
        private void LoadUsers()
        {
            DataTable dat01 = tmpdb.LoadUsers();
            int alternatingcolor = 1;
            foreach (DataRow row in dat01.Rows)
            {
                if (MainForm.currentUser != null)
                {
                    if (row["UserID"].ToString() == MainForm.currentUser.UserID)
                        continue;
                    if (MainForm.currentUser.Admin == false)
                        if ((bool)row["Banned"])
                            continue;
                }
                Panel pntmp = new Panel();
                Label lblUser = new Label();
                Label lblEmail = new Label();
                Label lblJoinDate = new Label();
                Label lblNum = new Label();
                Label lblBanned = new Label();
                Label lblAdmin = new Label();
                PictureBox pbAvatar = new PictureBox();
                pntmp.Width = pnUsers.Width - 6;
                pntmp.Height = pnUsers.Height / 5;
                if (alternatingcolor == 1)
                    pntmp.BackColor = Color.PaleGreen;
                else
                    pntmp.BackColor = Color.GreenYellow;
                lblUser.Font = new Font("Impact", 15, FontStyle.Regular);
                lblEmail.Font = new Font("Arial", 8, FontStyle.Bold);
                lblJoinDate.Font = new Font("Impact", 7, FontStyle.Regular);
                lblNum.Font = new Font("Impact", 8, FontStyle.Regular);
                lblBanned.Font = new Font("Impact", 8, FontStyle.Regular);
                lblAdmin.Font = new Font("Impact", 8, FontStyle.Regular);
                pbAvatar.Size = new Size(pntmp.Height * 2 / 3, pntmp.Height * 2 / 3);
                pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                pbAvatar.Image = db.ByteArrayToImage((byte[])row["AvatarImage"]);
                pbAvatar.Top = 5;
                pbAvatar.Left = 5;
                lblUser.TextAlign = ContentAlignment.MiddleLeft;
                lblEmail.TextAlign = ContentAlignment.MiddleLeft;
                lblJoinDate.TextAlign = ContentAlignment.MiddleLeft;
                lblNum.TextAlign = ContentAlignment.MiddleLeft;
                lblBanned.TextAlign = ContentAlignment.MiddleLeft;
                lblUser.Text = row["Username"].ToString();
                lblUser.Width = TextRenderer.MeasureText(lblUser.Text, lblUser.Font, lblUser.MaximumSize).Width;
                lblUser.AutoSize = true;
                lblUser.Left = pbAvatar.Left + pbAvatar.Width;
                lblUser.Top = pbAvatar.Height / 2 - lblUser.Height / 2;
                lblNum.Text = $"NumPosts: {row["NumPosts"].ToString()}   NumPages: {row["NumPages"].ToString()}   NumComments: {row["NumComments"].ToString()}";
                lblNum.Width = TextRenderer.MeasureText(lblNum.Text, lblNum.Font, lblNum.MaximumSize).Width;
                lblNum.AutoSize = true;
                lblNum.Top = pntmp.Height - lblNum.Height;
                lblNum.Left = 5;
                lblAdmin.Text = "Admin";
                lblAdmin.Width = TextRenderer.MeasureText(lblAdmin.Text, lblAdmin.Font, lblAdmin.MaximumSize).Width;
                lblAdmin.AutoSize = true;
                lblAdmin.Left = pntmp.Width - lblAdmin.Width - 5;
                if ((int)row["Admin"] == 1)
                    lblAdmin.Text = "Admin";
                else
                    lblAdmin.Text = "     ";
                lblAdmin.Top = 5;
                lblAdmin.ForeColor = Color.DodgerBlue;
                if(MainForm.currentUser != null)
                    if(MainForm.currentUser.Admin)
                    {
                        lblJoinDate.Top = pbAvatar.Top;
                        lblJoinDate.Left = pbAvatar.Left + pbAvatar.Width + 3;
                        lblJoinDate.Text = $"Join Date: {row["JoinDate"].ToString()}";
                        lblJoinDate.Width = TextRenderer.MeasureText(lblJoinDate.Text, lblJoinDate.Font, lblJoinDate.MaximumSize).Width;
                        pntmp.Controls.Add(lblJoinDate);
                        lblEmail.Top = lblUser.Top + lblUser.Height;
                        lblEmail.Left = lblUser.Left;
                        lblEmail.Text = row["Email"].ToString();
                        lblEmail.Width = TextRenderer.MeasureText(lblEmail.Text, lblEmail.Font, lblEmail.MaximumSize).Width;
                        pntmp.Controls.Add(lblEmail);
                        lblBanned.Text = "Banned";
                        lblBanned.Width = TextRenderer.MeasureText(lblBanned.Text, lblBanned.Font, lblBanned.MaximumSize).Width;
                        lblBanned.AutoSize = true;
                        lblBanned.Left = pntmp.Width - lblBanned.Width - 5;
                        if ((bool)row["Banned"] == true)
                            lblBanned.Text = "Banned";
                        else
                            lblBanned.Text = "      ";
                        lblBanned.Top = lblAdmin.Top + lblAdmin.Height;
                        lblBanned.ForeColor = Color.Red;
                        pntmp.Controls.Add(lblBanned);
                        Button btnPromote = new Button();
                        Button btnBan = new Button();
                        btnPromote.Width = ((pntmp.Width - (lblNum.Width + lblNum.Left)) / 2) - 5;
                        btnPromote.Height = pntmp.Height - (lblEmail.Top + lblEmail.Height) - 4;
                        btnPromote.Font = new Font("Impact", 9, FontStyle.Regular);
                        btnPromote.TextAlign = ContentAlignment.MiddleCenter;
                        if (lblAdmin.Text == "Admin")
                            btnPromote.Text = "Demote";
                        else
                            btnPromote.Text = "Promote";
                        btnPromote.Left = lblNum.Left + lblNum.Width + 3;
                        btnPromote.Top = lblEmail.Top + lblEmail.Height;
                        btnPromote.FlatStyle = FlatStyle.Flat;
                        btnPromote.BackColor = Color.MediumPurple;
                        btnPromote.Click += new EventHandler((sender, e) => btnPromoteDemote_Click(sender, e, row["UserID"].ToString(), btnPromote, lblAdmin)); 
                        if (lblBanned.Text != "Banned")
                            btnBan.Text = "Ban";
                        else
                            btnBan.Text = "UnBan";
                        btnBan.Width = btnPromote.Width;
                        btnBan.Height = btnPromote.Height;
                        btnBan.Top = btnPromote.Top;
                        btnBan.Left = btnPromote.Left + btnPromote.Width + 3;
                        btnBan.FlatStyle = FlatStyle.Flat;
                        btnBan.BackColor = Color.MediumPurple;
                        btnBan.Font = new Font("Impact", 9, FontStyle.Regular);
                        btnBan.TextAlign = ContentAlignment.MiddleCenter;
                        btnBan.Click += new EventHandler((sender, e) => btnBan_Click(sender, e, row["UserID"].ToString(), btnBan, lblBanned));
                        pntmp.Controls.Add(btnBan);
                        pntmp.Controls.Add(btnPromote);
                    }
                pntmp.Controls.Add(lblAdmin);
                pntmp.Controls.Add(lblNum);
                pntmp.Controls.Add(pbAvatar);
                pntmp.Controls.Add(lblUser);
                pnUsers.Controls.Add(pntmp);
                alternatingcolor *= -1;
            }
        }
        private void btnBan_Click(object sender, EventArgs e, string id, Button btn, Label lbl)
        {
            if (MainForm.currentUser != null)
            {
                if (btn.Text == "Ban")
                {
                    btn.Text = "UnBan";
                    lbl.Text = "Banned";
                    tmpdb.BanUser(id, true);
                }
                else
                {
                    btn.Text = "Ban";
                    lbl.Text = "      ";
                    tmpdb.BanUser(id, false);
                }
            }
            else
            {
                MessageBox.Show("No User Currently Logged In");
                this.Close();
            }
        }
        private void btnPromoteDemote_Click(object sender, EventArgs e, string ID, Button btn, Label lbl)
        {
            if (MainForm.currentUser != null)
            {
                if (btn.Text == "Promote")
                {
                    btn.Text = "Demote";
                    lbl.Text = "Admin";
                    tmpdb.PromoteDemoteUser(ID, true);
                }
                else
                {
                    btn.Text = "Promote";
                    lbl.Text = "     ";
                    tmpdb.PromoteDemoteUser(ID, false);
                }
            }
            else
            {
                MessageBox.Show("No User Currently Logged In");
                this.Close();
            }
        }
    }
}
