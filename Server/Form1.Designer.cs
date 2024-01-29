namespace Server
{
    partial class Form1
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
            this.TbNotification = new System.Windows.Forms.TextBox();
            this.LbIntro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbNotification
            // 
            this.TbNotification.Location = new System.Drawing.Point(15, 37);
            this.TbNotification.Multiline = true;
            this.TbNotification.Name = "TbNotification";
            this.TbNotification.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbNotification.Size = new System.Drawing.Size(561, 190);
            this.TbNotification.TabIndex = 0;
            // 
            // LbIntro
            // 
            this.LbIntro.AutoSize = true;
            this.LbIntro.Location = new System.Drawing.Point(12, 9);
            this.LbIntro.Name = "LbIntro";
            this.LbIntro.Size = new System.Drawing.Size(231, 13);
            this.LbIntro.TabIndex = 1;
            this.LbIntro.Text = "This server listens on port 8899 to receive data.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 241);
            this.Controls.Add(this.LbIntro);
            this.Controls.Add(this.TbNotification);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbNotification;
        private System.Windows.Forms.Label LbIntro;
    }
}

