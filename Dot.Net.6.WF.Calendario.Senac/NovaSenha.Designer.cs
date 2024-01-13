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
            btnCancelar = new Button();
            pictureBox3 = new PictureBox();
            btnMudarSenha = new Button();
            txtNovaSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtConfirmarSenha = new TextBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtConfirmarSenha);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnMudarSenha);
            panel1.Controls.Add(txtNovaSenha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 470);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonHighlight;
            btnCancelar.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.FromArgb(255, 128, 0);
            btnCancelar.Location = new Point(139, 366);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 28);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(87, 261);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // btnMudarSenha
            // 
            btnMudarSenha.BackColor = SystemColors.ButtonHighlight;
            btnMudarSenha.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMudarSenha.ForeColor = Color.FromArgb(255, 128, 0);
            btnMudarSenha.Location = new Point(260, 366);
            btnMudarSenha.Name = "btnMudarSenha";
            btnMudarSenha.Size = new Size(84, 28);
            btnMudarSenha.TabIndex = 4;
            btnMudarSenha.Text = "Mudar";
            btnMudarSenha.UseVisualStyleBackColor = false;
            btnMudarSenha.Click += btnMudarSenha_Click;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Anchor = AnchorStyles.None;
            txtNovaSenha.BackColor = Color.White;
            txtNovaSenha.Location = new Point(117, 261);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(264, 24);
            txtNovaSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Menu;
            label1.Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(117, 241);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 0;
            label1.Text = "Nova senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Menu;
            label2.Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(117, 290);
            label2.Name = "label2";
            label2.Size = new Size(148, 17);
            label2.TabIndex = 0;
            label2.Text = "Confirmar nova senha:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(117, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Anchor = AnchorStyles.None;
            txtConfirmarSenha.BackColor = Color.White;
            txtConfirmarSenha.Location = new Point(117, 310);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(264, 24);
            txtConfirmarSenha.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(87, 310);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // NovaSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(497, 470);
            Controls.Add(panel1);
            Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NovaSenha";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Log In | Redefinir Senha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dtpDataNascimento;
        private Button btnCancelar;
        private PictureBox pictureBox3;
        private Button btnMudarSenha;
        private TextBox txtNovaSenha;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtConfirmarSenha;
        private PictureBox pictureBox2;
    }
}