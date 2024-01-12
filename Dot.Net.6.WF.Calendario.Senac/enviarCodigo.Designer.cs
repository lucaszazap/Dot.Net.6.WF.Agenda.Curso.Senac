namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class enviarCodigo
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
            txtEmail = new TextBox();
            btnEnviarCodigo = new Button();
            txtValidar = new TextBox();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(248, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 23);
            txtEmail.TabIndex = 0;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.Location = new Point(387, 153);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(75, 23);
            btnEnviarCodigo.TabIndex = 1;
            btnEnviarCodigo.Text = "Enviar";
            btnEnviarCodigo.UseVisualStyleBackColor = true;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // txtValidar
            // 
            txtValidar.Location = new Point(248, 208);
            txtValidar.Name = "txtValidar";
            txtValidar.Size = new Size(214, 23);
            txtValidar.TabIndex = 2;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(387, 237);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // enviarCodigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValidar);
            Controls.Add(txtValidar);
            Controls.Add(btnEnviarCodigo);
            Controls.Add(txtEmail);
            Name = "enviarCodigo";
            Text = "enviarCodigo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Button btnEnviarCodigo;
        private TextBox txtValidar;
        private Button btnValidar;
    }
}