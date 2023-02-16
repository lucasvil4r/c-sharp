namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelSobrenome_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            String sNome = textBoxNome.Text;
            String sSobreNome = textBoxSobreNome.Text;

            DateTime dDataMatricula = dateTime.Value;

            bool bPeriodoManha = RadioManha.Checked;
            bool bPeriodoTarde = RadioTarde.Checked;
            bool bPeriodoNoite = RadioNoite.Checked;

            MessageBox.Show("Nome: " + sNome + sSobreNome);
            MessageBox.Show("Data Matricula: " + dDataMatricula);
            MessageBox.Show("Periodo: " + bPeriodoManha);
        }
    }
}
