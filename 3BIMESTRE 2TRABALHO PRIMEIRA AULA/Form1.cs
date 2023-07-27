using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using _3BIMESTRE_2TRABALHO_PRIMEIRA_AULA;

namespace _3BIMESTRE_2TRABALHO_PRIMEIRA_AULA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lb_resposta.Text = "";
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {

            DateTime dataNasc = dtp_calendario.Value;

            int idade = Calculo.Calculo2(dataNasc);

            lb_resposta.Text = $"Idade: {idade} anos";


        }

    }

   
}
