
namespace SGE
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbLoogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeDiciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeTurmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(215, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(711, 70);
            this.lblTitulo.TabIndex = 35;
            this.lblTitulo.Text = "Sistema de Gerenciamento Escolar";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1064, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "SGE- V1.0 - Programadores S/A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.btnCadastrarAluno);
            this.panel2.Location = new System.Drawing.Point(3, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 382);
            this.panel2.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(842, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 79);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastro de Turmas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 125);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSair.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(877, 338);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(157, 28);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(636, 175);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(157, 79);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Cadastro de Diciplinas";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(427, 175);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(157, 79);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Cadastros Cursos";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(220, 175);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(157, 79);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Cadastro de Professores";
            this.btnAlterar.UseVisualStyleBackColor = true; 
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAluno.Location = new System.Drawing.Point(22, 175);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(161, 79);
            this.btnCadastrarAluno.TabIndex = 0;
            this.btnCadastrarAluno.Text = "Cadastro de Alunos";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 40;
            this.label2.Text = "MENU";
            // 
            // ptbLoogo
            // 
            this.ptbLoogo.Image = global::SGE.Properties.Resources.LogoSGE;
            this.ptbLoogo.Location = new System.Drawing.Point(12, 37);
            this.ptbLoogo.Name = "ptbLoogo";
            this.ptbLoogo.Size = new System.Drawing.Size(183, 70);
            this.ptbLoogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLoogo.TabIndex = 36;
            this.ptbLoogo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAlunosToolStripMenuItem,
            this.cadastroDeProfessoresToolStripMenuItem,
            this.cadastroDeCursosToolStripMenuItem,
            this.cadastroDeDiciplinasToolStripMenuItem,
            this.cadastroDeTurmasToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sAIRToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "&Arquivos";
            // 
            // cadastroDeAlunosToolStripMenuItem
            // 
            this.cadastroDeAlunosToolStripMenuItem.Name = "cadastroDeAlunosToolStripMenuItem";
            this.cadastroDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cadastroDeAlunosToolStripMenuItem.Text = "Cadastro de &Alunos";
            // 
            // cadastroDeProfessoresToolStripMenuItem
            // 
            this.cadastroDeProfessoresToolStripMenuItem.Name = "cadastroDeProfessoresToolStripMenuItem";
            this.cadastroDeProfessoresToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cadastroDeProfessoresToolStripMenuItem.Text = "Cadastro de &Professores";
            // 
            // cadastroDeCursosToolStripMenuItem
            // 
            this.cadastroDeCursosToolStripMenuItem.Name = "cadastroDeCursosToolStripMenuItem";
            this.cadastroDeCursosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cadastroDeCursosToolStripMenuItem.Text = "Cadastro de &Cursos";
            // 
            // cadastroDeDiciplinasToolStripMenuItem
            // 
            this.cadastroDeDiciplinasToolStripMenuItem.Name = "cadastroDeDiciplinasToolStripMenuItem";
            this.cadastroDeDiciplinasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cadastroDeDiciplinasToolStripMenuItem.Text = "Cadastro de &Diciplinas";
            // 
            // cadastroDeTurmasToolStripMenuItem
            // 
            this.cadastroDeTurmasToolStripMenuItem.Name = "cadastroDeTurmasToolStripMenuItem";
            this.cadastroDeTurmasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cadastroDeTurmasToolStripMenuItem.Text = "Cadastro de &Turmas";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuItem1.Text = "Cadastro de Usuários";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.sAIRToolStripMenuItem.Text = "&SAIR";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbLoogo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbLoogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeDiciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeTurmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}