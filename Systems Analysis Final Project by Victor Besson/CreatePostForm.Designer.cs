namespace Systems_Analysis_Final_Project_by_Victor_Besson
{
    partial class CreatePostForm
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
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.pnPreview = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddContent = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtContent
            // 
            this.rtxtContent.AcceptsTab = true;
            this.rtxtContent.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtContent.Location = new System.Drawing.Point(9, 331);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(432, 140);
            this.rtxtContent.TabIndex = 1;
            this.rtxtContent.Text = "";
            // 
            // pnPreview
            // 
            this.pnPreview.AutoScroll = true;
            this.pnPreview.BackColor = System.Drawing.Color.White;
            this.pnPreview.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnPreview.Location = new System.Drawing.Point(9, 22);
            this.pnPreview.Name = "pnPreview";
            this.pnPreview.Size = new System.Drawing.Size(432, 233);
            this.pnPreview.TabIndex = 3;
            this.pnPreview.WrapContents = false;
            // 
            // btnAddContent
            // 
            this.btnAddContent.BackColor = System.Drawing.Color.Orchid;
            this.btnAddContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContent.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddContent.Location = new System.Drawing.Point(354, 477);
            this.btnAddContent.Name = "btnAddContent";
            this.btnAddContent.Size = new System.Drawing.Size(87, 34);
            this.btnAddContent.TabIndex = 3;
            this.btnAddContent.Text = "Add Content";
            this.btnAddContent.UseVisualStyleBackColor = false;
            this.btnAddContent.Click += new System.EventHandler(this.btnAddContent_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(9, 477);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(200, 200);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.Orchid;
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnChooseImage.Location = new System.Drawing.Point(9, 681);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(98, 34);
            this.btnChooseImage.TabIndex = 4;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.Orchid;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddImage.Location = new System.Drawing.Point(232, 477);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(98, 34);
            this.btnAddImage.TabIndex = 2;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Orchid;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnFinish.Location = new System.Drawing.Point(340, 673);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(98, 34);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(229, 566);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Purple;
            this.lblTitle.Location = new System.Drawing.Point(203, 258);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 20);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.ForeColor = System.Drawing.Color.Purple;
            this.lblPreview.Location = new System.Drawing.Point(176, -1);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(115, 20);
            this.lblPreview.TabIndex = 10;
            this.lblPreview.Text = "Preview Window";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.ForeColor = System.Drawing.Color.Purple;
            this.lblContent.Location = new System.Drawing.Point(193, 311);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(60, 20);
            this.lblContent.TabIndex = 11;
            this.lblContent.Text = "Content";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(9, 281);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(432, 27);
            this.txtTitle.TabIndex = 0;
            // 
            // CreatePostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(450, 719);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnAddContent);
            this.Controls.Add(this.pnPreview);
            this.Controls.Add(this.rtxtContent);
            this.Controls.Add(this.txtTitle);
            this.MaximumSize = new System.Drawing.Size(466, 758);
            this.MinimumSize = new System.Drawing.Size(466, 758);
            this.Name = "CreatePostForm";
            this.Text = "CreatePostForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.FlowLayoutPanel pnPreview;
        private System.Windows.Forms.Button btnAddContent;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtTitle;
    }
}