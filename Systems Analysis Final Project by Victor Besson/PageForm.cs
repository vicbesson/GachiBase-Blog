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
    public partial class PageForm : Form
    {
        db tmpdb = new db();
        public PageForm()
        {
            InitializeComponent();
            LoadInfo();
            LoadEverythingElse();
        }
        private void LoadInfo()
        {
            DataTable dat01 = tmpdb.LoadFullPageInfo(MainForm.CurrentOpenedFormID);
            Label lblTitle = new Label();
            Label lblPostDate = new Label();
            Label lblUser = new Label();
            Panel tmpPanel = new Panel();
            tmpPanel.Width = pnPage.Width - 6;
            tmpPanel.Height = pnPage.Height / 12;
            tmpPanel.BackColor = Color.FromArgb(255, 128, 128);
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
            lblUser.Text = "Created By: " + dat01.Rows[0]["UserName"].ToString();
            lblUser.Width = TextRenderer.MeasureText(lblUser.Text, lblUser.Font, lblUser.MaximumSize).Width;
            lblPostDate.TextAlign = ContentAlignment.MiddleLeft;
            lblPostDate.Top = lblUser.Top;
            lblPostDate.Left = lblUser.Width;
            lblPostDate.Text = dat01.Rows[0]["TimeAgo"].ToString();
            lblPostDate.Font = new Font("Impact", 8, FontStyle.Regular);
            tmpPanel.Controls.Add(lblTitle);
            tmpPanel.Controls.Add(lblUser);
            tmpPanel.Controls.Add(lblPostDate);
            pnPage.Controls.Add(tmpPanel);
        }
        private void LoadEverythingElse()
        {
            int amountofContent = 0;
            List<bool> ImageorContent = new List<bool>(); //true - image, false - content
            List<int> ContentOrder = new List<int>();
            List<int> ImageOrder = new List<int>();
            DataTable dat01 = tmpdb.LoadPageContent(MainForm.CurrentOpenedFormID);
            DataTable dat02 = tmpdb.LoadPageImage(MainForm.CurrentOpenedFormID);
            foreach (DataRow row in dat01.Rows)
                ContentOrder.Add((int)row["PageOrderNum"]);
            foreach (DataRow row in dat02.Rows)
                ImageOrder.Add((int)row["PageOrderNum"]);
            amountofContent = ContentOrder.Count + ImageOrder.Count;
            bool found = false;
            for (int i = 0; i < amountofContent; i++)
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
            for (int i = 0; i < amountofContent; i++)
            {
                if (ImageorContent[i])
                {
                    PictureBox tmppic = new PictureBox();
                    tmppic.Image = db.ByteArrayToImage((byte[])dat02.Rows[ImageCounter]["PageImage"]);
                    tmppic.MaximumSize = new Size(pnPage.Width / 2, pnPage.Height / 2);
                    tmppic.SizeMode = PictureBoxSizeMode.AutoSize;
                    tmppic.SizeMode = PictureBoxSizeMode.Zoom;
                    pnPage.Controls.Add(tmppic);
                    ImageCounter++;
                }
                else
                {
                    Label tmpLabel = new Label();
                    tmpLabel.Font = new Font("Impact", 10, FontStyle.Regular);
                    tmpLabel.Width = pnPage.Width;
                    tmpLabel.TextAlign = ContentAlignment.MiddleLeft;
                    tmpLabel.MaximumSize = new Size(pnPage.Width, 0);
                    tmpLabel.AutoSize = true;
                    tmpLabel.Text = dat01.Rows[ContentCounter]["PageContent"].ToString();
                    pnPage.Controls.Add(tmpLabel);
                    ContentCounter++;
                }
            }
        }
    }
}
