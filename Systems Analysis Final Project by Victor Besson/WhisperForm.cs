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
    public partial class WhisperForm : Form //Added Timer so you can load new whispers without clicking reload
    {
        db tmpdb = new db();
        public WhisperForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string User;
            string Whisper = "";
            if (MainForm.currentUser != null)
            {
                if (rtxtWhisper.Text.ToUpper().Contains("/WHISPER "))
                {
                    if (rtxtWhisper.Text.IndexOf(" ", rtxtWhisper.Text.IndexOf(" ") + 1) > 0)
                    {
                        User = rtxtWhisper.Text.Substring(rtxtWhisper.Text.ToUpper().IndexOf("/WHISPER"), (rtxtWhisper.Text.IndexOf(" ", rtxtWhisper.Text.IndexOf(" ") + 1) - rtxtWhisper.Text.ToUpper().IndexOf("/WHISPER")));
                        Whisper = rtxtWhisper.Text.Remove(rtxtWhisper.Text.ToUpper().IndexOf("/WHISPER"), rtxtWhisper.Text.IndexOf(" ", rtxtWhisper.Text.IndexOf(" ") + 1) + 1);
                    }
                    else
                    {
                        User = rtxtWhisper.Text.Substring(rtxtWhisper.Text.ToUpper().IndexOf("/WHISPER"), (rtxtWhisper.Text.Length - rtxtWhisper.Text.ToUpper().IndexOf("/WHISPER")));
                    }
                    User = User.Remove(rtxtWhisper.Text.ToUpper().IndexOf("/WHISPER"), 9);
                    if (tmpdb.GetUserID(User) != "" && User != MainForm.currentUser.UserName)
                    {
                        tmpdb.SendWhisper(MainForm.currentUser.UserID, tmpdb.GetUserID(User), Whisper);
                    }
                    else
                    {
                        if (User == MainForm.currentUser.UserName)
                            MessageBox.Show("User can not be current User");
                        else
                            MessageBox.Show("User Does Not Exist");
                    }
                }
                else
                {
                    MessageBox.Show("Must Choose Someone to Whisper");
                }
                rtxtWhisper.Clear();
            }
            else
            {
                MessageBox.Show("No User Currently Logged In");
                this.Close();
            }
        }
        private void loadNewWhispers()
        {
            DataTable dat01 = tmpdb.LoadNewWhispers(MainForm.currentUser.UserID, MainForm.LastWhisperID);
            CreatePanels(dat01);
        }
        private void CreatePanels(DataTable dat01)
        {
            if (dat01.Rows.Count > 0)
            {
                MainForm.LastWhisperID = dat01.Rows[dat01.Rows.Count - 1]["WhisperID"].ToString();
                foreach (DataRow row in dat01.Rows)
                {
                    Panel tmppanel = new Panel();
                    Label lblWhisper = new Label();
                    Label lblUser = new Label();
                    Label lblDate = new Label();
                    tmppanel.Width = pnWhispers.Width - 6;
                    if (row["SendingUser"].ToString() == MainForm.currentUser.UserID)
                    {
                        lblUser.Text = $"To {row["SentUser"].ToString()}: ";
                    }
                    else
                    {
                        lblUser.Text = $"{row["UserName"].ToString()}: ";
                    }
                    lblWhisper.Text = $"{row["WhisperContent"].ToString()}";
                    lblWhisper.Font = new Font("Arial", 8, FontStyle.Regular);
                    lblDate.Font = new Font("Arial", 7, FontStyle.Bold);
                    lblUser.Font = new Font("Impact", 9, FontStyle.Regular);
                    lblUser.Top = 5;
                    lblUser.Left = 5;
                    lblUser.Width = TextRenderer.MeasureText(lblUser.Text, lblUser.Font, lblUser.MaximumSize).Width;
                    tmppanel.Controls.Add(lblUser);
                    lblWhisper.Top = lblUser.Top;
                    lblWhisper.Left = lblUser.Left + lblUser.Width;
                    lblWhisper.Font = new Font("Arial", 8, FontStyle.Regular);
                    lblWhisper.Height = TextRenderer.MeasureText(lblWhisper.Text, lblWhisper.Font, lblWhisper.MaximumSize).Height;
                    lblWhisper.MaximumSize = new Size(tmppanel.Width - lblUser.Width + lblUser.Left, 0);
                    lblWhisper.AutoSize = true;
                    tmppanel.Controls.Add(lblWhisper);
                    lblDate.Text = row["TimeAgo"].ToString();
                    lblDate.Left = lblWhisper.Left;
                    lblDate.Top = lblWhisper.Top + lblWhisper.Height;
                    lblDate.Width = TextRenderer.MeasureText(lblDate.Text, lblDate.Font, lblDate.MaximumSize).Width;
                    lblDate.AutoSize = true;
                    tmppanel.Controls.Add(lblDate);
                    tmppanel.Height = lblDate.Top + lblDate.Height + 5;
                    tmppanel.BackColor = Color.Pink;
                    pnWhispers.Controls.Add(tmppanel);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MainForm.currentUser != null)
                loadNewWhispers();
        }

        private void WhisperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Dispose();
        }
    }
}
