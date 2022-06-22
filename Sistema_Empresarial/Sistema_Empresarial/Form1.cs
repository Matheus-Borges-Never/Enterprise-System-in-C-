using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_Empresarial
{
    public partial class Form1 : Form
    {
        //Referencia para conexão
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-SC2GFN8;
            Initial Catalog=sistema;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
            txtEmpresa.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Botão Acessar
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            conexao.Open(); //Abri conexão com o BD
            SqlCommand cm;
            string query = "select * from empresa where nome = '" + txtEmpresa.Text + "' and senha = '" + txtSenha.Text + "' ";
            cm = new SqlCommand(query, conexao);
            SqlDataAdapter da = new SqlDataAdapter();
            cm.ExecuteNonQuery();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                FormFuncionario principal = new FormFuncionario(); //Chama  tela exclusiva da empresa
                this.Hide();
                principal.Show();
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormEmpresa empresa = new FormEmpresa(); //Chama  tela de cadastro de empresa
            this.Hide();
            empresa.Show();
        }
    }
}
