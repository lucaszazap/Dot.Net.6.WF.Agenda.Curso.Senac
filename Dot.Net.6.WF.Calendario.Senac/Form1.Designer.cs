namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class Agenda_de_Curso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda_de_Curso));
            groupBox1 = new GroupBox();
            txtMes = new ComboBox();
            txtCurso = new ComboBox();
            txtTurno = new ComboBox();
            txtMeta = new TextBox();
            txtDias = new TextBox();
            txtSala = new TextBox();
            txtTurma = new TextBox();
            txtHorario = new TextBox();
            txtValor = new TextBox();
            txtRealizado = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            label8 = new Label();
            label1 = new Label();
            label7 = new Label();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            limparToolStripMenuItem = new ToolStripMenuItem();
            deletarToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            gridCurso = new DataGridView();
            ColunaCurso = new DataGridViewTextBoxColumn();
            ColunaCursoMes = new DataGridViewTextBoxColumn();
            ColunaCursoInicio = new DataGridViewTextBoxColumn();
            ColunaCursoFim = new DataGridViewTextBoxColumn();
            ColunaCursoDias = new DataGridViewTextBoxColumn();
            ColunaCursoMeta = new DataGridViewTextBoxColumn();
            ColunaCursoRealizado = new DataGridViewTextBoxColumn();
            ColunaCursoTurno = new DataGridViewTextBoxColumn();
            ColunaCursoValor = new DataGridViewTextBoxColumn();
            ColunaCursoHorario = new DataGridViewTextBoxColumn();
            ColunaCursoTurma = new DataGridViewTextBoxColumn();
            ColunaCursoSala = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            btnSair = new Button();
            btnImprimir = new Button();
            btnSalvar = new Button();
            btnDeletar = new Button();
            btnLimpar = new Button();
            btnAdicionar = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            txtInicio = new TextBox();
            txtFim = new TextBox();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCurso).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFim);
            groupBox1.Controls.Add(txtInicio);
            groupBox1.Controls.Add(txtMes);
            groupBox1.Controls.Add(txtCurso);
            groupBox1.Controls.Add(txtTurno);
            groupBox1.Controls.Add(txtMeta);
            groupBox1.Controls.Add(txtDias);
            groupBox1.Controls.Add(txtSala);
            groupBox1.Controls.Add(txtTurma);
            groupBox1.Controls.Add(txtHorario);
            groupBox1.Controls.Add(txtValor);
            groupBox1.Controls.Add(txtRealizado);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1005, 163);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtMes
            // 
            txtMes.FormattingEnabled = true;
            txtMes.Items.AddRange(new object[] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" });
            txtMes.Location = new Point(239, 48);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(121, 23);
            txtMes.TabIndex = 26;
            // 
            // txtCurso
            // 
            txtCurso.FormattingEnabled = true;
            txtCurso.Items.AddRange(new object[] { "Tecnologia da Informação" });
            txtCurso.Location = new Point(67, 48);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(121, 23);
            txtCurso.TabIndex = 25;
            // 
            // txtTurno
            // 
            txtTurno.FormattingEnabled = true;
            txtTurno.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno" });
            txtTurno.Location = new Point(239, 91);
            txtTurno.Name = "txtTurno";
            txtTurno.Size = new Size(121, 23);
            txtTurno.TabIndex = 24;
            // 
            // txtMeta
            // 
            txtMeta.Location = new Point(872, 48);
            txtMeta.Name = "txtMeta";
            txtMeta.Size = new Size(100, 23);
            txtMeta.TabIndex = 23;
            txtMeta.KeyPress += NumbersOnly;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(727, 48);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(100, 23);
            txtDias.TabIndex = 22;
            // 
            // txtSala
            // 
            txtSala.Location = new Point(873, 94);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(100, 23);
            txtSala.TabIndex = 17;
            // 
            // txtTurma
            // 
            txtTurma.Location = new Point(733, 94);
            txtTurma.Name = "txtTurma";
            txtTurma.Size = new Size(100, 23);
            txtTurma.TabIndex = 16;
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(570, 91);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(100, 23);
            txtHorario.TabIndex = 15;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(411, 94);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 14;
            txtValor.KeyPress += NumbersOnly;
            // 
            // txtRealizado
            // 
            txtRealizado.Location = new Point(67, 91);
            txtRealizado.Name = "txtRealizado";
            txtRealizado.Size = new Size(121, 23);
            txtRealizado.TabIndex = 13;
            txtRealizado.KeyPress += NumbersOnly;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(839, 99);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 11;
            label12.Text = "Sala";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(686, 97);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 10;
            label11.Text = "Turma";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(517, 99);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 9;
            label10.Text = "Horário";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(372, 99);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 8;
            label9.Text = "Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(528, 56);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 3;
            label4.Text = "Fim";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(195, 97);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "Turno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 51);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Curso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 97);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 6;
            label7.Text = "Realizado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 51);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Mês";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(833, 56);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 5;
            label6.Text = "Meta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 56);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Início";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(692, 56);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 4;
            label5.Text = "Dias";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(3, 19);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(999, 24);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, salvarToolStripMenuItem, imprimirToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(125, 22);
            adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(125, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(125, 22);
            imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(125, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { limparToolStripMenuItem, deletarToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // limparToolStripMenuItem
            // 
            limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            limparToolStripMenuItem.Size = new Size(111, 22);
            limparToolStripMenuItem.Text = "Limpar";
            // 
            // deletarToolStripMenuItem
            // 
            deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            deletarToolStripMenuItem.Size = new Size(111, 22);
            deletarToolStripMenuItem.Text = "Deletar";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gridCurso);
            groupBox2.Location = new Point(12, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1005, 308);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // gridCurso
            // 
            gridCurso.AllowUserToAddRows = false;
            gridCurso.AllowUserToDeleteRows = false;
            gridCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCurso.Columns.AddRange(new DataGridViewColumn[] { ColunaCurso, ColunaCursoMes, ColunaCursoInicio, ColunaCursoFim, ColunaCursoDias, ColunaCursoMeta, ColunaCursoRealizado, ColunaCursoTurno, ColunaCursoValor, ColunaCursoHorario, ColunaCursoTurma, ColunaCursoSala });
            gridCurso.Location = new Point(0, 11);
            gridCurso.Name = "gridCurso";
            gridCurso.ReadOnly = true;
            gridCurso.RowTemplate.Height = 25;
            gridCurso.Size = new Size(999, 291);
            gridCurso.TabIndex = 6;
            // 
            // ColunaCurso
            // 
            ColunaCurso.HeaderText = "Curso";
            ColunaCurso.Name = "ColunaCurso";
            ColunaCurso.ReadOnly = true;
            // 
            // ColunaCursoMes
            // 
            ColunaCursoMes.HeaderText = "Mês";
            ColunaCursoMes.Name = "ColunaCursoMes";
            ColunaCursoMes.ReadOnly = true;
            // 
            // ColunaCursoInicio
            // 
            ColunaCursoInicio.HeaderText = "Início";
            ColunaCursoInicio.Name = "ColunaCursoInicio";
            ColunaCursoInicio.ReadOnly = true;
            // 
            // ColunaCursoFim
            // 
            ColunaCursoFim.HeaderText = "Fim";
            ColunaCursoFim.Name = "ColunaCursoFim";
            ColunaCursoFim.ReadOnly = true;
            // 
            // ColunaCursoDias
            // 
            ColunaCursoDias.HeaderText = "Dias";
            ColunaCursoDias.Name = "ColunaCursoDias";
            ColunaCursoDias.ReadOnly = true;
            // 
            // ColunaCursoMeta
            // 
            ColunaCursoMeta.HeaderText = "Meta";
            ColunaCursoMeta.Name = "ColunaCursoMeta";
            ColunaCursoMeta.ReadOnly = true;
            // 
            // ColunaCursoRealizado
            // 
            ColunaCursoRealizado.HeaderText = "Realizado";
            ColunaCursoRealizado.Name = "ColunaCursoRealizado";
            ColunaCursoRealizado.ReadOnly = true;
            // 
            // ColunaCursoTurno
            // 
            ColunaCursoTurno.HeaderText = "Turno";
            ColunaCursoTurno.Name = "ColunaCursoTurno";
            ColunaCursoTurno.ReadOnly = true;
            // 
            // ColunaCursoValor
            // 
            ColunaCursoValor.HeaderText = "Valor";
            ColunaCursoValor.Name = "ColunaCursoValor";
            ColunaCursoValor.ReadOnly = true;
            // 
            // ColunaCursoHorario
            // 
            ColunaCursoHorario.HeaderText = "Horário";
            ColunaCursoHorario.Name = "ColunaCursoHorario";
            ColunaCursoHorario.ReadOnly = true;
            // 
            // ColunaCursoTurma
            // 
            ColunaCursoTurma.HeaderText = "Turma";
            ColunaCursoTurma.Name = "ColunaCursoTurma";
            ColunaCursoTurma.ReadOnly = true;
            // 
            // ColunaCursoSala
            // 
            ColunaCursoSala.HeaderText = "Sala";
            ColunaCursoSala.Name = "ColunaCursoSala";
            ColunaCursoSala.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSair);
            groupBox3.Controls.Add(btnImprimir);
            groupBox3.Controls.Add(btnSalvar);
            groupBox3.Controls.Add(btnDeletar);
            groupBox3.Controls.Add(btnLimpar);
            groupBox3.Controls.Add(btnAdicionar);
            groupBox3.Location = new Point(12, 513);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1005, 99);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(851, 41);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(98, 31);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(686, 41);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(98, 31);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(527, 41);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 31);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(374, 41);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(98, 31);
            btnDeletar.TabIndex = 2;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(206, 41);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(98, 31);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(45, 41);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(98, 31);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(411, 53);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(100, 23);
            txtInicio.TabIndex = 30;
            // 
            // txtFim
            // 
            txtFim.Location = new Point(561, 53);
            txtFim.Name = "txtFim";
            txtFim.Size = new Size(100, 23);
            txtFim.TabIndex = 31;
            // 
            // Agenda_de_Curso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 661);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Agenda_de_Curso";
            Text = "Agenda_de_Curso";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCurso).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnAdicionar;
        private Button btnSair;
        private Button btnImprimir;
        private Button btnSalvar;
        private Button btnDeletar;
        private Button btnLimpar;
        private TextBox txtMeta;
        private TextBox txtDias;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox txtSala;
        private TextBox txtTurma;
        private TextBox txtHorario;
        private TextBox txtValor;
        private TextBox txtRealizado;
        private TextBox textBox1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label4;
        private Label label8;
        private Label label1;
        private Label label7;
        private Label label2;
        private Label label6;
        private Label label3;
        private Label label5;
        private ComboBox txtCurso;
        private ComboBox txtTurno;
        private DataGridView gridCurso;
        private DataGridViewTextBoxColumn ColunaCurso;
        private DataGridViewTextBoxColumn ColunaCursoMes;
        private DataGridViewTextBoxColumn ColunaCursoInicio;
        private DataGridViewTextBoxColumn ColunaCursoFim;
        private DataGridViewTextBoxColumn ColunaCursoDias;
        private DataGridViewTextBoxColumn ColunaCursoMeta;
        private DataGridViewTextBoxColumn ColunaCursoRealizado;
        private DataGridViewTextBoxColumn ColunaCursoTurno;
        private DataGridViewTextBoxColumn ColunaCursoValor;
        private DataGridViewTextBoxColumn ColunaCursoHorario;
        private DataGridViewTextBoxColumn ColunaCursoTurma;
        private DataGridViewTextBoxColumn ColunaCursoSala;
        private ComboBox txtMes;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem limparToolStripMenuItem;
        private ToolStripMenuItem deletarToolStripMenuItem;
        private TextBox txtFim;
        private TextBox txtInicio;
    }
}