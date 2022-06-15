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
    public partial class frmDgvAluno : Form
    {
        MySqlConnection mConn = new MySqlConnection(
            "Persist Security Info = False;" +
            "server = localhost;" +
            "database = sistema_gerenciador_escolar;" +
            "uid = root;" +
            "pwd =");

        int idSelecionado = -1;

        public frmDgvAluno()
        {
            InitializeComponent();
        }
        private void frmDgvAluno_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroAluno frmCadAluno = new frmCadastroAluno();
            frmCadAluno.ShowDialog();

            btnRefresh.PerformClick();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                // abrindo um conexão com o Banco de Dados
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    // limpando o datagridview para novos dados
                    dgvAlunos.Rows.Clear();

                    // definindo o número de colunas do DGV
                    dgvAlunos.ColumnCount = 4;

                    // definindo a largura e o nome das colunas
                    dgvAlunos.Columns[0].Width = 50;
                    dgvAlunos.Columns[0].Name = "#";

                    dgvAlunos.Columns[1].Width = 400;
                    dgvAlunos.Columns[1].Name = "Nome";

                    dgvAlunos.Columns[2].Width = 300;
                    dgvAlunos.Columns[2].Name = "Email";


                    dgvAlunos.Columns[3].Width = 300;
                    dgvAlunos.Columns[3].Name = "CPF";

                    // variável que terá o comando SQL e a conexão a ser utilizada
                    MySqlCommand comandoSQL = mConn.CreateCommand();
                    // comando/query SQL que será executadtada pelo banco
                    comandoSQL.CommandText = "SELECT id_aluno, nome_aluno, email_aluno, cpf_aluno FROM tb_alunos";
                    // indica a conexão com o banco 
                    comandoSQL.Connection = mConn;
                    // dadosClientes recebe os dados da QUERY acima, os dados
                    // vem em formato de tabela linha = registros e colunas = Campos
                    MySqlDataReader dadosAlunos = comandoSQL.ExecuteReader();

                    string[] linha;

                    while (dadosAlunos.Read())
                    {
                        linha = new string[]
                        {
                            dadosAlunos["id_aluno"].ToString(),
                            dadosAlunos["nome_aluno"].ToString(),
                            dadosAlunos["email_aluno"].ToString(),
                            dadosAlunos["cpf_aluno"].ToString()
                        };
                        // adicionando os dados lidos no datagridview
                        dgvAlunos.Rows.Add(linha);
                    }

                }
                // Limpando a seleção do DataGridView
                dgvAlunos.ClearSelection();
                //fechando a conexão
                mConn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                    "Erro detectado, entre em contato com Dev.\n\n" + erro.Message,
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void dgvAlunos_MouseClick(object sender, MouseEventArgs e)
        {
            int linha = dgvAlunos.CurrentRow.Index;

            
            int coluna = 0;

            // a partir da linha e da coluna pega o valor da célula e converte
            // para inteiro e atribui para variável idSelecionado, que
            // que seja utilizado para atualizar o registro ou excluir.
            idSelecionado = Convert.ToInt32(dgvAlunos.Rows[linha].Cells[coluna].Value.ToString());

            //MessageBox.Show(idSelecionado.ToString());
        }

        private void btnAlterarAluno_Click(object sender, EventArgs e)
        {
            if (idSelecionado >= 0)
            {
                frmAlterarAluno frmCadAlterarAluno = new frmAlterarAluno(idSelecionado);

                frmCadAlterarAluno.ShowDialog();
                idSelecionado = -1;
                btnRefresh.PerformClick();
            }
            else
            {
                MessageBox.Show(
                    "Selecione um nome da lista.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idSelecionado >= 0)
            {
                frmExcluir frmExc = new frmExcluir(idSelecionado);

                frmExc.ShowDialog();
                idSelecionado = -1;
                btnRefresh.PerformClick();
            }
            else
            {
                MessageBox.Show(
                    "Selecione um cliente da lista",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}
