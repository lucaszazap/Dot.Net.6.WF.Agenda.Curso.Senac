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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
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
            panel1 = new Panel();
            mtbValor = new MaskedTextBox();
            panel2 = new Panel();
            btnSair = new Button();
            btnExportar = new Button();
            btnAdicionar = new Button();
            btnLimparCampos = new Button();
            btnSalvar = new Button();
            btnDeletar = new Button();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCurso).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(25, 46);
            lbl.Name = "lbl";
            lbl.Size = new Size(21, 15);
            lbl.TabIndex = 35;
            lbl.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(49, 38);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(121, 23);
            txtId.TabIndex = 34;
            // 
            // dtpFim
            // 
            dtpFim.CustomFormat = "dd-MM-yyyy";
            dtpFim.Format = DateTimePickerFormat.Custom;
            dtpFim.Location = new Point(565, 40);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(119, 23);
            dtpFim.TabIndex = 33;
            dtpFim.Value = new DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // dtpInicio
            // 
            dtpInicio.CustomFormat = "dd-MM-yyyy";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(399, 40);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(119, 23);
            dtpInicio.TabIndex = 32;
            dtpInicio.Value = new DateTime(2023, 12, 2, 0, 0, 0, 0);
            // 
            // txtCurso
            // 
            txtCurso.FormattingEnabled = true;
            txtCurso.Items.AddRange(new object[] { "Tecnologia da Informação" });
            txtCurso.Location = new Point(221, 40);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(121, 23);
            txtCurso.TabIndex = 25;
            // 
            // cbxTurno
            // 
            cbxTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTurno.FormattingEnabled = true;
            cbxTurno.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno" });
            cbxTurno.Location = new Point(565, 87);
            cbxTurno.Name = "cbxTurno";
            cbxTurno.Size = new Size(121, 23);
            cbxTurno.TabIndex = 24;
            // 
            // txtMeta
            // 
            txtMeta.Location = new Point(748, 42);
            txtMeta.Name = "txtMeta";
            txtMeta.Size = new Size(121, 23);
            txtMeta.TabIndex = 23;
            txtMeta.KeyPress += NumbersOnly;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(49, 87);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(121, 23);
            txtDias.TabIndex = 22;
            txtDias.KeyPress += TextOnly;
            // 
            // txtSala
            // 
            txtSala.Location = new Point(945, 88);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(121, 23);
            txtSala.TabIndex = 17;
            // 
            // txtTurma
            // 
            txtTurma.Location = new Point(748, 88);
            txtTurma.Name = "txtTurma";
            txtTurma.Size = new Size(121, 23);
            txtTurma.TabIndex = 16;
            txtTurma.KeyPress += NumbersOnly;
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(221, 88);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(119, 23);
            txtHorario.TabIndex = 15;
            txtHorario.TextChanged += txtHorario_TextChanged;
            // 
            // txtRealizado
            // 
            txtRealizado.Location = new Point(945, 40);
            txtRealizado.Name = "txtRealizado";
            txtRealizado.Size = new Size(121, 23);
            txtRealizado.TabIndex = 13;
            txtRealizado.KeyPress += NumbersOnly;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(911, 95);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 11;
            label12.Text = "Sala:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(705, 96);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 10;
            label11.Text = "Turma:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(167, 95);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 9;
            label10.Text = "Horário:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(362, 96);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 8;
            label9.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(537, 48);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Fim:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(526, 96);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 7;
            label8.Text = "Turno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 46);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Curso:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(882, 48);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 6;
            label7.Text = "Realizado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(712, 48);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 5;
            label6.Text = "Meta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 48);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 95);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "Dias:";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(118, 24);
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
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
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
            groupBox2.Location = new Point(12, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1094, 316);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // gridCurso
            // 
            gridCurso.AllowUserToAddRows = false;
            gridCurso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gridCurso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            gridCurso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCurso.BackgroundColor = Color.LightGray;
            gridCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCurso.Columns.AddRange(new DataGridViewColumn[] { Column1, ColunaCurso, ColunaCursoInicio, ColunaCursoFim, ColunaCursoDias, ColunaCursoMeta, ColunaCursoRealizado, ColunaCursoTurno, ColunaCursoValor, ColunaCursoHorario, ColunaCursoTurma, ColunaCursoSala });
            gridCurso.Location = new Point(-1, 5);
            gridCurso.Name = "gridCurso";
            gridCurso.ReadOnly = true;
            gridCurso.RowHeadersWidth = 51;
            gridCurso.RowTemplate.Height = 25;
            gridCurso.Size = new Size(1095, 310);
            gridCurso.TabIndex = 6;
            gridCurso.CellClick += gridCurso_CellClick;
            gridCurso.CellContentClick += gridCurso_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "#";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // ColunaCurso
            // 
            ColunaCurso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCurso.HeaderText = "Curso";
            ColunaCurso.MinimumWidth = 6;
            ColunaCurso.Name = "ColunaCurso";
            ColunaCurso.ReadOnly = true;
            // 
            // ColunaCursoInicio
            // 
            ColunaCursoInicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            ColunaCursoInicio.DefaultCellStyle = dataGridViewCellStyle8;
            ColunaCursoInicio.HeaderText = "Início";
            ColunaCursoInicio.MinimumWidth = 6;
            ColunaCursoInicio.Name = "ColunaCursoInicio";
            ColunaCursoInicio.ReadOnly = true;
            // 
            // ColunaCursoFim
            // 
            ColunaCursoFim.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            ColunaCursoFim.DefaultCellStyle = dataGridViewCellStyle9;
            ColunaCursoFim.HeaderText = "Fim";
            ColunaCursoFim.MinimumWidth = 6;
            ColunaCursoFim.Name = "ColunaCursoFim";
            ColunaCursoFim.ReadOnly = true;
            // 
            // ColunaCursoDias
            // 
            ColunaCursoDias.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoDias.HeaderText = "Dias";
            ColunaCursoDias.MinimumWidth = 6;
            ColunaCursoDias.Name = "ColunaCursoDias";
            ColunaCursoDias.ReadOnly = true;
            // 
            // ColunaCursoMeta
            // 
            ColunaCursoMeta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoMeta.HeaderText = "Meta";
            ColunaCursoMeta.MinimumWidth = 6;
            ColunaCursoMeta.Name = "ColunaCursoMeta";
            ColunaCursoMeta.ReadOnly = true;
            // 
            // ColunaCursoRealizado
            // 
            ColunaCursoRealizado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoRealizado.HeaderText = "Realizado";
            ColunaCursoRealizado.MinimumWidth = 6;
            ColunaCursoRealizado.Name = "ColunaCursoRealizado";
            ColunaCursoRealizado.ReadOnly = true;
            // 
            // ColunaCursoTurno
            // 
            ColunaCursoTurno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoTurno.HeaderText = "Turno";
            ColunaCursoTurno.MinimumWidth = 6;
            ColunaCursoTurno.Name = "ColunaCursoTurno";
            ColunaCursoTurno.ReadOnly = true;
            // 
            // ColunaCursoValor
            // 
            ColunaCursoValor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoValor.HeaderText = "Valor";
            ColunaCursoValor.MinimumWidth = 6;
            ColunaCursoValor.Name = "ColunaCursoValor";
            ColunaCursoValor.ReadOnly = true;
            // 
            // ColunaCursoHorario
            // 
            ColunaCursoHorario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoHorario.HeaderText = "Horário";
            ColunaCursoHorario.MinimumWidth = 6;
            ColunaCursoHorario.Name = "ColunaCursoHorario";
            ColunaCursoHorario.ReadOnly = true;
            // 
            // ColunaCursoTurma
            // 
            ColunaCursoTurma.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoTurma.HeaderText = "Turma";
            ColunaCursoTurma.MinimumWidth = 6;
            ColunaCursoTurma.Name = "ColunaCursoTurma";
            ColunaCursoTurma.ReadOnly = true;
            // 
            // ColunaCursoSala
            // 
            ColunaCursoSala.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoSala.HeaderText = "Sala";
            ColunaCursoSala.MinimumWidth = 6;
            ColunaCursoSala.Name = "ColunaCursoSala";
            ColunaCursoSala.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(mtbValor);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(lbl);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtpFim);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpInicio);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtCurso);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbxTurno);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMeta);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtDias);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSala);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtTurma);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtHorario);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtRealizado);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 155);
            panel1.TabIndex = 3;
            // 
            // mtbValor
            // 
            mtbValor.Location = new Point(403, 88);
            mtbValor.Mask = "$ 999.999,00";
            mtbValor.Name = "mtbValor";
            mtbValor.Size = new Size(117, 23);
            mtbValor.TabIndex = 36;
            mtbValor.MaskInputRejected += mtbValor_MaskInputRejected;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSair);
            panel2.Controls.Add(btnExportar);
            panel2.Controls.Add(btnAdicionar);
            panel2.Controls.Add(btnLimparCampos);
            panel2.Controls.Add(btnSalvar);
            panel2.Controls.Add(btnDeletar);
            panel2.Location = new Point(13, 549);
            panel2.Name = "panel2";
            panel2.Size = new Size(1093, 87);
            panel2.TabIndex = 7;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(968, 31);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(98, 31);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click_1;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(775, 31);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(94, 31);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(14, 31);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(98, 31);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // btnLimparCampos
            // 
            btnLimparCampos.Location = new Point(203, 31);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(98, 31);
            btnLimparCampos.TabIndex = 7;
            btnLimparCampos.Text = "Limpar";
            btnLimparCampos.UseVisualStyleBackColor = true;
            btnLimparCampos.Click += btnLimparCampos_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(588, 31);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 31);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Atualizar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(399, 31);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(98, 31);
            btnDeletar.TabIndex = 2;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click_1;
            // 
            // Agenda_de_Curso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1126, 661);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            MaximumSize = new Size(1200, 778);
            Name = "Agenda_de_Curso";
            Text = "Agenda de Cursos";
            Load += Agenda_de_Curso_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCurso).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private TextBox txtMeta;
        private TextBox txtDias;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox txtSala;
        private TextBox txtTurma;
        private TextBox txtHorario;
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
        private ToolStripMenuItem exportarToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Button btnSair;
        private Button btnExportar;
        private Button btnAdicionar;
        private Button btnLimparCampos;
        private Button btnSalvar;
        private Button btnDeletar;
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
        private MaskedTextBox mtbValor;
    }
}