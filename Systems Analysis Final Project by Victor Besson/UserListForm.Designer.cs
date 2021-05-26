namespace Systems_Analysis_Final_Project_by_Victor_Besson
{
    partial class UserListForm
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
            this.pnUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnUsers
            // 
            this.pnUsers.AutoScroll = true;
            this.pnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnUsers.Location = new System.Drawing.Point(0, 0);
            this.pnUsers.Name = "pnUsers";
            this.pnUsers.Size = new System.Drawing.Size(404, 516);
            this.pnUsers.TabIndex = 0;
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 515);
            this.Controls.Add(this.pnUsers);
            this.MaximumSize = new System.Drawing.Size(419, 554);
            this.MinimumSize = new System.Drawing.Size(419, 554);
            this.Name = "UserListForm";
            this.Text = "UserListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnUsers;
    }
}