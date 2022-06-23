using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SIstemaEmpresarial
{
    public partial class FormEmpresa : Form
    {
        //Referencia para conexão
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-SC2GFN8;
            Initial Catalog=sistema;Integrated Security=True");
        public FormEmpresa()
        {
            InitializeComponent();
            txtEmpresa.Select();
        }

        private void Sistem_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
            if (conexao.State == ConnectionState.Open)
            {
                SqlCommand cm;
                string sql = "";
                sql = "insert into empresa values ('" + txtEmpresa.Text + "','" + txtSenha.Text + "','" + txtEndereco.Text + "','" + txtComplemento.Text + "'," + txtCep.Text + ",'" + txtNumero.Text + "'," + mtbTelefone.Text + ")";
                cm = new SqlCommand(sql, conexao);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (cm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("O Produto foi inserido com sucesso!");

                }
                else
                {
                    MessageBox.Show("Usuario já existe!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 index = new Form1(); //Chama  tela de cadastro de empresa
            this.Hide();
            index.Show();
        }
    }
}
