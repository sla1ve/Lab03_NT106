namespace Lab3._3
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
            btnSend = new Button();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(12, 21);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(305, 65);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send Message";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 98);
            Controls.Add(btnSend);
            Name = "Form3";
            Text = "TCP Client";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSend;
    }
}