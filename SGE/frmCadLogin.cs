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
    public partial class frmCadLogin : Form
    {
        MySqlConnection mConn = new MySqlConnection(
               "Persist Security Info = False;" +
               "server = localhost;" +
               "database = sistema_gerenciador_escolar;" +
               "uid = root;" +
               "pwd ="
           );

        public frmCadLogin()
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
                    // o ToString("x2") é usado para formatar os bytes de dois em dois 0D
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand comandoSQL = new MySqlCommand();

                    comandoSQL.CommandText = "INSERT INTO usuariologin (usuarioLogin, senhaLogin, nivelLogin) VALUES " +
                                             "('" + txtUsuario.Text + "', '"
                                                  + ComputeSha256Hash(txtSenha.Text) + "', '"
                                                  + cmbNivel.Text + "')";

                    comandoSQL.Connection = mConn;

                    comandoSQL.ExecuteNonQuery();

                    MessageBox.Show(
                        "Registro salvo com sucesso!",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(
                    "Erro detectado, entre em contato com Dev.\n\n" + erro.Message,
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            mConn.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
