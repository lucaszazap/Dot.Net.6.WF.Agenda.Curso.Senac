namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class ResetarSenha
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
            txtAlterarSenha = new TextBox();
            txtAlterarValidar = new TextBox();
            btnAlterar = new Button();
            SuspendLayout();
            // 
            // txtAlterarSenha
            // 
            txtAlterarSenha.Location = new Point(318, 109);
            txtAlterarSenha.Name = "txtAlterarSenha";
            txtAlterarSenha.Size = new Size(100, 23);
            txtAlterarSenha.TabIndex = 0;
            // 
            // txtAlterarValidar
            // 
            txtAlterarValidar.Location = new Point(318, 197);
            txtAlterarValidar.Name = "txtAlterarValidar";
            txtAlterarValidar.Size = new Size(100, 23);
            txtAlterarValidar.TabIndex = 1;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(330, 264);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 2;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // ResetarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAlterar);
            Controls.Add(txtAlterarValidar);
            Controls.Add(txtAlterarSenha);
            Name = "ResetarSenha";
            Text = "ResetarSenha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAlterarSenha;
        private TextBox txtAlterarValidar;
        private Button btnAlterar;
    }
}