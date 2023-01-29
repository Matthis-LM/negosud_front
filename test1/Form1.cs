namespace test1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            panel1.Size = new Size(200, 608);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 200)
            {
                panel1.Size = new Size(60, 608);
            }
            else
            { panel1.Size = new Size(200, 608); }
        }
    }
}