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
            conexao.Open(); //Abri conexão com o BD
            SqlCommand cm;
            string query = "insert into empresa values('" + txtEmpresa.Text + "','" + txtSenha.Text + "','" + txtEndereco.Text + "','" + txtComplemento.Text + "'," + txtCep.Text + ",'" + txtNumero.Text + "'," + mskTelefone.Text + ") ";
            cm = new SqlCommand(query, conexao);
            SqlDataAdapter da = new SqlDataAdapter();
            cm.ExecuteNonQuery();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Empresa Cadastrada!!!");
                txtEmpresa.Text = "";   //Limpa a textbox apos o erro
                txtSenha.PasswordChar = '*';    //Limpa a textbox apos o erro
                txtEmpresa.Select();    //Seleciona a textbox
                conexao.Close(); //Fecha conexao com o BD
            }
            else
            {
                MessageBox.Show("Usuario incorreto ou não existe!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmpresa.Text = "";   //Limpa a textbox apos o erro
                txtSenha.PasswordChar = '*';    //Limpa a textbox apos o erro
                txtEmpresa.Select();    //Seleciona a textbox

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
