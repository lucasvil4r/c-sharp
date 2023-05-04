using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wcf = new WebRefWcf.Servico01Client();

            var produto = wcf.PromocaoDoDia();

            MessageBox.Show(produto.Nome + " " + produto.Preco.ToString("c"));
        }
    }
}
