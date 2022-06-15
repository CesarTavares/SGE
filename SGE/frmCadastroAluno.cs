using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace SGE
{
    public partial class frmCadastroAluno : Form
    {
        MySqlConnection mConn = new MySqlConnection(
            "Persist Security Info = False;" +
            "server = localhost;" +
            "database = sistema_gerenciador_escolar;" +
            "uid = root;" +
            "pwd ="
            );

        public frmCadastroAluno()
        {
            InitializeComponent();
        }        

        private void btnFoto_Click(object sender, EventArgs e)
        {
            string origemcompleto = "";
            string foto = "";
            string pastaDestino = "";
            string destinoCompleto = "";
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                //REtorna o caminho do arquivo
                origemcompleto = openFileDialog1.FileName;
                //retorna nome do arquivo
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja subistituir?","Subistituir", MessageBoxButtons.YesNo)==DialogResult.No)
                {
                    return;
                }

                System.IO.File.Copy(origemcompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pbFoto.ImageLocation = destinoCompleto;
                }
                else
                {
                    MessageBox.Show("Arquivo não Copiado!");
                }
            }
        }

       
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravarAlunos_Click(object sender, EventArgs e)
        {
            try
            {
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand comandoSQL = new MySqlCommand();
                    comandoSQL.CommandText = "INSERT INTO tb_alunos (nome_aluno, endereco_aluno, complemento_aluno, bairro_aluno, cep_aluno, cidade_aluno," +
                        "uf_aluno, email_aluno, datanasc_aluno, cpf_aluno, rg_aluno, tituloEleitor_aluno, sexo_aluno, nomePai_aluno, nomeMae_aluno, foto_aluno) VALUES" +
                        "('" + txtNome.Text + "', '"
                            + txtEndereco.Text + "', '"
                            + txtComplemento.Text + "', '"
                            + txtBairro.Text + "', '"
                            + mtbCEP.Text + "', '"
                            + txtCidade.Text + "', '"
                            + cmbUF.Text + "', '"
                            + txtEmail + "', '"
                            + mtbDataNasc + "', '"
                            + mtbCPF.Text + "', '"
                            + mtbRG.Text + "', '"
                            + txtTituloEleitor + "', '"
                            + cmbSexo.Text + "', '"
                            + txtNomePai.Text + "', '"
                            + txtNomeMae.Text + "', '"
                            + pbFoto.Image + "')";

                    comandoSQL.Connection = mConn;
                    comandoSQL.ExecuteNonQuery();

                    txtNome.Clear();
                    txtEndereco.Clear();
                    txtComplemento.Clear();
                    txtBairro.Clear();
                    mtbCEP.Clear();
                    txtCidade.Clear();
                    cmbUF.Text = "";
                    txtEmail.Clear();
                    mtbDataNasc.Text = "";
                    mtbCPF.Text = "";
                    mtbRG.Text = "";
                    txtTituloEleitor.Clear();
                    cmbSexo.Text = "";
                    txtNomePai.Clear();
                    txtNomeMae.Clear();

                    MessageBox.Show(
                        "Registro Salvo com Sucesso!",
                        "Informção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtNome.Focus();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(
                    "Erro detectado, entre me contato com o Administrador do Programa." + Erro.Message,
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            mConn.Close();
        }       
    }
}
