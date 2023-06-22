namespace Lab3._3
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
            btnListen = new Button();
            listMessages = new ListView();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.Location = new Point(415, 34);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(171, 36);
            btnListen.TabIndex = 1;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 337);
            Controls.Add(listMessages);
            Controls.Add(btnListen);
            Name = "Form2";
            Text = "TCP Server";
            ResumeLayout(false);
        }

        #endregion
        private Button btnListen;
        private ListView listMessages;
    }
}