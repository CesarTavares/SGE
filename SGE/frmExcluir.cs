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
    public partial class frmExcluir : Form
    {
        MySqlConnection mConn = new MySqlConnection(
                "Persist Security Info = False;" +                
                "server = localhost;" +
                "database = sistema_gerenciador_escolar;" +
                "uid = root;" +
                "pwd ="                
            );

        int idSelecionado;

        public frmExcluir(int ID)
        {
            InitializeComponent();
            idSelecionado = ID;

            try
            {
                // abrir uma conexão com banco
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand comandoSQL = mConn.CreateCommand();

                    comandoSQL.CommandText = "SELECT * FROM tb_alunos WHERE id_aluno =" + ID;
                    comandoSQL.Connection = mConn;

                    MySqlDataReader linha = comandoSQL.ExecuteReader();

                    // lendo a linha de retorno/pesquisa
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
                    "Erro detectado, entre em contato com Dev.\n\n" + Erro.Message,
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Deseja realmente excluir o Registro?",
                    "Informação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    mConn.Open();
                    if (mConn.State == ConnectionState.Open)
                    {
                        MySqlCommand comandoSQL = mConn.CreateCommand();

                        comandoSQL.CommandText = "DELETE FROM tb_alunos WHERE id_aluno=" + idSelecionado;
                        comandoSQL.Connection = mConn;
                        comandoSQL.ExecuteNonQuery();

                        mConn.Close();

                        MessageBox.Show(
                        "Registro excluído com sucesso!",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        this.Close();

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
            else
            {
                MessageBox.Show("O processo de Exclusão foi cancelado.");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
    }
}
