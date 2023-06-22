namespace Lab3._3
{
    public partial class main : Form
    {
        private Button btnServer;
        private Button btnClient;

        public main()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            btnClient = new Button();
            btnServer = new Button();
            SuspendLayout();
            // 
            // btnClient
            // 
            btnClient.Location = new Point(152, 224);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(353, 101);
            btnClient.TabIndex = 1;
            btnClient.Text = "Open new TCP Client";
            btnClient.UseVisualStyleBackColor = true;
            // 
            // btnServer
            // 
            btnServer.Location = new Point(152, 64);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(353, 101);
            btnServer.TabIndex = 0;
            btnServer.Text = "Open TCP Server";
            btnServer.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            ClientSize = new Size(660, 375);
            Controls.Add(btnClient);
            Controls.Add(btnServer);
            Name = "main";
            Text = "Exercise 3";
            ResumeLayout(false);
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Form2 newform2 = new Form2();
            newform2.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Form3 newform3 = new Form3();
            newform3.Show();
        }
    }
}