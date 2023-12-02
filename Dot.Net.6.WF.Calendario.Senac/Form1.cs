using Microsoft.VisualBasic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using OfficeOpenXml;
using System.IO.Pipes;
using System.IO.Pipelines;


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
            if (txtCurso.Text == null)
            {
                MessageBox.Show("O campo 'Nome' é obrigatório.");
                return;
            }

            if (txtMes.Text == null)
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
            var nome = txtCurso.Text;
            var mes = txtMes.Text;
            var inicio = dtpInicio.Value;
            var fim = dtpFim.Value;
            var dias = txtDias.Text;
            var meta = txtMeta.Text;
            var realizado = txtRealizado.Text;
            var turno = txtTurno.Text;
            var valor = Convert.ToDecimal(txtValor.Text);
            var horario = txtHorario.Text;
            var turma = txtTurma.Text;
            var sala = txtSala.Text;



            // Adiciona o curso ao banco de dados
            using (var bd = new BancoDeDados())
            {
                var curso = new Curso()
                {
                    Nome = txtCurso.Text,
                    Mes = txtMes.Text,
                    Inicio = dtpInicio.Value.Date,
                    Fim = dtpFim.Value.Date,
                    Dias = txtMeta.Text,
                    Realizado = txtRealizado.Text,
                    Turno = txtTurno.Text,
                    Valor = decimal.Parse(txtValor.Text),
                    Horario = txtHorario.Text,
                    Turma = txtTurma.Text,
                    Sala = txtSala.Text,

                };


                bd.Cursos.Add(curso);
                bd.SaveChanges();

                MessageBox.Show("Curso adicionado com sucesso.");
                // Limpa os campos
                Listar();
                LimparCampos();
            }

        }


        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            iAdicionar();
        }

        private void Listar()
        {
            gridCurso.Rows.Clear();

            using (var bd = new BancoDeDados())
            {
                var Curso = bd.Cursos.ToList();

                foreach (var curso in Curso)
                {
                    gridCurso.Rows.Add(gridCurso.Rows.Count + 1,
                         curso.Id,
                        curso.Nome,
                        curso.Mes,
                        curso.Inicio,
                        curso.Fim,
                        curso.Dias,
                        curso.Meta,
                        curso.Realizado,
                        curso.Turno,
                        curso.Valor,
                        curso.Horario,
                        curso.Turma,
                        curso.Sala);
                }
            }
        }

        private void LimparCampos()
        {
            lbl.Text = String.Empty;
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




        private void iDeletar()
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Tem certeza que deseja excluir?");
                return;
            }

            using (var bd = new BancoDeDados())
            {
                var curso = bd.Cursos.Where(w => w
                .Id == Convert .ToInt32(txtId.Text)).First();
                       
                bd.Cursos.Remove(curso);
                bd.SaveChanges();
                Listar();
                LimparCampos();
            }
        }
        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            iDeletar();
        }


        private void Agenda_de_Curso_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void iSalvar()
        {
            using (var bd = new BancoDeDados())
            {

                var curso = bd.Cursos
                    .Where(w => w.Id == Convert.ToInt32(txtId.Text))
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
                Listar();
                LimparCampos();
            }




        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            iSalvar();
        }

        private void gridCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // obtendo a linha atual que foi clicado e obtendo a celula (na posição)
            txtId.Text = gridCurso.CurrentRow.Cells[1].Value.ToString();
            txtCurso.Text = gridCurso.CurrentRow.Cells[2].Value.ToString();
            txtMes.Text = gridCurso.CurrentRow.Cells[3].Value.ToString();
            dtpInicio.Text = gridCurso.CurrentRow.Cells[4].Value.ToString();
            dtpFim.Text = gridCurso.CurrentRow.Cells[5].Value.ToString();
            txtDias.Text = gridCurso.CurrentRow.Cells[6].Value.ToString();
            txtMeta.Text = gridCurso.CurrentRow.Cells[7].Value.ToString();
            txtRealizado.Text = gridCurso.CurrentRow.Cells[8].Value.ToString();
            txtTurno.Text = gridCurso.CurrentRow.Cells[9].Value.ToString();
            txtValor.Text = gridCurso.CurrentRow.Cells[10].Value.ToString();
            txtHorario.Text = gridCurso.CurrentRow.Cells[11].Value.ToString();
            txtTurma.Text = gridCurso.CurrentRow.Cells[12].Value.ToString();
            txtSala.Text = gridCurso.CurrentRow.Cells[13].Value.ToString();

        }


        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            // Valida se a tecla pressionada é um número.
            else
            {

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

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iAdicionar();
        }



        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iSair();
        }


        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void iExportar()
        {
            using (var bd = new BancoDeDados())
            {
                // puxa a linha atualmente selecionada no grid
                var cursoSelecionado = bd.Cursos
                    .FirstOrDefault(c => c.Id == Convert.ToInt32(gridCurso.CurrentRow.Cells[0].Value));

                if (cursoSelecionado != null)

                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        // Cria uma planilha
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Curso");

                        // Adiciona cabeçalhos
                        worksheet.Cells[1, 1].Value = "ID";
                        worksheet.Cells[1, 2].Value = "Curso";
                        worksheet.Cells[1, 3].Value = "Mes";
                        worksheet.Cells[1, 4].Value = "Inicio";
                        worksheet.Cells[1, 5].Value = "Fim";
                        worksheet.Cells[1, 6].Value = "Dias";
                        worksheet.Cells[1, 7].Value = "Meta";
                        worksheet.Cells[1, 8].Value = "Realizado";
                        worksheet.Cells[1, 9].Value = "Turno";
                        worksheet.Cells[1, 10].Value = "Valor";
                        worksheet.Cells[1, 11].Value = "Horario";
                        worksheet.Cells[1, 12].Value = "Turma";
                        worksheet.Cells[1, 13].Value = "Sala";

                        // Preenche os dados
                        int row = 2;
                        worksheet.Cells[row, 1].Value = cursoSelecionado.Id;
                        worksheet.Cells[row, 2].Value = cursoSelecionado.Nome;
                        worksheet.Cells[row, 3].Value = cursoSelecionado.Mes;
                        worksheet.Cells[row, 4].Value = cursoSelecionado.Inicio;
                        worksheet.Cells[row, 5].Value = cursoSelecionado.Fim;
                        worksheet.Cells[row, 6].Value = cursoSelecionado.Dias;
                        worksheet.Cells[row, 7].Value = cursoSelecionado.Meta;
                        worksheet.Cells[row, 8].Value = cursoSelecionado.Realizado;
                        worksheet.Cells[row, 9].Value = cursoSelecionado.Turno;
                        worksheet.Cells[row, 10].Value = cursoSelecionado.Valor;
                        worksheet.Cells[row, 11].Value = cursoSelecionado.Horario;
                        worksheet.Cells[row, 12].Value = cursoSelecionado.Turma;
                        worksheet.Cells[row, 13].Value = cursoSelecionado.Sala;

                        // Salva o arquivo Excel
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                        saveFileDialog.FileName = "Agenda de Cursos.xlsx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            excelPackage.SaveAs(new System.IO.FileInfo(saveFileDialog.FileName));
                            MessageBox.Show("Exportação para o Excel concluída com sucesso!");
                        }
                    }


                    bd.SaveChanges();
                    LimparCampos();

                }
            }
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            iExportar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iSalvar();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iExportar();
        }
    }

}

