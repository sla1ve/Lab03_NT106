namespace Lab2
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnServer = new Button();
            btnClient = new Button();
            SuspendLayout();
            // 
            // btnServer
            // 
            btnServer.Location = new Point(133, 47);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(270, 97);
            btnServer.TabIndex = 0;
            btnServer.Text = "UDP Sever";
            btnServer.UseVisualStyleBackColor = true;
            // 
            // btnClient
            // 
            btnClient.Location = new Point(133, 217);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(270, 89);
            btnClient.TabIndex = 1;
            btnClient.Text = "UDP Client";
            btnClient.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 348);
            Controls.Add(btnClient);
            Controls.Add(btnServer);
            Name = "Main";
            Text = "Exercise 1";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnServer;
        private Button btnClient;
    }
}