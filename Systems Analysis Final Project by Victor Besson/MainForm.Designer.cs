namespace Systems_Analysis_Final_Project_by_Victor_Besson
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnInfo = new System.Windows.Forms.Panel();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnCreate = new System.Windows.Forms.Panel();
            this.btnWhispers = new System.Windows.Forms.Button();
            this.btnUserList = new System.Windows.Forms.Button();
            this.btnAddPost = new System.Windows.Forms.Button();
            this.btnAddPage = new System.Windows.Forms.Button();
            this.pnPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnPages = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPostTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnCreate.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.Black;
            this.pnInfo.Controls.Add(this.pbAvatar);
            this.pnInfo.Controls.Add(this.lblCurrentUser);
            this.pnInfo.Controls.Add(this.btnLogOut);
            this.pnInfo.Controls.Add(this.btnLogin);
            this.pnInfo.Controls.Add(this.btnRegister);
            this.pnInfo.Location = new System.Drawing.Point(705, -3);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(391, 92);
            this.pnInfo.TabIndex = 0;
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAvatar.Location = new System.Drawing.Point(173, 10);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(65, 65);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 3;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Visible = false;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblCurrentUser.Location = new System.Drawing.Point(243, 23);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentUser.TabIndex = 8;
            this.lblCurrentUser.Visible = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(244, 48);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(83, 31);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Visible = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(192, 15);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 41);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(293, 15);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(86, 41);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Sign Up";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.Black;
            this.pnLogo.Controls.Add(this.pbLogo);
            this.pnLogo.Location = new System.Drawing.Point(-1, -3);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(708, 92);
            this.pnLogo.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(7, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(545, 92);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnCreate
            // 
            this.pnCreate.BackColor = System.Drawing.Color.Violet;
            this.pnCreate.Controls.Add(this.btnWhispers);
            this.pnCreate.Controls.Add(this.btnUserList);
            this.pnCreate.Controls.Add(this.btnAddPost);
            this.pnCreate.Controls.Add(this.btnAddPage);
            this.pnCreate.Location = new System.Drawing.Point(1, 655);
            this.pnCreate.Name = "pnCreate";
            this.pnCreate.Size = new System.Drawing.Size(696, 68);
            this.pnCreate.TabIndex = 1;
            // 
            // btnWhispers
            // 
            this.btnWhispers.BackColor = System.Drawing.Color.MediumPurple;
            this.btnWhispers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhispers.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhispers.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnWhispers.Location = new System.Drawing.Point(169, 20);
            this.btnWhispers.Name = "btnWhispers";
            this.btnWhispers.Size = new System.Drawing.Size(142, 36);
            this.btnWhispers.TabIndex = 3;
            this.btnWhispers.Text = "Show Whispers";
            this.btnWhispers.UseVisualStyleBackColor = false;
            this.btnWhispers.Visible = false;
            this.btnWhispers.Click += new System.EventHandler(this.btnWhispers_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserList.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserList.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnUserList.Location = new System.Drawing.Point(11, 20);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(142, 36);
            this.btnUserList.TabIndex = 0;
            this.btnUserList.Text = "Show List Of Users";
            this.btnUserList.UseVisualStyleBackColor = false;
            this.btnUserList.Visible = false;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // btnAddPost
            // 
            this.btnAddPost.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAddPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPost.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPost.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAddPost.Location = new System.Drawing.Point(572, 20);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(107, 36);
            this.btnAddPost.TabIndex = 2;
            this.btnAddPost.Text = "Create Post";
            this.btnAddPost.UseVisualStyleBackColor = false;
            this.btnAddPost.Visible = false;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // btnAddPage
            // 
            this.btnAddPage.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAddPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPage.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPage.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAddPage.Location = new System.Drawing.Point(443, 20);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(107, 36);
            this.btnAddPage.TabIndex = 1;
            this.btnAddPage.Text = "Create Page";
            this.btnAddPage.UseVisualStyleBackColor = false;
            this.btnAddPage.Visible = false;
            this.btnAddPage.Click += new System.EventHandler(this.btnAddPage_Click);
            // 
            // pnPosts
            // 
            this.pnPosts.AutoScroll = true;
            this.pnPosts.BackColor = System.Drawing.Color.Violet;
            this.pnPosts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnPosts.Location = new System.Drawing.Point(1, 151);
            this.pnPosts.Name = "pnPosts";
            this.pnPosts.Size = new System.Drawing.Size(696, 505);
            this.pnPosts.TabIndex = 0;
            this.pnPosts.WrapContents = false;
            // 
            // pnPages
            // 
            this.pnPages.BackColor = System.Drawing.Color.Salmon;
            this.pnPages.Location = new System.Drawing.Point(703, 151);
            this.pnPages.Name = "pnPages";
            this.pnPages.Size = new System.Drawing.Size(390, 572);
            this.pnPages.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblPostTitle);
            this.panel1.Location = new System.Drawing.Point(1, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 63);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(652, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Posts";
            this.pictureBox1.Click += new System.EventHandler(this.reload_Click);
            // 
            // lblPostTitle
            // 
            this.lblPostTitle.AutoSize = true;
            this.lblPostTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostTitle.ForeColor = System.Drawing.Color.White;
            this.lblPostTitle.Location = new System.Drawing.Point(284, 12);
            this.lblPostTitle.Name = "lblPostTitle";
            this.lblPostTitle.Size = new System.Drawing.Size(89, 39);
            this.lblPostTitle.TabIndex = 0;
            this.lblPostTitle.Text = "Posts";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblPageTitle);
            this.panel2.Location = new System.Drawing.Point(703, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 63);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(346, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Pages";
            this.pictureBox2.Click += new System.EventHandler(this.reload_Click);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(155, 12);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(97, 39);
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "Pages";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1096, 723);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnPages);
            this.Controls.Add(this.pnPosts);
            this.Controls.Add(this.pnCreate);
            this.Controls.Add(this.pnLogo);
            this.Controls.Add(this.pnInfo);
            this.MaximumSize = new System.Drawing.Size(1112, 762);
            this.MinimumSize = new System.Drawing.Size(1112, 762);
            this.Name = "MainForm";
            this.Text = "Main Page";
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnCreate.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Panel pnCreate;
        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.Button btnAddPage;
        private System.Windows.Forms.Button btnUserList;
        private System.Windows.Forms.FlowLayoutPanel pnPosts;
        private System.Windows.Forms.FlowLayoutPanel pnPages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPostTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Button btnWhispers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

