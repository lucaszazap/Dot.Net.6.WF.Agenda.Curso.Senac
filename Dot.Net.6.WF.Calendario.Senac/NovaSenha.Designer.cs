namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class NovaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaSenha));
            panel1 = new Panel();
            txtConfirmarSenha = new TextBox();
            btnCancelar = new Button();
            btnMudarSenha = new Button();
            txtNovaSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtConfirmarSenha);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnMudarSenha);
            panel1.Controls.Add(txtNovaSenha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 605);
            panel1.TabIndex = 0;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Anchor = AnchorStyles.None;
            txtConfirmarSenha.BackColor = Color.White;
            txtConfirmarSenha.Location = new Point(179, 399);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '•';
            txtConfirmarSenha.Size = new Size(280, 28);
            txtConfirmarSenha.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonHighlight;
            btnCancelar.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.Desktop;
            btnCancelar.Location = new Point(179, 448);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 38);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnMudarSenha
            // 
            btnMudarSenha.BackColor = SystemColors.ButtonHighlight;
            btnMudarSenha.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMudarSenha.ForeColor = SystemColors.Desktop;
            btnMudarSenha.Location = new Point(361, 448);
            btnMudarSenha.Name = "btnMudarSenha";
            btnMudarSenha.Size = new Size(98, 38);
            btnMudarSenha.TabIndex = 4;
            btnMudarSenha.Text = "Mudar";
            btnMudarSenha.UseVisualStyleBackColor = false;
            btnMudarSenha.Click += btnMudarSenha_Click;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Anchor = AnchorStyles.None;
            txtNovaSenha.BackColor = Color.White;
            txtNovaSenha.Location = new Point(179, 335);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PasswordChar = '•';
            txtNovaSenha.Size = new Size(280, 28);
            txtNovaSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(179, 310);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 0;
            label1.Text = "Nova senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(179, 374);
            label2.Name = "label2";
            label2.Size = new Size(190, 22);
            label2.TabIndex = 0;
            label2.Text = "Confirmar nova senha:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(164, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // NovaSenha
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(700, 605);
            Controls.Add(panel1);
            Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NovaSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In | Redefinir Senha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dtpDataNascimento;
        private Button btnCancelar;
        private Button btnMudarSenha;
        private TextBox txtNovaSenha;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtConfirmarSenha;
    }
}