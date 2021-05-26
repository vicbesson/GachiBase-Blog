namespace Systems_Analysis_Final_Project_by_Victor_Besson
{
    partial class WhisperForm
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
            this.components = new System.ComponentModel.Container();
            this.pnWhispers = new System.Windows.Forms.FlowLayoutPanel();
            this.rtxtWhisper = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnWhispers
            // 
            this.pnWhispers.AutoScroll = true;
            this.pnWhispers.Location = new System.Drawing.Point(12, 12);
            this.pnWhispers.Name = "pnWhispers";
            this.pnWhispers.Size = new System.Drawing.Size(446, 513);
            this.pnWhispers.TabIndex = 0;
            // 
            // rtxtWhisper
            // 
            this.rtxtWhisper.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtWhisper.Location = new System.Drawing.Point(13, 532);
            this.rtxtWhisper.Name = "rtxtWhisper";
            this.rtxtWhisper.Size = new System.Drawing.Size(445, 82);
            this.rtxtWhisper.TabIndex = 1;
            this.rtxtWhisper.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(358, 622);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 42);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type \"/whisper name\" to whisper a user";
            // 
            // WhisperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(471, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtxtWhisper);
            this.Controls.Add(this.pnWhispers);
            this.MaximumSize = new System.Drawing.Size(487, 715);
            this.MinimumSize = new System.Drawing.Size(487, 715);
            this.Name = "WhisperForm";
            this.Text = "WhisperForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhisperForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnWhispers;
        private System.Windows.Forms.RichTextBox rtxtWhisper;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}