namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class CadastroUsuario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            txtNomeCompleto = new TextBox();
            txtNomeLogin = new TextBox();
            txtID = new TextBox();
            chkAtivo = new CheckBox();
            chkAdministrador = new CheckBox();
            btnAdicionarUsuario = new Button();
            btnListar = new Button();
            btnAlterar = new Button();
            GridConsultarUsuario = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)GridConsultarUsuario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 59);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 111);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 114);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 2;
            label3.Text = "Nome Completo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 167);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(471, 167);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 4;
            label5.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(529, 160);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(227, 27);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(145, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(231, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(529, 107);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(227, 27);
            txtNomeCompleto.TabIndex = 1;
            // 
            // txtNomeLogin
            // 
            txtNomeLogin.Location = new Point(146, 104);
            txtNomeLogin.Name = "txtNomeLogin";
            txtNomeLogin.Size = new Size(230, 27);
            txtNomeLogin.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(146, 52);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(67, 27);
            txtID.TabIndex = 7;
            txtID.TextAlign = HorizontalAlignment.Center;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(146, 209);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(66, 24);
            chkAtivo.TabIndex = 5;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // chkAdministrador
            // 
            chkAdministrador.AutoSize = true;
            chkAdministrador.Location = new Point(251, 209);
            chkAdministrador.Name = "chkAdministrador";
            chkAdministrador.Size = new Size(126, 24);
            chkAdministrador.TabIndex = 4;
            chkAdministrador.Text = "Administrador";
            chkAdministrador.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarUsuario
            // 
            btnAdicionarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionarUsuario.Location = new Point(59, 716);
            btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            btnAdicionarUsuario.Size = new Size(91, 39);
            btnAdicionarUsuario.TabIndex = 6;
            btnAdicionarUsuario.Text = "Adicionar";
            btnAdicionarUsuario.UseVisualStyleBackColor = true;
            btnAdicionarUsuario.Click += btnSalvarUsuario_Click;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnListar.Location = new Point(486, 716);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(110, 39);
            btnListar.TabIndex = 11;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.Location = new Point(253, 716);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(115, 39);
            btnAlterar.TabIndex = 10;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // GridConsultarUsuario
            // 
            GridConsultarUsuario.AllowUserToAddRows = false;
            GridConsultarUsuario.AllowUserToDeleteRows = false;
            GridConsultarUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridConsultarUsuario.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            GridConsultarUsuario.Location = new Point(10, 255);
            GridConsultarUsuario.Name = "GridConsultarUsuario";
            GridConsultarUsuario.ReadOnly = true;
            GridConsultarUsuario.RowHeadersWidth = 51;
            GridConsultarUsuario.RowTemplate.Height = 29;
            GridConsultarUsuario.Size = new Size(843, 417);
            GridConsultarUsuario.TabIndex = 8;
            GridConsultarUsuario.CellContentClick += GridConsultarUsuario_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "#";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 47;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Usuário";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Nome Completo";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "E-mail";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Senha";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Administrador";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Ativo";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(693, 716);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 39);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(865, 824);
            Controls.Add(btnExcluir);
            Controls.Add(btnListar);
            Controls.Add(btnAlterar);
            Controls.Add(GridConsultarUsuario);
            Controls.Add(btnAdicionarUsuario);
            Controls.Add(chkAdministrador);
            Controls.Add(chkAtivo);
            Controls.Add(txtID);
            Controls.Add(txtNomeLogin);
            Controls.Add(txtNomeCompleto);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "CadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuário";
            Load += FrmCadastroUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)GridConsultarUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private TextBox txtNomeCompleto;
        private TextBox txtNomeLogin;
        private TextBox txtID;
        private CheckBox chkAtivo;
        private CheckBox chkAdministrador;
        private Button btnAdicionarUsuario;
        private Button btnListar;
        private Button btnAlterar;
        private DataGridView GridConsultarUsuario;
        private Button btnExcluir;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}