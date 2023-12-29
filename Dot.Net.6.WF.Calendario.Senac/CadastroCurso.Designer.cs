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
            lblId = new Label();
            txtId = new TextBox();
            txtCadastroCurso = new TextBox();
            label = new Label();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            GridViewCadastroCurso = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            btnAlterar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridViewCadastroCurso).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(712, 255);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 20);
            lblId.TabIndex = 7;
            lblId.Text = "ID:";
            lblId.Visible = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(745, 249);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(28, 27);
            txtId.TabIndex = 6;
            txtId.Visible = false;
            // 
            // txtCadastroCurso
            // 
            txtCadastroCurso.Location = new Point(145, 248);
            txtCadastroCurso.Margin = new Padding(3, 4, 3, 4);
            txtCadastroCurso.Name = "txtCadastroCurso";
            txtCadastroCurso.Size = new Size(361, 27);
            txtCadastroCurso.TabIndex = 2;
            txtCadastroCurso.Click += txtCadastroCurso_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(6, 252);
            label.Name = "label";
            label.Size = new Size(139, 23);
            label.TabIndex = 0;
            label.Text = "Cadastrar curso:";
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(434, 731);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 39);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(49, 731);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(86, 40);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(614, 731);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(86, 40);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(182, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // GridViewCadastroCurso
            // 
            GridViewCadastroCurso.AllowUserToAddRows = false;
            GridViewCadastroCurso.AllowUserToDeleteRows = false;
            GridViewCadastroCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewCadastroCurso.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1 });
            GridViewCadastroCurso.Location = new Point(4, 283);
            GridViewCadastroCurso.Margin = new Padding(3, 4, 3, 4);
            GridViewCadastroCurso.Name = "GridViewCadastroCurso";
            GridViewCadastroCurso.ReadOnly = true;
            GridViewCadastroCurso.RowHeadersWidth = 51;
            GridViewCadastroCurso.RowTemplate.Height = 25;
            GridViewCadastroCurso.Size = new Size(772, 423);
            GridViewCadastroCurso.TabIndex = 5;
            GridViewCadastroCurso.CellClick += GridViewCadastroCurso_CellClick;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "#";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 47;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Curso";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.Location = new Point(247, 732);
            btnAlterar.Margin = new Padding(3, 4, 3, 4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(86, 39);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // CadastroCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(781, 797);
            Controls.Add(btnAlterar);
            Controls.Add(GridViewCadastroCurso);
            Controls.Add(lblId);
            Controls.Add(pictureBox1);
            Controls.Add(txtId);
            Controls.Add(btnExcluir);
            Controls.Add(txtCadastroCurso);
            Controls.Add(label);
            Controls.Add(btnAdicionar);
            Controls.Add(btnSair);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cursos";
            Load += Cadastramento_de_Cursos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridViewCadastroCurso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdicionar;
        private Button btnSair;
        private TextBox txtCadastroCurso;
        private Label label;
        private Button btnExcluir;
        private TextBox txtId;
        private Label lblId;
        private PictureBox pictureBox1;
        private DataGridView GridViewCadastroCurso;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private Button btnAlterar;
    }
}