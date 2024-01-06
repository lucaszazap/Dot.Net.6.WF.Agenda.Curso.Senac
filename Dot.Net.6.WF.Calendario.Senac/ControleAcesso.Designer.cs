namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class ControleAcesso
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
            btnSair = new Button();
            GridControleAcesso = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridControleAcesso).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(GridControleAcesso);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 397);
            panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(252, 325);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(80, 38);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // GridControleAcesso
            // 
            GridControleAcesso.AllowUserToAddRows = false;
            GridControleAcesso.AllowUserToDeleteRows = false;
            GridControleAcesso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridControleAcesso.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            GridControleAcesso.Location = new Point(0, 3);
            GridControleAcesso.Name = "GridControleAcesso";
            GridControleAcesso.ReadOnly = true;
            GridControleAcesso.RowTemplate.Height = 25;
            GridControleAcesso.Size = new Size(636, 293);
            GridControleAcesso.TabIndex = 1;
            
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 39;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Usuário";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // ControleAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(638, 397);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ControleAcesso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ControleAcesso";
            
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridControleAcesso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView GridControleAcesso;
        private Button btnSair;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}