namespace Lab3._2
{
    partial class Form3
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
            txtMessages = new RichTextBox();
            btnConnect = new Button();
            btnSend = new Button();
            btnDisconnect = new Button();
            SuspendLayout();
            // 
            // txtMessages
            // 
            txtMessages.Location = new Point(12, 83);
            txtMessages.Name = "txtMessages";
            txtMessages.Size = new Size(599, 324);
            txtMessages.TabIndex = 4;
            txtMessages.Text = "";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(26, 27);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(261, 27);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(517, 27);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(94, 29);
            btnDisconnect.TabIndex = 7;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 419);
            Controls.Add(btnDisconnect);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Controls.Add(txtMessages);
            Name = "Form3";
            Text = "TCP Client";
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox txtMessages;
        private Button btnConnect;
        private Button btnSend;
        private Button btnDisconnect;
    }
}