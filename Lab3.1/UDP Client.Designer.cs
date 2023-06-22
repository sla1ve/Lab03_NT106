namespace Lab2
{
    partial class Form2
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
            btnSend = new Button();
            txtMessage = new RichTextBox();
            label1 = new Label();
            txtRemoteIP = new TextBox();
            txtPort = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(12, 400);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(105, 40);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 185);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(463, 187);
            txtMessage.TabIndex = 2;
            txtMessage.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 3;
            label1.Text = "IP Remote Host";
            // 
            // txtRemoteIP
            // 
            txtRemoteIP.Location = new Point(12, 83);
            txtRemoteIP.Name = "txtRemoteIP";
            txtRemoteIP.Size = new Size(167, 27);
            txtRemoteIP.TabIndex = 4;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(308, 83);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(85, 27);
            txtPort.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "Messages";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 45);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 7;
            label3.Text = "Port";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 454);
            Controls.Add(label3);
            Controls.Add(txtPort);
            Controls.Add(label2);
            Controls.Add(txtRemoteIP);
            Controls.Add(label1);
            Controls.Add(txtMessage);
            Controls.Add(btnSend);
            Name = "Form2";
            Text = "UDP Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private RichTextBox txtMessage;
        private Label label1;
        private TextBox txtRemoteIP;
        private TextBox txtPort;
        private Label label2;
        private Label label3;
    }
}