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
using DocumentFormat.OpenXml.Vml;


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
            if (cmbCurso.Text == null)
            {
                MessageBox.Show("O campo 'Nome' é obrigatório.");
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
            var nome = cmbCurso.Text;
            var inicio = dtpInicio.Value;
            var fim = dtpFim.Value;
            var meta = txtMeta.Text;
            var dias = txtDias.Text;
            var realizado = txtRealizado.Text;
            var turno = cmbTurno.Text;
            var valor = mtbValor.Text;
            var horario = txtHorario.Text;
            var turma = txtTurma.Text;
            var sala = txtSala.Text;



            // Adiciona o curso ao banco de dados
            using (var bd = new BancoDeDados())
            {
                var curso = new AgendamentoCurso()
                {
                    Nome = cmbCurso.Text,
                    Inicio = dtpInicio.Value.Date,
                    Fim = dtpFim.Value.Date,
                    Dias = txtDias.Text,
                    Meta = txtMeta.Text,
                    Realizado = txtRealizado.Text,
                    Turno = cmbTurno.Text,
                    Valor = mtbValor.Text,
                    Horario = txtHorario.Text,
                    Turma = txtTurma.Text,
                    Sala = txtSala.Text,

                };


                bd.AgendamentoCursos.Add(curso);
                bd.SaveChanges();

                MessageBox.Show("Curso adicionado com sucesso.",
                    "Agenda de Cursos", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
                var Curso = bd.AgendamentoCursos.ToList();

                foreach (var curso in Curso)
                {
                    gridCurso.Rows.Add(
                        curso.Id,
                        curso.Nome,
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
            txtId.Text = String.Empty;
            cmbCurso.Text = String.Empty;
            dtpInicio.Text = String.Empty;
            dtpFim.Text = String.Empty;
            txtDias.Text = String.Empty;
            txtMeta.Text = String.Empty;
            txtRealizado.Text = String.Empty;
            cmbTurno.Text = String.Empty;
            mtbValor.Text = String.Empty;
            txtHorario.Text = String.Empty;
            txtTurma.Text = String.Empty;
            txtSala.Text = String.Empty;


        }




        private void iDeletar()
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Por favor, informe o ID antes de tentar excluir.");
            }
            else
            {

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (resultado == DialogResult.Yes)
                {

                    using (var bd = new BancoDeDados())
                    {
                        try
                        {
                            var curso = bd.AgendamentoCursos.FirstOrDefault(w => w.Id == Convert.ToInt32(txtId.Text));

                            if (curso != null)
                            {
                                bd.AgendamentoCursos.Remove(curso);
                                bd.SaveChanges();
                                Listar();
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Curso não encontrado. Verifique o ID informado.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            iDeletar();

        }


        private void Agenda_de_Curso_Load(object sender, EventArgs e)
        {
            CarregarCombos();
            Listar();


        }

        private void CarregarCombos()
        {
            using (var bd = new BancoDeDados())
            {
                var cursos = bd.Cursos.ToList();

                cmbCurso.DataSource = cursos;
                cmbCurso.DisplayMember = "Nome";
                cmbCurso.ValueMember = "Id";
                cmbCurso.SelectedIndex = -1;
            }
        }

        private void iSalvar()
        {
            // Obtém os dados do formulário
            string nome = cmbCurso.Text;
            DateTime inicio = dtpInicio.Value.Date;
            DateTime fim = dtpFim.Value.Date;
            string dias = txtDias.Text;
            string meta = txtMeta.Text;
            string realizado = txtRealizado.Text;
            string turno = cmbTurno.Text;
            string valor = Convert.ToString(mtbValor.Text);
            string horario = txtHorario.Text;
            string turma = txtTurma.Text;
            string sala = txtSala.Text;

            using (var bd = new BancoDeDados())
            {
                var curso = bd.AgendamentoCursos
            .Where(w => w.Id == Convert.ToInt32(txtId.Text))
            .First();

                curso.Nome = nome;
                curso.Inicio = inicio;
                curso.Fim = fim;
                curso.Dias = dias;
                curso.Meta = meta;
                curso.Realizado = realizado;
                curso.Turno = turno;
                curso.Valor = valor;
                curso.Horario = horario;
                curso.Turma = turma;
                curso.Sala = sala;



                bd.SaveChanges();

                MessageBox.Show("Deseja alterar?", "Agenda de Cursos", MessageBoxButtons.OKCancel);
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

                    // Permite a entrada do caractere
                    e.Handled = false;

                }


                else
                {
                    // Exibe uma mensagem de erro
                    MessageBox.Show("Digite apenas números", "Erro: Apenas números", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Bloqueia a entrada do caractere
                    e.Handled = true;
                }
            }


        }

        private void iSair()
        {
            DialogResult iSair;
            iSair = MessageBox.Show("Tem certeza que deseja sair?",
                "Agenda de Cursos",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

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
                // Puxa todos os cursos do banco de dados
                var todosCursos = bd.AgendamentoCursos.ToList();

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // Cria uma planilha
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Cursos");

                    // Adiciona cabeçalhos
                    worksheet.Cells[1, 1].Value = "ID";
                    worksheet.Cells[1, 2].Value = "Curso";
                    worksheet.Cells[1, 3].Value = "Inicio";
                    worksheet.Cells[1, 4].Value = "Fim";
                    worksheet.Cells[1, 5].Value = "Dias";
                    worksheet.Cells[1, 6].Value = "Meta";
                    worksheet.Cells[1, 7].Value = "Realizado";
                    worksheet.Cells[1, 8].Value = "Turno";
                    worksheet.Cells[1, 9].Value = "Valor";
                    worksheet.Cells[1, 10].Value = "Horario";
                    worksheet.Cells[1, 11].Value = "Turma";
                    worksheet.Cells[1, 12].Value = "Sala";

                    // Preenche os dados
                    int row = 2;
                    foreach (var curso in todosCursos)
                    {
                        worksheet.Cells[row, 1].Value = curso.Id;
                        worksheet.Cells[row, 2].Value = curso.Nome;
                        worksheet.Cells[row, 3].Value = curso.Inicio.ToString("dd-MM-yyyy");
                        worksheet.Cells[row, 4].Value = curso.Fim.ToString("dd-MM-yyyy");
                        worksheet.Cells[row, 5].Value = curso.Dias;
                        worksheet.Cells[row, 6].Value = curso.Meta;
                        worksheet.Cells[row, 7].Value = curso.Realizado;
                        worksheet.Cells[row, 8].Value = curso.Turno;
                        worksheet.Cells[row, 9].Value = curso.Valor;
                        worksheet.Cells[row, 10].Value = curso.Horario;
                        worksheet.Cells[row, 11].Value = curso.Turma;
                        worksheet.Cells[row, 12].Value = curso.Sala;

                        row++;
                    }

                    // Salva o arquivo Excel
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = "Agenda de Cursos.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        excelPackage.SaveAs(new FileInfo(saveFileDialog.FileName));
                    }
                    MessageBox.Show("Exportado com sucesso.", "Agenda de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }




                bd.SaveChanges();
                LimparCampos();

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

        private void gridCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // obtendo a linha atual que foi clicado e obtendo a celula (na posição)
            txtId.Text = gridCurso.CurrentRow.Cells[0].Value.ToString();
            cmbCurso.Text = gridCurso.CurrentRow.Cells[1].Value.ToString();
            dtpInicio.Text = gridCurso.CurrentRow.Cells[2].Value.ToString();
            dtpFim.Text = gridCurso.CurrentRow.Cells[3].Value.ToString();
            txtDias.Text = gridCurso.CurrentRow.Cells[4].Value.ToString();
            txtMeta.Text = gridCurso.CurrentRow.Cells[5].Value.ToString();
            txtRealizado.Text = gridCurso.CurrentRow.Cells[6].Value.ToString();
            cmbTurno.Text = gridCurso.CurrentRow.Cells[7].Value.ToString();
            mtbValor.Text = gridCurso.CurrentRow.Cells[8].Value.ToString();
            txtHorario.Text = gridCurso.CurrentRow.Cells[9].Value.ToString();
            txtTurma.Text = gridCurso.CurrentRow.Cells[10].Value.ToString();
            txtSala.Text = gridCurso.CurrentRow.Cells[11].Value.ToString();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iDeletar();
        }

        private void TextOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !
                    char.IsLetter(e.KeyChar) && !
                    char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;


                // Exibe uma mensagem de erro.
                MessageBox.Show("Digite apenas texto.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Bloqueia a entrada do caractere.

            }
        }



        private void txtHorario_TextChanged(object sender, EventArgs e)
        {

        }



        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void mtbValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cadastrarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastramento_de_Cursos CadastroCursoForm = new Cadastramento_de_Cursos();
            CadastroCursoForm.ShowDialog();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}






















