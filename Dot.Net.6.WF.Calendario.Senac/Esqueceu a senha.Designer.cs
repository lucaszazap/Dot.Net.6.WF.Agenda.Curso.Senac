namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class Esqueceu_a_senha
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtNovaSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtConfirmarSenha);
            panel1.Controls.Add(txtNovaSenha);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(78, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 295);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 106);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Nova senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 150);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Confirmar senha:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(278, 189);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(148, 189);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(208, 98);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(100, 23);
            txtNovaSenha.TabIndex = 4;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(208, 142);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(100, 23);
            txtConfirmarSenha.TabIndex = 5;
            // 
            // Esqueceu_a_senha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 385);
            Controls.Add(panel1);
            Name = "Esqueceu_a_senha";
            Text = "Esqueceu_a_senha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtConfirmarSenha;
        private TextBox txtNovaSenha;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label label2;
        private Label label1;
    }
}