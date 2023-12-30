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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lbl = new Label();
            txtId = new TextBox();
            dtpFim = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            cmbCurso = new ComboBox();
            txtMeta = new TextBox();
            txtDias = new TextBox();
            txtSala = new TextBox();
            txtTurma = new TextBox();
            txtRealizado = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            limparToolStripMenuItem = new ToolStripMenuItem();
            deletarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarCursoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarUsuárioToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            gridCurso = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ColunaCurso = new DataGridViewTextBoxColumn();
            ColunaCursoInicio = new DataGridViewTextBoxColumn();
            ColunaCursoFim = new DataGridViewTextBoxColumn();
            ColunaCursoDias = new DataGridViewTextBoxColumn();
            ColunaCursoHorario = new DataGridViewTextBoxColumn();
            ColunaCursoMeta = new DataGridViewTextBoxColumn();
            ColunaCursoRealizado = new DataGridViewTextBoxColumn();
            ColunaCursoValor = new DataGridViewTextBoxColumn();
            ColunaCursoTurma = new DataGridViewTextBoxColumn();
            ColunaCursoSala = new DataGridViewTextBoxColumn();
            btnSair = new Button();
            cmbHorario = new ComboBox();
            btnExportar = new Button();
            mtbValor = new MaskedTextBox();
            btnAdicionar = new Button();
            btnLimparCampos = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCurso).BeginInit();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(86, 45);
            lbl.Name = "lbl";
            lbl.Size = new Size(26, 19);
            lbl.TabIndex = 35;
            lbl.Text = "ID:";
            lbl.Visible = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(115, 42);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(121, 23);
            txtId.TabIndex = 34;
            txtId.Visible = false;
            // 
            // dtpFim
            // 
            dtpFim.CustomFormat = "dd-MM-yyyy";
            dtpFim.Format = DateTimePickerFormat.Custom;
            dtpFim.Location = new Point(486, 80);
            dtpFim.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            dtpFim.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(119, 23);
            dtpFim.TabIndex = 3;
            dtpFim.Value = new DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // dtpInicio
            // 
            dtpInicio.CustomFormat = "dd-MM-yyyy";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(312, 80);
            dtpInicio.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            dtpInicio.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(119, 23);
            dtpInicio.TabIndex = 1;
            dtpInicio.Value = new DateTime(2023, 12, 2, 0, 0, 0, 0);
            // 
            // cmbCurso
            // 
            cmbCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Items.AddRange(new object[] { "Tecnologia da Informação" });
            cmbCurso.Location = new Point(115, 80);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(121, 23);
            cmbCurso.TabIndex = 0;
            cmbCurso.KeyPress += TextOnly;
            // 
            // txtMeta
            // 
            txtMeta.Location = new Point(115, 126);
            txtMeta.Name = "txtMeta";
            txtMeta.Size = new Size(121, 23);
            txtMeta.TabIndex = 6;
            txtMeta.KeyPress += NumbersOnly;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(664, 79);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(121, 23);
            txtDias.TabIndex = 4;
            txtDias.KeyPress += TextOnly;
            // 
            // txtSala
            // 
            txtSala.Location = new Point(853, 124);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(121, 23);
            txtSala.TabIndex = 10;
            // 
            // txtTurma
            // 
            txtTurma.Location = new Point(664, 126);
            txtTurma.Name = "txtTurma";
            txtTurma.Size = new Size(121, 23);
            txtTurma.TabIndex = 9;
            txtTurma.KeyPress += NumbersOnly;
            // 
            // txtRealizado
            // 
            txtRealizado.Location = new Point(310, 126);
            txtRealizado.Name = "txtRealizado";
            txtRealizado.Size = new Size(121, 23);
            txtRealizado.TabIndex = 7;
            txtRealizado.KeyPress += NumbersOnly;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(818, 131);
            label12.Name = "label12";
            label12.Size = new Size(36, 19);
            label12.TabIndex = 11;
            label12.Text = "Sala:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(613, 129);
            label11.Name = "label11";
            label11.Size = new Size(51, 19);
            label11.TabIndex = 10;
            label11.Text = "Turma:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(796, 84);
            label10.Name = "label10";
            label10.Size = new Size(58, 19);
            label10.TabIndex = 9;
            label10.Text = "Horário:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(442, 130);
            label9.Name = "label9";
            label9.Size = new Size(43, 19);
            label9.TabIndex = 8;
            label9.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(455, 83);
            label4.Name = "label4";
            label4.Size = new Size(34, 19);
            label4.TabIndex = 3;
            label4.Text = "Fim:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 84);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 0;
            label1.Text = "Curso:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(242, 131);
            label7.Name = "label7";
            label7.Size = new Size(69, 19);
            label7.TabIndex = 6;
            label7.Text = "Realizado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(70, 129);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 5;
            label6.Text = "Meta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(267, 84);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 2;
            label3.Text = "Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(624, 83);
            label5.Name = "label5";
            label5.Size = new Size(38, 19);
            label5.TabIndex = 4;
            label5.Text = "Dias:";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, cadastrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(187, 24);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, exportarToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            adicionarToolStripMenuItem.Size = new Size(167, 22);
            adicionarToolStripMenuItem.Text = "Adicionar";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exportarToolStripMenuItem.Size = new Size(167, 22);
            exportarToolStripMenuItem.Text = "Exportar";
            exportarToolStripMenuItem.Click += exportarToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            sairToolStripMenuItem.Size = new Size(167, 22);
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
            limparToolStripMenuItem.Size = new Size(181, 22);
            limparToolStripMenuItem.Text = "Limpar";
            limparToolStripMenuItem.Click += limparToolStripMenuItem_Click;
            // 
            // deletarToolStripMenuItem
            // 
            deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            deletarToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.Delete;
            deletarToolStripMenuItem.Size = new Size(181, 22);
            deletarToolStripMenuItem.Text = "Excluir";
            deletarToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarCursoToolStripMenuItem, cadastrarUsuárioToolStripMenuItem1 });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(69, 20);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // cadastrarCursoToolStripMenuItem
            // 
            cadastrarCursoToolStripMenuItem.Name = "cadastrarCursoToolStripMenuItem";
            cadastrarCursoToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            cadastrarCursoToolStripMenuItem.Size = new Size(202, 22);
            cadastrarCursoToolStripMenuItem.Text = "Cadastrar curso";
            cadastrarCursoToolStripMenuItem.Click += cadastrarCursoToolStripMenuItem_Click;
            // 
            // cadastrarUsuárioToolStripMenuItem1
            // 
            cadastrarUsuárioToolStripMenuItem1.Name = "cadastrarUsuárioToolStripMenuItem1";
            cadastrarUsuárioToolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.E;
            cadastrarUsuárioToolStripMenuItem1.Size = new Size(202, 22);
            cadastrarUsuárioToolStripMenuItem1.Text = "Cadastrar usuário";
            cadastrarUsuárioToolStripMenuItem1.Click += cadastrarUsuárioToolStripMenuItem1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(gridCurso);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(cmbHorario);
            panel1.Controls.Add(btnExportar);
            panel1.Controls.Add(mtbValor);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(btnLimparCampos);
            panel1.Controls.Add(lbl);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(dtpFim);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpInicio);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbCurso);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMeta);
            panel1.Controls.Add(txtDias);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSala);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtTurma);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtRealizado);
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(1920, 1080);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 564);
            panel1.TabIndex = 3;
            // 
            // gridCurso
            // 
            gridCurso.AllowUserToAddRows = false;
            gridCurso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gridCurso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridCurso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridCurso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCurso.BackgroundColor = Color.LightGray;
            gridCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCurso.Columns.AddRange(new DataGridViewColumn[] { Column1, ColunaCurso, ColunaCursoInicio, ColunaCursoFim, ColunaCursoDias, ColunaCursoHorario, ColunaCursoMeta, ColunaCursoRealizado, ColunaCursoValor, ColunaCursoTurma, ColunaCursoSala });
            gridCurso.Location = new Point(0, 179);
            gridCurso.MaximumSize = new Size(1920, 900);
            gridCurso.Name = "gridCurso";
            gridCurso.ReadOnly = true;
            gridCurso.RowHeadersWidth = 51;
            gridCurso.RowTemplate.Height = 25;
            gridCurso.Size = new Size(998, 240);
            gridCurso.TabIndex = 17;
            gridCurso.CellClick += gridCurso_CellClick;
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
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            ColunaCursoInicio.DefaultCellStyle = dataGridViewCellStyle2;
            ColunaCursoInicio.HeaderText = "Início";
            ColunaCursoInicio.MinimumWidth = 6;
            ColunaCursoInicio.Name = "ColunaCursoInicio";
            ColunaCursoInicio.ReadOnly = true;
            // 
            // ColunaCursoFim
            // 
            ColunaCursoFim.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            ColunaCursoFim.DefaultCellStyle = dataGridViewCellStyle3;
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
            // ColunaCursoHorario
            // 
            ColunaCursoHorario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoHorario.HeaderText = "Horário";
            ColunaCursoHorario.MinimumWidth = 6;
            ColunaCursoHorario.Name = "ColunaCursoHorario";
            ColunaCursoHorario.ReadOnly = true;
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
            // ColunaCursoValor
            // 
            ColunaCursoValor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoValor.HeaderText = "Valor";
            ColunaCursoValor.MinimumWidth = 6;
            ColunaCursoValor.Name = "ColunaCursoValor";
            ColunaCursoValor.ReadOnly = true;
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
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Location = new Point(867, 460);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(98, 31);
            btnSair.TabIndex = 16;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click_1;
            // 
            // cmbHorario
            // 
            cmbHorario.FormattingEnabled = true;
            cmbHorario.Items.AddRange(new object[] { "07:00 às 12:00", "13:00 às 18:00", "19:00 às 22:00" });
            cmbHorario.Location = new Point(853, 79);
            cmbHorario.Name = "cmbHorario";
            cmbHorario.Size = new Size(121, 23);
            cmbHorario.TabIndex = 5;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Bottom;
            btnExportar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnExportar.Location = new Point(697, 460);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(94, 31);
            btnExportar.TabIndex = 15;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // mtbValor
            // 
            mtbValor.Location = new Point(486, 127);
            mtbValor.Mask = "$99,999.99";
            mtbValor.Name = "mtbValor";
            mtbValor.Size = new Size(121, 23);
            mtbValor.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Bottom;
            btnAdicionar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(37, 460);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(98, 31);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // btnLimparCampos
            // 
            btnLimparCampos.Anchor = AnchorStyles.Bottom;
            btnLimparCampos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimparCampos.Location = new Point(194, 460);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(98, 31);
            btnLimparCampos.TabIndex = 12;
            btnLimparCampos.Text = "Limpar";
            btnLimparCampos.UseVisualStyleBackColor = true;
            btnLimparCampos.Click += btnLimparCampos_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Bottom;
            btnAlterar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.Location = new Point(520, 460);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(98, 31);
            btnAlterar.TabIndex = 14;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom;
            btnExcluir.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Location = new Point(349, 460);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(98, 31);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // Agenda_de_Curso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1000, 561);
            Controls.Add(panel1);
            MaximumSize = new Size(1680, 1050);
            MinimumSize = new Size(900, 600);
            Name = "Agenda_de_Curso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda de Cursos";
            Load += Agenda_de_Curso_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCurso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMeta;
        private TextBox txtDias;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox txtSala;
        private TextBox txtTurma;
        private TextBox txtRealizado;
        private TextBox textBox1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label4;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label5;
        private ComboBox cmbCurso;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
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
        private Button btnSair;
        private Button btnExportar;
        private Button btnAdicionar;
        private Button btnLimparCampos;
        private Button btnAlterar;
        private Button btnExcluir;
        private MaskedTextBox mtbValor;
        private DataGridView gridCurso;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem cadastrarCursoToolStripMenuItem;
        private ToolStripMenuItem cadastrarUsuárioToolStripMenuItem1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColunaCurso;
        private DataGridViewTextBoxColumn ColunaCursoInicio;
        private DataGridViewTextBoxColumn ColunaCursoFim;
        private DataGridViewTextBoxColumn ColunaCursoDias;
        private DataGridViewTextBoxColumn ColunaCursoHorario;
        private DataGridViewTextBoxColumn ColunaCursoMeta;
        private DataGridViewTextBoxColumn ColunaCursoRealizado;
        private DataGridViewTextBoxColumn ColunaCursoValor;
        private DataGridViewTextBoxColumn ColunaCursoTurma;
        private DataGridViewTextBoxColumn ColunaCursoSala;
        private ComboBox cmbHorario;
    }
}