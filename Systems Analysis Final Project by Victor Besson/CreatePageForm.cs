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
    public partial class CreatePageForm : Form
    {
        public CreatePageForm()
        {
            InitializeComponent();
        }
        List<Image> PreviewImages = new List<Image>();
        List<string> PreviewContent = new List<string>();
        List<bool> ImageorContent = new List<bool>();
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (pbImage.Image != null && (PreviewImages.Count < 6))
                {
                    Bitmap tmpImage = new Bitmap(pbImage.Image);
                    PreviewImages.Add(tmpImage);
                    ImageorContent.Add(false);
                    PictureBox tmppic = new PictureBox();
                    tmppic.Image = tmpImage;
                    tmppic.Width = pbImage.Width;
                    tmppic.Height = pbImage.Height;
                    tmppic.SizeMode = PictureBoxSizeMode.Zoom;
                    pnPreview.Controls.Add(tmppic);
                    lblError.Text = "";
                }
                else if (PreviewImages.Count == 5)
                    throw new Exception("Max Image Count is 5");
                else if (pbImage.Image == null)
                    throw new Exception("Must Choose Image");
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnAddContent_Click(object sender, EventArgs e)
        {
            string tmpContent = rtxtContent.Text;
            Label tmpLabel = new Label();
            tmpLabel.MaximumSize = new Size(pnPreview.Width, 0);
            tmpLabel.AutoSize = true;
            tmpLabel.Text = tmpContent;
            tmpLabel.Font = new Font("Impact", 8, FontStyle.Regular);
            PreviewContent.Add(tmpContent);
            ImageorContent.Add(true);
            pnPreview.Controls.Add(tmpLabel);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            db tmpdb = new db();
            try
            {
                if (MainForm.currentUser != null)
                {
                    if (txtTitle.Text.Length > 60)
                        throw new Exception("Max title length is 60");
                    else if (rtxtDescription.Text.Length > 255)
                        throw new Exception("Max description length is 255");
                    else if (txtTitle.Text.Trim() == "")
                        throw new Exception("Post Must Have Title");
                    else
                        lblError.Text = "";
                    int PageID = (tmpdb.CreatePage(MainForm.currentUser.UserID, txtTitle.Text, rtxtDescription.Text));
                    int contentnum = 0;
                    int imagenum = 0;
                    for (int i = 0; i < ImageorContent.Count; i++)
                    {
                        if (ImageorContent[i])
                        {
                            tmpdb.CreatePageContent(PageID.ToString(), PreviewContent[contentnum], i.ToString());
                            contentnum++;
                        }
                        else
                        {
                            tmpdb.CreatePageImage(PageID.ToString(), PreviewImages[imagenum], i.ToString());
                            imagenum++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No User Currently Logged In");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All Files| *.*| Image Files | *.jpg; *.gif; *.png; *.bmp";
            fd.FilterIndex = 2;
            DialogResult check = fd.ShowDialog();
            if (check is DialogResult.OK)
            {
                pbImage.Image = new Bitmap(fd.FileName);
            }
        }
    }
}
