namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            groupBox1 = new GroupBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(-4, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(774, 475);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(319, 300);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(129, 23);
            txtSenha.TabIndex = 1;            
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(327, 346);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 28);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click_1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(319, 267);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(129, 23);
            txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(262, 272);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 17;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(271, 305);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 18;
            label2.Text = "Senha:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(766, 475);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 461);
            Controls.Add(groupBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamento de Cursos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSenha;
        private Button btnLogin;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}