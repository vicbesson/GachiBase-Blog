using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Systems_Analysis_Final_Project_by_Victor_Besson
{
    public partial class PostForm : Form
    {
        db tmpdb = new db();
        public PostForm()
        {
            InitializeComponent();
            if (MainForm.currentUser != null)
            {
                btnComment.Show();
                rtxtComment.Show();
            }
            else
            {
                pnComments.Height = this.ClientSize.Height - pnComments.Top - 20;
            }
            LoadInfo();
            LoadEverythingElse();
            LoadComments();
        }
        private void LoadInfo()
        {
            DataTable dat01 = tmpdb.LoadFullPostInfo(MainForm.CurrentOpenedFormID);
            Label lblTitle = new Label();
            Label lblPostDate = new Label();
            Label lblUser = new Label();
            Panel tmpPanel = new Panel();
            tmpPanel.Width = pnPost.Width - 6;
            tmpPanel.Height = pnPost.Height / 6;
            tmpPanel.BackColor = Color.Plum;
            lblTitle.Font = new Font("Impact", 12, FontStyle.Regular);
            lblTitle.Text = dat01.Rows[0]["Title"].ToString();
            lblTitle.Width = tmpPanel.Width;
            lblTitle.Top = 0;
            lblTitle.Left = 0;
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            lblUser.Left = 0;
            lblUser.Top = lblTitle.Height;
            lblUser.Font = new Font("Impact", 8, FontStyle.Regular);
            lblUser.Text = "Posted By: " + dat01.Rows[0]["UserName"].ToString();
            lblUser.Width = TextRenderer.MeasureText(lblUser.Text, lblUser.Font, lblUser.MaximumSize).Width;
            lblPostDate.TextAlign = ContentAlignment.MiddleLeft;
            lblPostDate.Top = lblUser.Top;
            lblPostDate.Left = lblUser.Width;
            lblPostDate.Text = dat01.Rows[0]["TimeAgo"].ToString();
            lblPostDate.Font = new Font("Impact", 8, FontStyle.Regular);
            tmpPanel.Controls.Add(lblTitle);
            tmpPanel.Controls.Add(lblUser);
            tmpPanel.Controls.Add(lblPostDate);
            pnPost.Controls.Add(tmpPanel);
        }
        private void LoadEverythingElse()
        {
            int amountofContent = 0;
            List<bool> ImageorContent = new List<bool>(); //true - image, false - content
            List<int> ContentOrder = new List<int>();
            List<int> ImageOrder = new List<int>();
            DataTable dat01 = tmpdb.LoadPostContent(MainForm.CurrentOpenedFormID);
            DataTable dat02 = tmpdb.LoadPostImage(MainForm.CurrentOpenedFormID);
            foreach (DataRow row in dat01.Rows)
                ContentOrder.Add((int)row["PostOrderNum"]);
            foreach (DataRow row in dat02.Rows)
                ImageOrder.Add((int)row["PostOrderNum"]);
            amountofContent = ContentOrder.Count + ImageOrder.Count;
            bool found = false;
            for(int i = 0; i < amountofContent; i++)
            {
                found = false;
                foreach (int tmp in ContentOrder)
                    if (tmp == i)
                    {
                        ImageorContent.Add(false);
                        ContentOrder.Remove(tmp);
                        found = true;
                        break;
                    }
                if (found)
                    continue;
                foreach (int tmp in ImageOrder)
                    if (tmp == i)
                    {
                        ImageorContent.Add(true);
                        ImageOrder.Remove(tmp);
                        break;
                    }
            }
            int ContentCounter = 0;
            int ImageCounter = 0;
            for(int i = 0; i < amountofContent; i++)
            {
                if (ImageorContent[i])
                {
                    PictureBox tmppic = new PictureBox();
                    tmppic.Image = db.ByteArrayToImage((byte[])dat02.Rows[ImageCounter]["PostImage"]);
                    tmppic.MaximumSize = new Size(pnPost.Width / 2, pnPost.Height / 2);
                    tmppic.SizeMode = PictureBoxSizeMode.AutoSize;
                    tmppic.SizeMode = PictureBoxSizeMode.Zoom;
                    pnPost.Controls.Add(tmppic);
                    ImageCounter++;
                }
                else
                {
                    Label tmpLabel = new Label();
                    tmpLabel.Font = new Font("Impact", 10, FontStyle.Regular);
                    tmpLabel.Width = pnPost.Width;
                    tmpLabel.TextAlign = ContentAlignment.MiddleLeft;
                    tmpLabel.MaximumSize = new Size(pnPost.Width, 0);
                    tmpLabel.AutoSize = true;
                    tmpLabel.Text = dat01.Rows[ContentCounter]["PostContent"].ToString();
                    pnPost.Controls.Add(tmpLabel);
                    ContentCounter++;
                }
            }
        }
        private void LoadComments()
        {
            DataTable dat01 = tmpdb.LoadComments(MainForm.CurrentOpenedFormID);
            int alternatingColor = 1;
            foreach(DataRow row in dat01.Rows)
            {
                Label lblUser = new Label();
                Label lblCommentDate = new Label();
                Panel pnInfo = new Panel();
                pnInfo.Width = pnComments.Width - 23;
                pnInfo.Height = 40;
                lblUser.Left = 0;
                lblUser.Top = 0;
                lblUser.Text = row["UserName"].ToString();
                lblUser.Font = new Font("Impact", 10, FontStyle.Regular);
                lblUser.Height = pnInfo.Height;
                lblUser.TextAlign = ContentAlignment.MiddleLeft;
                lblUser.Width = TextRenderer.MeasureText(lblUser.Text, lblUser.Font, lblUser.MaximumSize).Width;
                lblCommentDate.Text = row["TimeAgo"].ToString();
                lblCommentDate.Font = new Font("Impact", 8, FontStyle.Regular);
                lblCommentDate.TextAlign = ContentAlignment.MiddleLeft;
                lblCommentDate.Top = lblUser.Top;
                lblCommentDate.Left = lblUser.Width;
                lblCommentDate.Height = pnInfo.Height;
                lblCommentDate.Width = TextRenderer.MeasureText(lblCommentDate.Text, lblCommentDate.Font, lblCommentDate.MaximumSize).Width;
                Label tmpLabel = new Label();
                tmpLabel.Font = new Font("Impact", 9, FontStyle.Regular);
                tmpLabel.Width = pnComments.Width;
                tmpLabel.TextAlign = ContentAlignment.MiddleLeft;
                tmpLabel.MaximumSize = new Size(pnComments.Width, 0);
                tmpLabel.AutoSize = true;
                tmpLabel.Text = row["CommentContent"].ToString();
                pnInfo.Controls.Add(lblUser);
                pnInfo.Controls.Add(lblCommentDate);
                pnComments.Controls.Add(pnInfo);
                pnComments.Controls.Add(tmpLabel);
                if (alternatingColor == 1)
                    pnInfo.BackColor = Color.Violet;
                else
                    pnInfo.BackColor = Color.Thistle;
                if (MainForm.currentUser != null)
                    if (MainForm.currentUser.Admin)
                    {
                        Button btnDelete = new Button();
                        btnDelete.Width = (pnInfo.Width - (lblCommentDate.Left + lblCommentDate.Width)) / 5;
                        btnDelete.Text = "Delete";
                        btnDelete.FlatStyle = FlatStyle.Flat;
                        btnDelete.BackColor = Color.LightPink;
                        btnDelete.Font = new Font("Impact", 8, FontStyle.Regular);
                        btnDelete.Height = pnInfo.Height;
                        btnDelete.Left = pnInfo.Width - btnDelete.Width;
                        btnDelete.Top = 0;
                        btnDelete.Click += new EventHandler((sender, e) => btnDelete_Click(sender, e, row["CommentID"].ToString(), row["Username"].ToString(), pnInfo, tmpLabel));
                        pnInfo.Controls.Add(btnDelete);
                    }
            }
        }
        private void btnComment_Click(object sender, EventArgs e)
        {
            if (tmpdb.CheckPost(MainForm.CurrentOpenedFormID) == 1)
            {
                if (rtxtComment.ForeColor != Color.DimGray)
                {
                    tmpdb.CreateComment(MainForm.CurrentOpenedFormID, MainForm.currentUser.UserID, rtxtComment.Text);
                    pnComments.Controls.Clear();
                    LoadComments();
                    rtxtComment.Clear();
                }
            }
            else
            {
                MessageBox.Show("This Post Does not Exist");
                this.Close();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e, string CommentID, string userName, Panel pn, Label lbl)
        {
            tmpdb.DeleteComment(CommentID, userName);
            pn.Dispose();
            lbl.Dispose();
        }
        private void rtxtComment_Enter(object sender, EventArgs e)
        {
            if (rtxtComment.ForeColor == Color.DimGray)
            {
                rtxtComment.Clear();
                rtxtComment.ForeColor = Color.Black;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tmpdb.CheckPost(MainForm.CurrentOpenedFormID) == 1)
            {
                pnComments.Controls.Clear();
                LoadComments();
            }
            else
            {
                MessageBox.Show("This Post Does not Exist");
                this.Close();
            }
        }
    }
}
