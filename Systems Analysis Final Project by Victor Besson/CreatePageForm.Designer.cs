namespace Systems_Analysis_Final_Project_by_Victor_Besson
{
    partial class CreatePageForm
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
            this.lblContent = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnAddContent = new System.Windows.Forms.Button();
            this.pnPreview = new System.Windows.Forms.FlowLayoutPanel();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.ForeColor = System.Drawing.Color.Lavender;
            this.lblContent.Location = new System.Drawing.Point(191, 397);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(60, 20);
            this.lblContent.TabIndex = 23;
            this.lblContent.Text = "Content";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.ForeColor = System.Drawing.Color.Lavender;
            this.lblPreview.Location = new System.Drawing.Point(170, 1);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(115, 20);
            this.lblPreview.TabIndex = 22;
            this.lblPreview.Text = "Preview Window";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Lavender;
            this.lblTitle.Location = new System.Drawing.Point(203, 260);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 20);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Title";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(217, 587);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 20;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Thistle;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(340, 675);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(98, 34);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.Thistle;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.Location = new System.Drawing.Point(351, 514);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(87, 34);
            this.btnAddImage.TabIndex = 4;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.Thistle;
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.Location = new System.Drawing.Point(9, 683);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(98, 34);
            this.btnChooseImage.TabIndex = 5;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(12, 514);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(170, 163);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 12;
            this.pbImage.TabStop = false;
            // 
            // btnAddContent
            // 
            this.btnAddContent.BackColor = System.Drawing.Color.Thistle;
            this.btnAddContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContent.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContent.Location = new System.Drawing.Point(246, 514);
            this.btnAddContent.Name = "btnAddContent";
            this.btnAddContent.Size = new System.Drawing.Size(87, 34);
            this.btnAddContent.TabIndex = 3;
            this.btnAddContent.Text = "Add Content";
            this.btnAddContent.UseVisualStyleBackColor = false;
            this.btnAddContent.Click += new System.EventHandler(this.btnAddContent_Click);
            // 
            // pnPreview
            // 
            this.pnPreview.AutoScroll = true;
            this.pnPreview.BackColor = System.Drawing.Color.White;
            this.pnPreview.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnPreview.Location = new System.Drawing.Point(9, 24);
            this.pnPreview.Name = "pnPreview";
            this.pnPreview.Size = new System.Drawing.Size(432, 233);
            this.pnPreview.TabIndex = 15;
            this.pnPreview.WrapContents = false;
            // 
            // rtxtContent
            // 
            this.rtxtContent.AcceptsTab = true;
            this.rtxtContent.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtContent.Location = new System.Drawing.Point(9, 420);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(432, 88);
            this.rtxtContent.TabIndex = 2;
            this.rtxtContent.Text = "";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(9, 283);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(432, 27);
            this.txtTitle.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Lavender;
            this.lblDescription.Location = new System.Drawing.Point(181, 317);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "Description";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.AcceptsTab = true;
            this.rtxtDescription.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(9, 343);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(432, 48);
            this.rtxtDescription.TabIndex = 1;
            this.rtxtDescription.Text = "";
            // 
            // CreatePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(450, 719);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.lblDescription);
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
            this.Name = "CreatePageForm";
            this.Text = "CreatePageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnAddContent;
        private System.Windows.Forms.FlowLayoutPanel pnPreview;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtxtDescription;
    }
}