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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            lbl = new Label();
            txtId = new TextBox();
            dtpFim = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            txtCurso = new ComboBox();
            cbxTurno = new ComboBox();
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
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            limparToolStripMenuItem = new ToolStripMenuItem();
            deletarToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            gridCurso = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ColunaCurso = new DataGridViewTextBoxColumn();
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
            btnExportar = new Button();
            btnLimparCampos = new Button();
            btnSair = new Button();
            btnSalvar = new Button();
            btnDeletar = new Button();
            btnAdicionar = new Button();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCurso).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(dtpFim);
            groupBox1.Controls.Add(dtpInicio);
            groupBox1.Controls.Add(txtCurso);
            groupBox1.Controls.Add(cbxTurno);
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
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1130, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(35, 73);
            lbl.Name = "lbl";
            lbl.Size = new Size(21, 15);
            lbl.TabIndex = 35;
            lbl.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(59, 65);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(121, 23);
            txtId.TabIndex = 34;
            // 
            // dtpFim
            // 
            dtpFim.CustomFormat = "dd-MM-yyyy";
            dtpFim.Format = DateTimePickerFormat.Custom;
            dtpFim.Location = new Point(575, 67);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(119, 23);
            dtpFim.TabIndex = 33;
            dtpFim.Value = new DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // dtpInicio
            // 
            dtpInicio.CustomFormat = "dd-MM-yyyy";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(409, 67);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(119, 23);
            dtpInicio.TabIndex = 32;
            dtpInicio.Value = new DateTime(2023, 12, 2, 0, 0, 0, 0);
            // 
            // txtCurso
            // 
            txtCurso.FormattingEnabled = true;
            txtCurso.Items.AddRange(new object[] { "Tecnologia da Informação" });
            txtCurso.Location = new Point(231, 67);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(121, 23);
            txtCurso.TabIndex = 25;
            // 
            // cbxTurno
            // 
            cbxTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTurno.FormattingEnabled = true;
            cbxTurno.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno" });
            cbxTurno.Location = new Point(575, 114);
            cbxTurno.Name = "cbxTurno";
            cbxTurno.Size = new Size(121, 23);
            cbxTurno.TabIndex = 24;
            // 
            // txtMeta
            // 
            txtMeta.Location = new Point(758, 69);
            txtMeta.Name = "txtMeta";
            txtMeta.Size = new Size(121, 23);
            txtMeta.TabIndex = 23;
            txtMeta.KeyPress += NumbersOnly;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(59, 114);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(121, 23);
            txtDias.TabIndex = 22;
            txtDias.KeyPress += TextOnly;
            // 
            // txtSala
            // 
            txtSala.Location = new Point(955, 114);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(121, 23);
            txtSala.TabIndex = 17;
            // 
            // txtTurma
            // 
            txtTurma.Location = new Point(758, 115);
            txtTurma.Name = "txtTurma";
            txtTurma.Size = new Size(121, 23);
            txtTurma.TabIndex = 16;
            txtTurma.KeyPress += NumbersOnly;
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(231, 115);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(119, 23);
            txtHorario.TabIndex = 15;
            txtHorario.TextChanged += txtHorario_TextChanged;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(409, 114);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(121, 23);
            txtValor.TabIndex = 14;
            txtValor.KeyPress += AddCifrao;
            // 
            // txtRealizado
            // 
            txtRealizado.Location = new Point(955, 67);
            txtRealizado.Name = "txtRealizado";
            txtRealizado.Size = new Size(121, 23);
            txtRealizado.TabIndex = 13;
            txtRealizado.KeyPress += NumbersOnly;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(921, 122);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 11;
            label12.Text = "Sala:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(715, 123);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 10;
            label11.Text = "Turma:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(177, 122);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 9;
            label10.Text = "Horário:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(372, 122);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 8;
            label9.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(547, 75);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Fim:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(536, 123);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 7;
            label8.Text = "Turno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 73);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Curso:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(892, 75);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 6;
            label7.Text = "Realizado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(722, 75);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 5;
            label6.Text = "Meta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 75);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 122);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "Dias:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(3, 19);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1124, 24);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, salvarToolStripMenuItem, exportarToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(125, 22);
            adicionarToolStripMenuItem.Text = "Adicionar";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(125, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.Size = new Size(125, 22);
            exportarToolStripMenuItem.Text = "Exportar";
            exportarToolStripMenuItem.Click += exportarToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(125, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
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
            deletarToolStripMenuItem.Click += deletarToolStripMenuItem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gridCurso);
            groupBox2.Location = new Point(29, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1124, 308);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // gridCurso
            // 
            gridCurso.AllowUserToAddRows = false;
            gridCurso.AllowUserToDeleteRows = false;
            gridCurso.BackgroundColor = Color.LightGray;
            gridCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCurso.Columns.AddRange(new DataGridViewColumn[] { Column1, ColunaCurso, ColunaCursoInicio, ColunaCursoFim, ColunaCursoDias, ColunaCursoMeta, ColunaCursoRealizado, ColunaCursoTurno, ColunaCursoValor, ColunaCursoHorario, ColunaCursoTurma, ColunaCursoSala });
            gridCurso.Location = new Point(-6, 0);
            gridCurso.Name = "gridCurso";
            gridCurso.ReadOnly = true;
            gridCurso.RowHeadersWidth = 51;
            gridCurso.RowTemplate.Height = 25;
            gridCurso.Size = new Size(1130, 308);
            gridCurso.TabIndex = 6;
            gridCurso.CellClick += gridCurso_CellClick;
            gridCurso.CellContentClick += gridCurso_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "#";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 39;
            // 
            // ColunaCurso
            // 
            ColunaCurso.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColunaCurso.HeaderText = "Curso";
            ColunaCurso.MinimumWidth = 6;
            ColunaCurso.Name = "ColunaCurso";
            ColunaCurso.ReadOnly = true;
            ColunaCurso.Width = 63;
            // 
            // ColunaCursoInicio
            // 
            ColunaCursoInicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            ColunaCursoInicio.DefaultCellStyle = dataGridViewCellStyle5;
            ColunaCursoInicio.HeaderText = "Início";
            ColunaCursoInicio.MinimumWidth = 6;
            ColunaCursoInicio.Name = "ColunaCursoInicio";
            ColunaCursoInicio.ReadOnly = true;
            ColunaCursoInicio.Width = 61;
            // 
            // ColunaCursoFim
            // 
            ColunaCursoFim.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            ColunaCursoFim.DefaultCellStyle = dataGridViewCellStyle6;
            ColunaCursoFim.HeaderText = "Fim";
            ColunaCursoFim.MinimumWidth = 6;
            ColunaCursoFim.Name = "ColunaCursoFim";
            ColunaCursoFim.ReadOnly = true;
            ColunaCursoFim.Width = 52;
            // 
            // ColunaCursoDias
            // 
            ColunaCursoDias.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColunaCursoDias.HeaderText = "Dias";
            ColunaCursoDias.MinimumWidth = 6;
            ColunaCursoDias.Name = "ColunaCursoDias";
            ColunaCursoDias.ReadOnly = true;
            ColunaCursoDias.Width = 54;
            // 
            // ColunaCursoMeta
            // 
            ColunaCursoMeta.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColunaCursoMeta.HeaderText = "Meta";
            ColunaCursoMeta.MinimumWidth = 6;
            ColunaCursoMeta.Name = "ColunaCursoMeta";
            ColunaCursoMeta.ReadOnly = true;
            ColunaCursoMeta.Width = 59;
            // 
            // ColunaCursoRealizado
            // 
            ColunaCursoRealizado.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColunaCursoRealizado.HeaderText = "Realizado";
            ColunaCursoRealizado.MinimumWidth = 6;
            ColunaCursoRealizado.Name = "ColunaCursoRealizado";
            ColunaCursoRealizado.ReadOnly = true;
            ColunaCursoRealizado.Width = 82;
            // 
            // ColunaCursoTurno
            // 
            ColunaCursoTurno.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColunaCursoTurno.HeaderText = "Turno";
            ColunaCursoTurno.MinimumWidth = 6;
            ColunaCursoTurno.Name = "ColunaCursoTurno";
            ColunaCursoTurno.ReadOnly = true;
            ColunaCursoTurno.Width = 63;
            // 
            // ColunaCursoValor
            // 
            ColunaCursoValor.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColunaCursoValor.HeaderText = "Valor";
            ColunaCursoValor.MinimumWidth = 6;
            ColunaCursoValor.Name = "ColunaCursoValor";
            ColunaCursoValor.ReadOnly = true;
            ColunaCursoValor.Width = 58;
            // 
            // ColunaCursoHorario
            // 
            ColunaCursoHorario.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColunaCursoHorario.HeaderText = "Horário";
            ColunaCursoHorario.MinimumWidth = 6;
            ColunaCursoHorario.Name = "ColunaCursoHorario";
            ColunaCursoHorario.ReadOnly = true;
            ColunaCursoHorario.Width = 72;
            // 
            // ColunaCursoTurma
            // 
            ColunaCursoTurma.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColunaCursoTurma.HeaderText = "Turma";
            ColunaCursoTurma.MinimumWidth = 6;
            ColunaCursoTurma.Name = "ColunaCursoTurma";
            ColunaCursoTurma.ReadOnly = true;
            ColunaCursoTurma.Width = 66;
            // 
            // ColunaCursoSala
            // 
            ColunaCursoSala.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColunaCursoSala.HeaderText = "Sala";
            ColunaCursoSala.MinimumWidth = 6;
            ColunaCursoSala.Name = "ColunaCursoSala";
            ColunaCursoSala.ReadOnly = true;
            ColunaCursoSala.Width = 53;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExportar);
            groupBox3.Controls.Add(btnLimparCampos);
            groupBox3.Controls.Add(btnSair);
            groupBox3.Controls.Add(btnSalvar);
            groupBox3.Controls.Add(btnDeletar);
            groupBox3.Controls.Add(btnAdicionar);
            groupBox3.Location = new Point(23, 538);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1127, 111);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(808, 41);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(94, 31);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnLimparCampos
            // 
            btnLimparCampos.Location = new Point(222, 41);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(98, 31);
            btnLimparCampos.TabIndex = 7;
            btnLimparCampos.Text = "Limpar";
            btnLimparCampos.UseVisualStyleBackColor = true;
            btnLimparCampos.Click += btnLimparCampos_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(982, 41);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(98, 31);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click_1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(619, 41);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 31);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Atualizar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(409, 41);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(98, 31);
            btnDeletar.TabIndex = 2;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click_1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(40, 41);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(98, 31);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // Agenda_de_Curso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1182, 661);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximumSize = new Size(1200, 778);
            Name = "Agenda_de_Curso";
            Text = "Agenda de Cursos";
            Load += Agenda_de_Curso_Load;
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
        private Button btnSalvar;
        private Button btnDeletar;
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
        private Label label6;
        private Label label3;
        private Label label5;
        private ComboBox txtCurso;
        private ComboBox cbxTurno;
        private DataGridView gridCurso;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem limparToolStripMenuItem;
        private ToolStripMenuItem deletarToolStripMenuItem;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFim;
        private Label lbl;
        private TextBox txtId;
        private Button btnLimparCampos;
        private Button btnExportar;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColunaCurso;
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
    }
}