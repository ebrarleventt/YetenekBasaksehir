namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni bir mesaj eklendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string test = "yeni bir degisken";
            if (string.IsNullOrEmpty(test))
            {
                MessageBox.Show("Deger yok");
            }
        }
    }
}
