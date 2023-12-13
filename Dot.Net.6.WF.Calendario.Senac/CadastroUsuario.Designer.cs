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
            lblID = new TextBox();
            chkAtivo = new CheckBox();
            chkAdministrador = new CheckBox();
            btnSalvarUsuario = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 42);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 78);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome de Login:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 120);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome Completo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 154);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 189);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(140, 189);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(199, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 152);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(140, 115);
            txtNomeCompleto.Margin = new Padding(3, 2, 3, 2);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(199, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // txtNomeLogin
            // 
            txtNomeLogin.Location = new Point(137, 76);
            txtNomeLogin.Margin = new Padding(3, 2, 3, 2);
            txtNomeLogin.Name = "txtNomeLogin";
            txtNomeLogin.Size = new Size(202, 23);
            txtNomeLogin.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.Location = new Point(137, 37);
            lblID.Margin = new Padding(3, 2, 3, 2);
            lblID.Name = "lblID";
            lblID.ReadOnly = true;
            lblID.Size = new Size(59, 23);
            lblID.TabIndex = 7;
            lblID.TextAlign = HorizontalAlignment.Center;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(281, 230);
            chkAtivo.Margin = new Padding(3, 2, 3, 2);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 5;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // chkAdministrador
            // 
            chkAdministrador.AutoSize = true;
            chkAdministrador.Location = new Point(137, 230);
            chkAdministrador.Margin = new Padding(3, 2, 3, 2);
            chkAdministrador.Name = "chkAdministrador";
            chkAdministrador.Size = new Size(102, 19);
            chkAdministrador.TabIndex = 4;
            chkAdministrador.Text = "Administrador";
            chkAdministrador.UseVisualStyleBackColor = true;
            // 
            // btnSalvarUsuario
            // 
            btnSalvarUsuario.Location = new Point(196, 260);
            btnSalvarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnSalvarUsuario.Name = "btnSalvarUsuario";
            btnSalvarUsuario.Size = new Size(82, 22);
            btnSalvarUsuario.TabIndex = 6;
            btnSalvarUsuario.Text = "Salvar";
            btnSalvarUsuario.UseVisualStyleBackColor = true;
            btnSalvarUsuario.Click += btnSalvarUsuario_Click;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(451, 306);
            Controls.Add(btnSalvarUsuario);
            Controls.Add(chkAdministrador);
            Controls.Add(chkAtivo);
            Controls.Add(lblID);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuário";
            Load += FrmCadastroUsuario_Load;
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
        private TextBox lblID;
        private CheckBox chkAtivo;
        private CheckBox chkAdministrador;
        private Button btnSalvarUsuario;
    }
}