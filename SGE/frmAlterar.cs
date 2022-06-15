using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGE
{
    public partial class frmAlterarAluno : Form
    {
        MySqlConnection mConn = new MySqlConnection(
            "Persist Security Info = False; " +
            "server = localhost;" +
            "database = sistema_gerenciador_escolar;" +
            "uid = root;" +
            "pwd ="
            );

        int idSelecionado;       

        public frmAlterarAluno(int ID)
        {
            InitializeComponent();

            idSelecionado = ID;

            try
            {
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand comandoSQL = mConn.CreateCommand();

                    comandoSQL.CommandText = "SELECT * FROM tb_alunos WHERE id_aluno ="+ID;
                    comandoSQL.Connection = mConn;

                    MySqlDataReader linha = comandoSQL.ExecuteReader();

                    linha.Read();

                    txtNome.Text = linha["nome_aluno"].ToString();
                    txtEndereco.Text = linha["endereco_aluno"].ToString();
                    txtComplemento.Text = linha["complemento_aluno"].ToString();
                    txtBairro.Text = linha["bairro_aluno"].ToString();
                    mtbCEP.Text = linha["cep_aluno"].ToString();
                    txtCidade.Text = linha["cidade_aluno"].ToString();
                    cmbUF.Text = linha["uf_aluno"].ToString();
                    txtEmail.Text = linha["email_aluno"].ToString();
                    mtbDataNasc.Text = linha["datanasc_aluno"].ToString();
                    mtbCPF.Text = linha["cpf_aluno"].ToString();
                    mtbRG.Text = linha["rg_aluno"].ToString();
                    txtTituloEleitor.Text = linha["tituloEleitor_aluno"].ToString();
                    cmbSexo.Text = linha["sexo_aluno"].ToString();
                    txtNomePai.Text = linha["nomePai_aluno"].ToString();
                    txtNomeMae.Text = linha["nomeMae_aluno"].ToString();
                    //pbFoto = linha["foto_aluno"];

                    mConn.Close();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(
                "Erro detectado, entre em contato com o DEV. \n\n" + Erro.Message,
                "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);                
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }    

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand comandoSQL = mConn.CreateCommand();

                    comandoSQL.CommandText = "UPDATE tb_alunos SET nome_aluno='" + txtNome.Text +
                        "', endereco_aluno='" + txtEndereco.Text +
                        "', complemento_aluno='" + txtComplemento.Text +
                        "', bairro_aluno='" + txtBairro.Text +
                        "', cep_aluno='" + mtbCEP.Text +
                        "', cidade_aluno'" + txtCidade.Text +
                        "', uf_aluno'" + cmbUF.Text +
                        "', email_aluno'" + txtEmail.Text +
                        "', datanasc_aluno'" + mtbDataNasc.Text +
                        "', cpf_aluno'" + mtbCPF.Text +
                        "', rg_aluno'" + mtbRG.Text +
                        "', tituloEleitor_aluno'" + txtTituloEleitor.Text +
                        "', sexo_aluno'" + cmbSexo.Text +
                        "', nomePai_aluno'" + txtNomePai.Text +
                        "', nomeMae_aluno'" + txtNomeMae.Text + "' WHERE id_aluno=" + idSelecionado;

                    comandoSQL.Connection = mConn;
                    comandoSQL.ExecuteNonQuery();

                    mConn.Close();

                    MessageBox.Show(
                    "A atualização feita com sucesso!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    this.Close();
                }

            }
            catch (Exception Erro)
            {
                MessageBox.Show(
                   "Erro detectado, entre em contato com o Dev. \n\n" + Erro.Message,
                   "Informação",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);                
            }
        }
    }
}
