namespace Lab3._2
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
            listMessages = new ListView();
            btnListen = new Button();
            SuspendLayout();
            // 
            // listMessages
            // 
            listMessages.Location = new Point(12, 83);
            listMessages.Name = "listMessages";
            listMessages.Size = new Size(574, 242);
            listMessages.TabIndex = 2;
            listMessages.UseCompatibleStateImageBehavior = false;
            listMessages.View = View.List;
            // 
            // btnListen
            // 
            btnListen.Location = new Point(444, 34);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(142, 29);
            btnListen.TabIndex = 3;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 337);
            Controls.Add(btnListen);
            Controls.Add(listMessages);
            Name = "Form2";
            Text = "TCP Server";
            ResumeLayout(false);
        }

        #endregion
        private ListView listMessages;
        private Button btnListen;
    }
}