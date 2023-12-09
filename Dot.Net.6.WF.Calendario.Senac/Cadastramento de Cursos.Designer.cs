namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class Cadastramento_de_Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastramento_de_Cursos));
            groupBox1 = new GroupBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            txtCadastramento = new TextBox();
            label = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(txtCadastramento);
            groupBox1.Controls.Add(label);
            groupBox1.Location = new Point(12, 193);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 107);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(269, 68);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(180, 68);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCadastramento
            // 
            txtCadastramento.Location = new Point(180, 32);
            txtCadastramento.Name = "txtCadastramento";
            txtCadastramento.Size = new Size(164, 23);
            txtCadastramento.TabIndex = 2;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(82, 40);
            label.Name = "label";
            label.Size = new Size(92, 15);
            label.TabIndex = 0;
            label.Text = "Cadastrar curso:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Cadastramento_de_Cursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 317);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "Cadastramento_de_Cursos";
            Text = "Cadastramento_de_Cursos";
            Load += Cadastramento_de_Cursos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCadastrar;
        private Button btnCancelar;
        private TextBox txtCadastramento;
        private Label label;
        private PictureBox pictureBox1;
    }
}