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
            controleToolStripMenuItem = new ToolStripMenuItem();
            acessoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label2 = new Label();
            txtPesquisar = new TextBox();
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
            lbl.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(25, 51);
            lbl.Name = "lbl";
            lbl.Size = new Size(26, 18);
            lbl.TabIndex = 35;
            lbl.Text = "ID:";
            lbl.Visible = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(54, 48);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(150, 23);
            txtId.TabIndex = 34;
            txtId.Visible = false;
            // 
            // dtpFim
            // 
            dtpFim.CalendarMonthBackground = SystemColors.HighlightText;
            dtpFim.CustomFormat = "dd-MM-yyyy";
            dtpFim.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFim.Format = DateTimePickerFormat.Custom;
            dtpFim.Location = new Point(497, 111);
            dtpFim.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            dtpFim.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(215, 25);
            dtpFim.TabIndex = 3;
            dtpFim.Value = new DateTime(2024, 1, 8, 0, 0, 0, 0);
            // 
            // dtpInicio
            // 
            dtpInicio.CalendarMonthBackground = SystemColors.HighlightText;
            dtpInicio.CustomFormat = "dd-MM-yyyy";
            dtpInicio.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(265, 111);
            dtpInicio.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            dtpInicio.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(215, 25);
            dtpInicio.TabIndex = 1;
            dtpInicio.Value = new DateTime(2024, 1, 8, 0, 0, 0, 0);
            // 
            // cmbCurso
            // 
            cmbCurso.BackColor = SystemColors.HighlightText;
            cmbCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Items.AddRange(new object[] { "Tecnologia da Informação" });
            cmbCurso.Location = new Point(26, 110);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(215, 26);
            cmbCurso.TabIndex = 0;
            cmbCurso.KeyPress += TextOnly;
            // 
            // txtMeta
            // 
            txtMeta.BackColor = SystemColors.HighlightText;
            txtMeta.BorderStyle = BorderStyle.FixedSingle;
            txtMeta.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMeta.Location = new Point(26, 161);
            txtMeta.Name = "txtMeta";
            txtMeta.Size = new Size(215, 25);
            txtMeta.TabIndex = 6;
            txtMeta.KeyPress += NumbersOnly;
            // 
            // txtDias
            // 
            txtDias.BackColor = SystemColors.HighlightText;
            txtDias.BorderStyle = BorderStyle.FixedSingle;
            txtDias.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDias.Location = new Point(729, 111);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(215, 25);
            txtDias.TabIndex = 4;
            txtDias.KeyPress += TextOnly;
            // 
            // txtSala
            // 
            txtSala.BackColor = SystemColors.HighlightText;
            txtSala.BorderStyle = BorderStyle.FixedSingle;
            txtSala.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSala.Location = new Point(962, 161);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(215, 25);
            txtSala.TabIndex = 10;
            // 
            // txtTurma
            // 
            txtTurma.BackColor = SystemColors.HighlightText;
            txtTurma.BorderStyle = BorderStyle.FixedSingle;
            txtTurma.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTurma.Location = new Point(729, 161);
            txtTurma.Name = "txtTurma";
            txtTurma.Size = new Size(215, 25);
            txtTurma.TabIndex = 9;
            txtTurma.KeyPress += NumbersOnly;
            // 
            // txtRealizado
            // 
            txtRealizado.BackColor = SystemColors.HighlightText;
            txtRealizado.BorderStyle = BorderStyle.FixedSingle;
            txtRealizado.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRealizado.Location = new Point(265, 161);
            txtRealizado.Name = "txtRealizado";
            txtRealizado.Size = new Size(215, 25);
            txtRealizado.TabIndex = 7;
            txtRealizado.KeyPress += NumbersOnly;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(959, 144);
            label12.Name = "label12";
            label12.Size = new Size(40, 18);
            label12.TabIndex = 11;
            label12.Text = "Sala:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(725, 144);
            label11.Name = "label11";
            label11.Size = new Size(55, 18);
            label11.TabIndex = 10;
            label11.Text = "Turma:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(960, 93);
            label10.Name = "label10";
            label10.Size = new Size(65, 18);
            label10.TabIndex = 9;
            label10.Text = "Horário:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(494, 144);
            label9.Name = "label9";
            label9.Size = new Size(48, 18);
            label9.TabIndex = 8;
            label9.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(495, 94);
            label4.Name = "label4";
            label4.Size = new Size(36, 18);
            label4.TabIndex = 3;
            label4.Text = "Fim:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 91);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 0;
            label1.Text = "Curso:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(262, 143);
            label7.Name = "label7";
            label7.Size = new Size(99, 18);
            label7.TabIndex = 6;
            label7.Text = "Matriculados:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 143);
            label6.Name = "label6";
            label6.Size = new Size(116, 18);
            label6.TabIndex = 5;
            label6.Text = "Meta de Alunos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(264, 93);
            label3.Name = "label3";
            label3.Size = new Size(48, 18);
            label3.TabIndex = 2;
            label3.Text = "Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(726, 93);
            label5.Name = "label5";
            label5.Size = new Size(40, 18);
            label5.TabIndex = 4;
            label5.Text = "Dias:";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, cadastrarToolStripMenuItem, controleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(245, 24);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, exportarToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(59, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Image = (Image)resources.GetObject("adicionarToolStripMenuItem.Image");
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            adicionarToolStripMenuItem.Size = new Size(164, 22);
            adicionarToolStripMenuItem.Text = "Adicionar";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.Image = (Image)resources.GetObject("exportarToolStripMenuItem.Image");
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exportarToolStripMenuItem.Size = new Size(164, 22);
            exportarToolStripMenuItem.Text = "Exportar";
            exportarToolStripMenuItem.Click += exportarToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = (Image)resources.GetObject("sairToolStripMenuItem.Image");
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            sairToolStripMenuItem.Size = new Size(164, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { limparToolStripMenuItem, deletarToolStripMenuItem });
            editarToolStripMenuItem.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point);
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // limparToolStripMenuItem
            // 
            limparToolStripMenuItem.Image = (Image)resources.GetObject("limparToolStripMenuItem.Image");
            limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            limparToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            limparToolStripMenuItem.Size = new Size(184, 22);
            limparToolStripMenuItem.Text = "Limpar";
            limparToolStripMenuItem.Click += limparToolStripMenuItem_Click;
            // 
            // deletarToolStripMenuItem
            // 
            deletarToolStripMenuItem.Image = (Image)resources.GetObject("deletarToolStripMenuItem.Image");
            deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            deletarToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.Delete;
            deletarToolStripMenuItem.Size = new Size(184, 22);
            deletarToolStripMenuItem.Text = "Excluir";
            deletarToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarCursoToolStripMenuItem, cadastrarUsuárioToolStripMenuItem1 });
            cadastrarToolStripMenuItem.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(65, 20);
            cadastrarToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastrarCursoToolStripMenuItem
            // 
            cadastrarCursoToolStripMenuItem.Image = (Image)resources.GetObject("cadastrarCursoToolStripMenuItem.Image");
            cadastrarCursoToolStripMenuItem.Name = "cadastrarCursoToolStripMenuItem";
            cadastrarCursoToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            cadastrarCursoToolStripMenuItem.Size = new Size(204, 22);
            cadastrarCursoToolStripMenuItem.Text = "Cadastrar curso";
            cadastrarCursoToolStripMenuItem.Click += cadastrarCursoToolStripMenuItem_Click;
            // 
            // cadastrarUsuárioToolStripMenuItem1
            // 
            cadastrarUsuárioToolStripMenuItem1.Image = (Image)resources.GetObject("cadastrarUsuárioToolStripMenuItem1.Image");
            cadastrarUsuárioToolStripMenuItem1.Name = "cadastrarUsuárioToolStripMenuItem1";
            cadastrarUsuárioToolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.E;
            cadastrarUsuárioToolStripMenuItem1.Size = new Size(204, 22);
            cadastrarUsuárioToolStripMenuItem1.Text = "Cadastrar usuário";
            cadastrarUsuárioToolStripMenuItem1.Click += cadastrarUsuárioToolStripMenuItem1_Click;
            // 
            // controleToolStripMenuItem
            // 
            controleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acessoToolStripMenuItem });
            controleToolStripMenuItem.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point);
            controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            controleToolStripMenuItem.Size = new Size(64, 20);
            controleToolStripMenuItem.Text = "Controle";
            // 
            // acessoToolStripMenuItem
            // 
            acessoToolStripMenuItem.Image = (Image)resources.GetObject("acessoToolStripMenuItem.Image");
            acessoToolStripMenuItem.Name = "acessoToolStripMenuItem";
            acessoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            acessoToolStripMenuItem.Size = new Size(184, 26);
            acessoToolStripMenuItem.Text = "Acesso";
            acessoToolStripMenuItem.Click += acessoToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPesquisar);
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
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(1680, 1050);
            panel1.MinimumSize = new Size(900, 600);
            panel1.Name = "panel1";
            panel1.Size = new Size(1217, 642);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(962, 27);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 37;
            label2.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.BackColor = SystemColors.HighlightText;
            txtPesquisar.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesquisar.Location = new Point(962, 48);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(215, 25);
            txtPesquisar.TabIndex = 36;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            txtPesquisar.KeyPress += txtPesquisar_KeyPress;
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
            gridCurso.Location = new Point(0, 213);
            gridCurso.MaximumSize = new Size(1920, 900);
            gridCurso.Name = "gridCurso";
            gridCurso.ReadOnly = true;
            gridCurso.RowHeadersWidth = 51;
            gridCurso.RowTemplate.Height = 25;
            gridCurso.Size = new Size(1214, 319);
            gridCurso.TabIndex = 17;
            gridCurso.CellClick += gridCurso_CellClick;
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
            ColunaCursoMeta.HeaderText = "Meta de Alunos";
            ColunaCursoMeta.MinimumWidth = 6;
            ColunaCursoMeta.Name = "ColunaCursoMeta";
            ColunaCursoMeta.ReadOnly = true;
            // 
            // ColunaCursoRealizado
            // 
            ColunaCursoRealizado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoRealizado.HeaderText = "Matriculados";
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
            btnSair.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(971, 573);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(96, 30);
            btnSair.TabIndex = 16;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click_1;
            // 
            // cmbHorario
            // 
            cmbHorario.BackColor = SystemColors.HighlightText;
            cmbHorario.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbHorario.FormattingEnabled = true;
            cmbHorario.Items.AddRange(new object[] { "7:30 às 12:00", "8:00 às 12:00", "9:15 às 12:15", "13:30 às 17:30", "14:00 às 17:00", "14:00 às 17:30", "18:00 às 22:30", "19:00 às 22:30" });
            cmbHorario.Location = new Point(962, 110);
            cmbHorario.Name = "cmbHorario";
            cmbHorario.Size = new Size(215, 26);
            cmbHorario.TabIndex = 5;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Bottom;
            btnExportar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportar.Location = new Point(801, 573);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(96, 30);
            btnExportar.TabIndex = 15;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // mtbValor
            // 
            mtbValor.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            mtbValor.Location = new Point(497, 161);
            mtbValor.Mask = "$00,000,00";
            mtbValor.Name = "mtbValor";
            mtbValor.Size = new Size(215, 25);
            mtbValor.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Bottom;
            btnAdicionar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(137, 573);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(96, 30);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // btnLimparCampos
            // 
            btnLimparCampos.Anchor = AnchorStyles.Bottom;
            btnLimparCampos.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimparCampos.Location = new Point(303, 573);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(96, 30);
            btnLimparCampos.TabIndex = 12;
            btnLimparCampos.Text = "Limpar";
            btnLimparCampos.UseVisualStyleBackColor = true;
            btnLimparCampos.Click += btnLimparCampos_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Bottom;
            btnAlterar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.Location = new Point(633, 573);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(96, 30);
            btnAlterar.TabIndex = 14;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom;
            btnExcluir.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(464, 573);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(96, 30);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // Agenda_de_Curso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1217, 642);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1682, 1047);
            MinimumSize = new Size(900, 596);
            Name = "Agenda_de_Curso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AGENDA DE CURSOS";
            FormClosing += Agenda_de_Curso_FormClosing;
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
        private ComboBox cmbHorario;
        private ToolStripMenuItem controleToolStripMenuItem;
        private ToolStripMenuItem acessoToolStripMenuItem;
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
        private Label label2;
        private TextBox txtPesquisar;
    }
}