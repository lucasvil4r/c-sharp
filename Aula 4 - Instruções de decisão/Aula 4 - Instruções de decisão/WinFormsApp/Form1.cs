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
            string sMensagem;
            DayOfWeek dDayOfWeek = DateTime.Now.DayOfWeek;

            switch (dDayOfWeek)
            {
                case DayOfWeek.Sunday:
                    sMensagem = "Hoje é domingo";
                    break;
                case DayOfWeek.Friday:
                    sMensagem = "Hoje é Sexta-Feira";
                    break;
                case DayOfWeek.Monday:
                    sMensagem = "Hoje é Segunda-Feira";
                    break;
                default:
                    sMensagem = "Tenha um bom dia";
                    break;
            }

            MessageBox.Show(sMensagem);

            if ( DateTime.Now.Hour > 17 )
            {
                sMensagem = "Boa noite";
            } 

            else if ( DateTime.Now.Minute > 13 )
            {
                sMensagem = "Boa tarde"; 
            } 

            else
            {
                sMensagem = "Bom dia";
            }

            MessageBox.Show(sMensagem);
        }
    }
}
