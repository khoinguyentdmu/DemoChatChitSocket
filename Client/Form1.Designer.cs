namespace Client
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
            this.TbMessage = new System.Windows.Forms.TextBox();
            this.BtSend = new System.Windows.Forms.Button();
            this.TbNotification = new System.Windows.Forms.TextBox();
            this.LbIntro = new System.Windows.Forms.Label();
            this.LbMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbMessage
            // 
            this.TbMessage.Location = new System.Drawing.Point(181, 205);
            this.TbMessage.Name = "TbMessage";
            this.TbMessage.Size = new System.Drawing.Size(317, 20);
            this.TbMessage.TabIndex = 0;
            this.TbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbMessage_KeyDown);
            // 
            // BtSend
            // 
            this.BtSend.Location = new System.Drawing.Point(504, 203);
            this.BtSend.Name = "BtSend";
            this.BtSend.Size = new System.Drawing.Size(85, 23);
            this.BtSend.TabIndex = 1;
            this.BtSend.Text = "Send";
            this.BtSend.UseVisualStyleBackColor = true;
            this.BtSend.Click += new System.EventHandler(this.BtSend_Click);
            // 
            // TbNotification
            // 
            this.TbNotification.Location = new System.Drawing.Point(26, 44);
            this.TbNotification.Multiline = true;
            this.TbNotification.Name = "TbNotification";
            this.TbNotification.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbNotification.Size = new System.Drawing.Size(561, 139);
            this.TbNotification.TabIndex = 2;
            // 
            // LbIntro
            // 
            this.LbIntro.AutoSize = true;
            this.LbIntro.Location = new System.Drawing.Point(23, 18);
            this.LbIntro.Name = "LbIntro";
            this.LbIntro.Size = new System.Drawing.Size(172, 13);
            this.LbIntro.TabIndex = 3;
            this.LbIntro.Text = "This client sends data to the server";
            // 
            // LbMessage
            // 
            this.LbMessage.AutoSize = true;
            this.LbMessage.Location = new System.Drawing.Point(25, 208);
            this.LbMessage.Name = "LbMessage";
            this.LbMessage.Size = new System.Drawing.Size(150, 13);
            this.LbMessage.TabIndex = 4;
            this.LbMessage.Text = "Message to send to the server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 243);
            this.Controls.Add(this.LbMessage);
            this.Controls.Add(this.LbIntro);
            this.Controls.Add(this.TbNotification);
            this.Controls.Add(this.BtSend);
            this.Controls.Add(this.TbMessage);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbMessage;
        private System.Windows.Forms.Button BtSend;
        private System.Windows.Forms.TextBox TbNotification;
        private System.Windows.Forms.Label LbIntro;
        private System.Windows.Forms.Label LbMessage;
    }
}

