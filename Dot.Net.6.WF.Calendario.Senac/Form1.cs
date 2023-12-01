using Microsoft.VisualBasic;
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
            if (string.IsNullOrEmpty(txtCurso.Text))
            {
                MessageBox.Show("O campo 'Nome' é obrigatório.");
                return;
            }

            if (string.IsNullOrEmpty(txtMes.Text))
            {
                MessageBox.Show("O campo 'Mês' é obrigatório.");
                return;
            }

            if (dtpInicio.Value == null)
            {
                MessageBox.Show("O campo 'Início' é obrigatório.");
                return;
            }

            if (dtpFim.Value == null)
            {
                MessageBox.Show("O campo 'Fim' é obrigatório.");
                return;
            }

            int n = gridCurso.Rows.Add();

            gridCurso.Rows[n].Cells[0].Value = txtId.Text;
            gridCurso.Rows[n].Cells[1].Value = txtCurso.Text;
            gridCurso.Rows[n].Cells[2].Value = txtMes.Text;
            gridCurso.Rows[n].Cells[3].Value = dtpInicio.Text;
            gridCurso.Rows[n].Cells[4].Value = dtpFim.Text;
            gridCurso.Rows[n].Cells[5].Value = txtDias.Text;
            gridCurso.Rows[n].Cells[6].Value = txtMeta.Text;
            gridCurso.Rows[n].Cells[7].Value = txtRealizado.Text;
            gridCurso.Rows[n].Cells[8].Value = txtTurno.Text;
            gridCurso.Rows[n].Cells[9].Value = txtValor.Text;
            gridCurso.Rows[n].Cells[10].Value = txtHorario.Text;
            gridCurso.Rows[n].Cells[11].Value = txtTurma.Text;
            gridCurso.Rows[n].Cells[12].Value = txtSala.Text;

            //limpando os dados
            txtId.Text = " ";
            txtCurso.Text = " ";
            txtMes.Text = " ";
            dtpInicio.Value = DateTime.Now;
            dtpFim.Value = DateTime.Now;
            txtDias.Text = " ";
            txtMeta.Text = " ";
            txtRealizado.Text = " ";
            txtTurno.Text = " ";
            txtValor.Text = " ";
            txtHorario.Text = " ";
            txtTurma.Text = " ";
            txtSala.Text = " ";

            

            // Adiciona o curso ao banco de dados
             // using (var bd = new BancoDeDados())
           //  {
            //   var curso = new Curso()
            //  {
           // txtCurso.Text,
           //   Mes = txtMes.Text,
           //   Inicio = dtpInicio.Value.Date,
            //  Fim = dtpFim.Value.Date,
            //  Dias = txtMeta.Text,
            //  Realizado = txtRealizado.Text,
            //  Turno = txtTurno.Text,
            //  Valor = decimal.Parse(txtValor.Text),
            //  Horario = txtHorario.Text,
            //  Turma = txtTurma.Text,
            //  Sala = txtSala.Text,

             //  };
        

              // bd.Cursos.Add(curso);
             // bd.SaveChanges();

              // MessageBox.Show("Curso adicionado com sucesso.");

               // LimparCampos();
              // }





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
                    //  Listar();
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
                curso.Inicio = dtpInicio.Value;
                curso.Fim = dtpFim.Value;
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
            txtId.Text = gridCurso.CurrentRow.Cells[0].Value.ToString();
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

        //  private void Listar()
        // {
        // gridCurso.Rows.Clear();

        // using (var bd = new BancoDeDados())
        //{
        //  var cursos = new bd.Cursos.ToList();

        //  foreach (var curso in cursos)
        //   {

        //  gridCurso.Rows.Add(gridCurso.Rows.Count + 1,
        //   curso.Nome,
        //  curso.Mes,
        //   curso.Inicio,
        //  curso.Fim,
        // curso.Dias,
        //  curso.Meta,
        //   curso.Realizado,
        //   curso.Turno,
        //  curso.Valor,
        //  curso.Horario,
        //   curso.Turma,
        //  curso.Sala);




        //  }


        //  }
        // }
        //  private void btnListar_Click(object sender, EventArgs e)
        //  {
        //  Listar();
        //  }

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

        private void gridCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            
            if(n != -1)
            {
                lblInformação.Text = (string)gridCurso.Rows[n].Cells[1].Value ;
            }
        }
    }


}



