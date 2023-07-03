namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Button_click é event handle, ele da por para executar tal evento
        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox Classe
            //Show método
            MessageBox.Show("OK", "Title", MessageBoxButtons.OK);
        }
    }
}
