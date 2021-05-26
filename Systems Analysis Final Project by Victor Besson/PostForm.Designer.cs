namespace Systems_Analysis_Final_Project_by_Victor_Besson
{
    partial class PostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostForm));
            this.pnPost = new System.Windows.Forms.FlowLayoutPanel();
            this.pnComments = new System.Windows.Forms.FlowLayoutPanel();
            this.rtxtComment = new System.Windows.Forms.RichTextBox();
            this.btnComment = new System.Windows.Forms.Button();
            this.lblComments = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPost
            // 
            this.pnPost.AutoScroll = true;
            this.pnPost.BackColor = System.Drawing.Color.White;
            this.pnPost.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnPost.Location = new System.Drawing.Point(12, 0);
            this.pnPost.Name = "pnPost";
            this.pnPost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnPost.Size = new System.Drawing.Size(559, 354);
            this.pnPost.TabIndex = 0;
            this.pnPost.WrapContents = false;
            // 
            // pnComments
            // 
            this.pnComments.AutoScroll = true;
            this.pnComments.BackColor = System.Drawing.Color.White;
            this.pnComments.ForeColor = System.Drawing.Color.Black;
            this.pnComments.Location = new System.Drawing.Point(12, 394);
            this.pnComments.Name = "pnComments";
            this.pnComments.Size = new System.Drawing.Size(559, 248);
            this.pnComments.TabIndex = 0;
            // 
            // rtxtComment
            // 
            this.rtxtComment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtComment.ForeColor = System.Drawing.Color.DimGray;
            this.rtxtComment.Location = new System.Drawing.Point(12, 659);
            this.rtxtComment.Name = "rtxtComment";
            this.rtxtComment.Size = new System.Drawing.Size(559, 80);
            this.rtxtComment.TabIndex = 1;
            this.rtxtComment.Text = "Add a comment";
            this.rtxtComment.Visible = false;
            this.rtxtComment.Enter += new System.EventHandler(this.rtxtComment_Enter);
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComment.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.Location = new System.Drawing.Point(450, 745);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(121, 45);
            this.btnComment.TabIndex = 0;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = false;
            this.btnComment.Visible = false;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.BackColor = System.Drawing.Color.Black;
            this.lblComments.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.ForeColor = System.Drawing.Color.White;
            this.lblComments.Location = new System.Drawing.Point(232, 365);
            this.lblComments.MaximumSize = new System.Drawing.Size(103, 26);
            this.lblComments.MinimumSize = new System.Drawing.Size(103, 26);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(103, 26);
            this.lblComments.TabIndex = 2;
            this.lblComments.Text = "Comments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Posts";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(583, 802);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.rtxtComment);
            this.Controls.Add(this.pnComments);
            this.Controls.Add(this.pnPost);
            this.Name = "PostForm";
            this.Text = "PostForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnPost;
        private System.Windows.Forms.FlowLayoutPanel pnComments;
        private System.Windows.Forms.RichTextBox rtxtComment;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}