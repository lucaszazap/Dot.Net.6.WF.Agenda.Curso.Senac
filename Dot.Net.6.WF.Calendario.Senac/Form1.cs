using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dot.Net._6.WF.Calendario.Senac
{
    public partial class Agenda_de_Curso : Form
    {
        public Agenda_de_Curso()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Validar se os campos obrigatórios estão preenchidos
            if (string.IsNullOrWhiteSpace(txtCurso.Text) || string.IsNullOrWhiteSpace(txtMes.Text))
            {
                MessageBox.Show("Por favor, preencha os campos obrigatórios: Curso e Mês", "Campos obrigatórios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nome = txtCurso.Text;
            var mes = txtMes.Text;



            using (var bd = new BancoDeDados())
            {
                var curso = new Curso()
                {
                    Nome = nome,
                    Mes = mes,
                };

                bd.Cursos.Add(curso);

                bd.SaveChanges();

                // Atualizar o grid com os cursos após adicionar o novo curso
                gridCurso.DataSource = bd.Cursos.ToList();

                MessageBox.Show("Curso adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

                
              
                {
                    // Tratar exceções específicas ou genéricas
                    MessageBox.Show($"Erro ao adicionar curso: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void iLimpar()
        {
            int numRows = gridCurso.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                try
                {
                    int max = gridCurso.Rows.Count - 1;
                    gridCurso.Rows.Remove(gridCurso.Rows[max]);

                }

                catch (Exception exe)
                {
                    MessageBox.Show("Apagar tudo?" + exe, "Apagar todos os dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            iLimpar();
        }
        private void iDeletar()
        {
            foreach (DataGridViewRow item in this.gridCurso.SelectedRows)
            {
                gridCurso.Rows.RemoveAt(item.Index);
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            iDeletar();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }




        Bitmap bitmap;
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int heigt = gridCurso.Height;
            gridCurso.Height = gridCurso.RowCount * gridCurso.RowTemplate.Height * 2;
            bitmap = new Bitmap(gridCurso.Width, gridCurso.Height);
            gridCurso.DrawToBitmap(bitmap, new Rectangle(0, 0, gridCurso.Width, gridCurso.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        private void iSair()
        {
            DialogResult iSair;
            iSair = MessageBox.Show("Você está prestes a fechar. Tem certeza?", "Agenda de Cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iSair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            iSair();
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            // Valida se a tecla pressionada é um número.
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                // Permite a entrada do caractere.
                e.Handled = false;
            }
            else
            {
                // Exibe uma mensagem de erro.
                MessageBox.Show("Digite apenas números", "Erro: Apenas números", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Bloqueia a entrada do caractere.
                e.Handled = true;
            }
        }

    }
}

