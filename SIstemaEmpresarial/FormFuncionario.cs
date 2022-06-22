using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SIstemaEmpresarial
{
    public partial class FormFuncionario : Form
    {
        //Referencia para conexão
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-SC2GFN8;
            Initial Catalog=sistema;Integrated Security=True");
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 index = new Form1(); //Chama  tela de cadastro de empresa
            this.Hide();
            index.Show();

        }
    }
}
