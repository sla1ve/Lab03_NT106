namespace Lab3._2
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
            btnServer = new Button();
            btnClient = new Button();
            SuspendLayout();
            // 
            // btnServer
            // 
            btnServer.Location = new Point(133, 60);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(353, 101);
            btnServer.TabIndex = 0;
            btnServer.Text = "TCP Server";
            btnServer.UseVisualStyleBackColor = true;
            // 
            // btnClient
            // 
            btnClient.Location = new Point(133, 229);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(353, 101);
            btnClient.TabIndex = 1;
            btnClient.Text = "TCP Client";
            btnClient.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            ClientSize = new Size(624, 389);
            Controls.Add(btnClient);
            Controls.Add(btnServer);
            Name = "main";
            Text = "Exercise 2";
            ResumeLayout(false);
        }

        private void btnSercver(object sender, EventArgs e)
        {
            Form2 newform2 = new Form2();
            newform2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newform3 = new Form3();
            newform3.Show();
        }
    }
}