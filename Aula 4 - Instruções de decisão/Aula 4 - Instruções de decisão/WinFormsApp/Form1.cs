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
            DayOfWeek dDayOfWeek;

            dDayOfWeek = DateTime.Now.DayOfWeek;

            switch (dDayOfWeek)
            {
                case dDayOfWeek.Sunday:
                    sMensagem = "Hoje é domingo";
                    break;
                case dDayOfWeek.Friday:
                    sMensagem = "Hoje é Sexta-Feira";
                    break;
                case dDayOfWeek.Monday:
                    sMensagem = "Hoje é Segunda-Feira";
                    break;
                default:
                    sMensagem = "Tenha um bom dia";
                    break;
            }

            if ( DateTime.Now.Hour > 17 )
            {
                sMensagem = "Boa noite";
            } 

            else if ( DateTime.Now.Minute > 13 )
            {
                sMensagem = "Bom tarde"; 
            } 

            else
            {
                sMensagem = "Bom dia";
            }
        }
    }
}
