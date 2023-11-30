using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
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
        private void iAdicionar()

        {
            var nome = txtCurso.Text;
            var mes = txtMes.Text;
            var inicio = dtpInicio.Value.Date;
            var fim = dtpFim.Value.Date;
            var dias = txtDias.Text;
            var meta = txtMeta.Text;
            var realizado = txtRealizado.Text;
            var turno = txtTurno.Text;
            decimal.TryParse(txtValor.Text, out var valor);
            var horario = txtHorario.Text;
            var turma = txtTurma.Text;
            var sala = txtSala.Text;



            using (var bd = new BancoDeDados())
            {
                var curso = new Curso()
                {
                    Nome = nome,
                    Mes = mes,
                    Inicio = inicio,
                    Fim = fim,
                    Dias = dias,
                    Meta = meta,
                    Realizado = realizado,
                    Turno = turno,
                    Valor = valor,
                    Horario = horario,
                    Turma = turma,
                    Sala = sala,

                };


                // banco de dados Adicionar
                bd.Cursos.Add(curso);


                // salva as alterações no banco
                bd.SaveChanges();
                LimparCampos();
            }


        }


        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            iAdicionar();
        }

        private void LimparCampos()
        {
            txtId.Text = String.Empty;
            txtCurso.Text = String.Empty;
            txtMes.Text = String.Empty;
            dtpInicio.Text = String.Empty;
            dtpFim.Text = String.Empty;
            txtDias.Text = String.Empty;
            txtMeta.Text = String.Empty;
            txtRealizado.Text = String.Empty;
            txtTurno.Text = String.Empty;
            txtValor.Text = String.Empty;
            txtHorario.Text = String.Empty;
            txtTurma.Text = String.Empty;
            txtSala.Text = String.Empty;
            txtCurso.Focus();

        }

        private void CarregarGrid()
        {
            using (var bd = new BancoDeDados())
            {
                bd.SaveChanges();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            iLimpar();
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

                using (var bd = new BancoDeDados())
                {
                    var curso = bd.Cursos.Where(w => w.Id
                    == Convert.ToInt32(txtId.Text))
                        .First();

                    bd.Cursos.Remove(curso);
                    bd.SaveChanges();
                    Listar();
                    LimparCampos();


                }

            }


        }


        private void iDeletar()
        {
            foreach (DataGridViewRow item in this.gridCurso.SelectedRows)
            {
                gridCurso.Rows.RemoveAt(item.Index);
            }
        }
        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            iDeletar();
        }





        Bitmap bitmap;



        private void iSair()
        {
            DialogResult iSair;
            iSair = MessageBox.Show("Você está prestes a fechar. Tem certeza?", "Agenda de Cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iSair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnSair_Click_1(object sender, EventArgs e)
        {
            iSair();
        }

        private void Agenda_de_Curso_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var bd = new BancoDeDados())
            {

                var curso = bd.Cursos
                    .Where(w => w.Id == Convert.ToInt32(txtCurso.Text))
                    .First();

                curso.Nome = txtCurso.Text;
                curso.Mes = txtMes.Text;
                curso.Inicio = dtpInicio.MinDate.Date;
                curso.Fim = dtpFim.MaxDate.Date;
                curso.Dias = txtDias.Text;
                curso.Meta = txtMeta.Text;
                curso.Realizado = txtRealizado.Text;
                curso.Turno = txtTurno.Text;
                curso.Valor = Convert.ToDecimal(txtValor.Text);
                curso.Horario = txtHorario.Text;
                curso.Turma = txtTurma.Text;
                curso.Sala = txtSala.Text;



                // SALVA AS ALTERAÇÕES
                bd.SaveChanges();
                LimparCampos();
            }
        }

        private void gridCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // obtendo a linha atual que foi clicado e obtendo a celula (na posição)

            txtCurso.Text = gridCurso.CurrentRow.Cells[1].Value.ToString();
            txtMes.Text = gridCurso.CurrentRow.Cells[2].Value.ToString();
            dtpInicio.Text = gridCurso.CurrentRow.Cells[3].Value.ToString();
            dtpFim.Text = gridCurso.CurrentRow.Cells[4].Value.ToString();
            txtDias.Text = gridCurso.CurrentRow.Cells[5].Value.ToString();
            txtMeta.Text = gridCurso.CurrentRow.Cells[6].Value.ToString();
            txtRealizado.Text = gridCurso.CurrentRow.Cells[7].Value.ToString();
            txtTurno.Text = gridCurso.CurrentRow.Cells[8].Value.ToString();
            txtValor.Text = gridCurso.CurrentRow.Cells[9].Value.ToString();
            txtHorario.Text = gridCurso.CurrentRow.Cells[10].Value.ToString();
            txtTurma.Text = gridCurso.CurrentRow.Cells[11].Value.ToString();
            txtSala.Text = gridCurso.CurrentRow.Cells[12].Value.ToString();

        }
        private void iImprimir()
        {
            int heigt = gridCurso.Height;
            gridCurso.Height = gridCurso.RowCount * gridCurso.RowTemplate.Height * 2;
            bitmap = new Bitmap(gridCurso.Width, gridCurso.Height);
            gridCurso.DrawToBitmap(bitmap, new Rectangle(0, 0, gridCurso.Width, gridCurso.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            iImprimir();
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

        private void Listar()
        {
            gridCurso.Rows.Clear();

            //  using (var bd = new BancoDeDados())
            //  {
            //   var cursos = new bd.Cursos.ToList();

            //   foreach (var curso in cursos)
            //   {

            //    gridCurso.Rows.Add(gridCurso.Rows.Count + 1,
            //    curso.Nome,
            //    curso.Mes,
            //    curso.Inicio,
            //    curso.Fim,
            //   curso.Dias,
            //   curso.Meta,
            //    curso.Realizado,
            //    curso.Turno,
            //    curso.Valor,
            //   curso.Horario,
            //   curso.Turma,
            //   curso.Sala);




            // }


            //   }
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iAdicionar();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iImprimir();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iSair();
        }
    }


}



