using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace SGE
{
    public partial class frmLogin : Form
    {
        MySqlConnection mConn = new MySqlConnection(
               "Persist Security Info = False;" +
               "server = localhost;" +
               "database = sistema_gerenciador_escolar;" +
               "uid = root;" +
               "pwd ="
           );
        bool senhaOK = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        static string ComputeSha256Hash(string Senha)
        {
            // Criando um HASH com o método SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Computando o HASH - retornando um vetor de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(Senha));

                // Convert o array de bytes em uma string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string senhaBanco, senhaCripto;

            try
            {
                // abrir uma conexão com banco
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand comandoSQL = mConn.CreateCommand();

                    comandoSQL.CommandText = "SELECT * FROM usuariologin WHERE usuarioLogin ='" + txtUsuario.Text + "'";
                    comandoSQL.Connection = mConn;

                    MySqlDataReader linha = comandoSQL.ExecuteReader();

                    // lendo a linha de retorno/pesquisa
                    linha.Read();

                    //Pega a senha do banco e coloca nessa variável
                    senhaBanco = linha["senhaLogin"].ToString();

                    mConn.Close();

                    senhaCripto = ComputeSha256Hash(txtSenha.Text);

                    if (senhaBanco.CompareTo(senhaCripto) == 0) // zero indica que são iguais
                    {
                        senhaOK = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!");
                        txtUsuario.Clear();
                        txtSenha.Clear();
                        txtUsuario.Focus();
                    }
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(
                    "Erro detectado, entre em contato com Dev.\n\n" + Erro.Message,
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (senhaOK)
            {
                this.Hide();

                frmMenu frmPrincipal = new frmMenu();
                frmPrincipal.ShowDialog();
            }
        }
    }
}
