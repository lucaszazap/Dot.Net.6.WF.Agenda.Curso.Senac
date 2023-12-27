namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class CadastroCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCurso));
            groupBox1 = new GroupBox();
            lblId = new Label();
            textId = new TextBox();
            GridViewCadastroCurso = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            txtCadastroCurso = new TextBox();
            label = new Label();
            btnExcluir = new Button();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewCadastroCurso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(textId);
            groupBox1.Controls.Add(GridViewCadastroCurso);
            groupBox1.Controls.Add(txtCadastroCurso);
            groupBox1.Controls.Add(label);
            groupBox1.Location = new Point(12, 307);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(593, 432);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
       
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(475, 56);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 7;
            lblId.Text = "ID:";
            // 
            // textId
            // 
            textId.Location = new Point(502, 48);
            textId.Name = "textId";
            textId.Size = new Size(25, 23);
            textId.TabIndex = 6;
            // 
            // GridViewCadastroCurso
            // 
            GridViewCadastroCurso.AllowUserToAddRows = false;
            GridViewCadastroCurso.AllowUserToDeleteRows = false;
            GridViewCadastroCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewCadastroCurso.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1 });
            GridViewCadastroCurso.Location = new Point(0, 97);
            GridViewCadastroCurso.Name = "GridViewCadastroCurso";
            GridViewCadastroCurso.ReadOnly = true;
            GridViewCadastroCurso.RowTemplate.Height = 25;
            GridViewCadastroCurso.Size = new Size(587, 317);
            GridViewCadastroCurso.TabIndex = 5;
            GridViewCadastroCurso.CellContentClick += GridViewCadastroCurso_CellContentClick;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Id";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 42;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Curso";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // txtCadastroCurso
            // 
            txtCadastroCurso.Location = new Point(153, 48);
            txtCadastroCurso.Name = "txtCadastroCurso";
            txtCadastroCurso.Size = new Size(316, 23);
            txtCadastroCurso.TabIndex = 2;
            txtCadastroCurso.Click += txtCadastroCurso_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(39, 52);
            label.Name = "label";
            label.Size = new Size(108, 19);
            label.TabIndex = 0;
            label.Text = "Cadastrar curso:";
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(165, 760);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 31);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(324, 755);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 40);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(32, 755);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(76, 40);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(593, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CadastroCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(617, 807);
            Controls.Add(btnExcluir);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Name = "CadastroCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cursos";
            Load += Cadastramento_de_Cursos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewCadastroCurso).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCadastrar;
        private Button btnCancelar;
        private TextBox txtCadastroCurso;
        private Label label;
        private PictureBox pictureBox1;
        private DataGridView GridViewCadastroCurso;
        private Button btnExcluir;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private TextBox textId;
        private Label lblId;
    }
}