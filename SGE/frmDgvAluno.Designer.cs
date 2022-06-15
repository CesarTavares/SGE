
namespace SGE
{
    partial class frmDgvAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ptbLoogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterarAluno = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(215, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(711, 70);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "Sistema de Gerenciamento Escolar";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbLoogo
            // 
            this.ptbLoogo.Image = global::SGE.Properties.Resources.LogoSGE;
            this.ptbLoogo.Location = new System.Drawing.Point(3, 10);
            this.ptbLoogo.Name = "ptbLoogo";
            this.ptbLoogo.Size = new System.Drawing.Size(183, 70);
            this.ptbLoogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLoogo.TabIndex = 43;
            this.ptbLoogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1064, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "SGE- V1.0 - Programadores S/A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(22, 20);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(161, 44);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterarAluno
            // 
            this.btnAlterarAluno.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarAluno.Location = new System.Drawing.Point(220, 20);
            this.btnAlterarAluno.Name = "btnAlterarAluno";
            this.btnAlterarAluno.Size = new System.Drawing.Size(157, 44);
            this.btnAlterarAluno.TabIndex = 1;
            this.btnAlterarAluno.Text = "Atualizar";
            this.btnAlterarAluno.UseVisualStyleBackColor = true;
            this.btnAlterarAluno.Click += new System.EventHandler(this.btnAlterarAluno_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(420, 20);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(157, 44);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(629, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(157, 44);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(865, 20);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(157, 44);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnAlterarAluno);
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Location = new System.Drawing.Point(12, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 84);
            this.panel2.TabIndex = 45;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(12, 185);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(1040, 351);
            this.dgvAlunos.TabIndex = 46;
            this.dgvAlunos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAlunos_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmDgvAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbLoogo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDgvAluno";
            this.Text = "frmDgvAluno";
            this.Load += new System.EventHandler(this.frmDgvAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoogo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ptbLoogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterarAluno;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}