namespace Lab2
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
            txtReceivedMessages = new RichTextBox();
            label1 = new Label();
            txtPort = new TextBox();
            label2 = new Label();
            btnListen = new Button();
            SuspendLayout();
            // 
            // txtReceivedMessages
            // 
            txtReceivedMessages.Location = new Point(12, 127);
            txtReceivedMessages.Name = "txtReceivedMessages";
            txtReceivedMessages.Size = new Size(505, 147);
            txtReceivedMessages.TabIndex = 1;
            txtReceivedMessages.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 2;
            label1.Text = "Port";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(53, 43);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(96, 27);
            txtPort.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 4;
            label2.Text = "Received messages";
            // 
            // btnListen
            // 
            btnListen.Location = new Point(423, 43);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(94, 29);
            btnListen.TabIndex = 5;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 286);
            Controls.Add(btnListen);
            Controls.Add(label2);
            Controls.Add(txtPort);
            Controls.Add(label1);
            Controls.Add(txtReceivedMessages);
            Name = "Form1";
            Text = "UDP Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListen;
        private RichTextBox txtReceivedMessages;
        private Label label1;
        private TextBox txtPort;
        private Label label2;
    }
}