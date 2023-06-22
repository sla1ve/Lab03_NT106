namespace Lab2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Form1 newform1 = new Form1();
            newform1.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Form2 newform2 = new Form2();
            newform2.Show();
        }
    }
}