namespace Systems_Analysis_Final_Project_by_Victor_Besson
{
    partial class PageForm
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
            this.pnPage = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnPage
            // 
            this.pnPage.AutoScroll = true;
            this.pnPage.BackColor = System.Drawing.Color.White;
            this.pnPage.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnPage.Location = new System.Drawing.Point(0, -1);
            this.pnPage.MaximumSize = new System.Drawing.Size(662, 802);
            this.pnPage.MinimumSize = new System.Drawing.Size(662, 802);
            this.pnPage.Name = "pnPage";
            this.pnPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnPage.Size = new System.Drawing.Size(662, 802);
            this.pnPage.TabIndex = 1;
            this.pnPage.WrapContents = false;
            // 
            // PageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 800);
            this.Controls.Add(this.pnPage);
            this.Name = "PageForm";
            this.Text = "PageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnPage;
    }
}