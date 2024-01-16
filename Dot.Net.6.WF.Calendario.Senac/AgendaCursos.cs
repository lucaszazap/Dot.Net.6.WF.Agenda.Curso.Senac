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
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Dot.Net._6.WF.Calendario.Senac.Migrations;


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
            
            if (string.IsNullOrEmpty(cmbCurso.Text))
            {
                MessageBox.Show("O campo 'Curso' é obrigatório.");
                return;
            }

            
            if (dtpInicio.Value == null || dtpInicio.Value == DateTime.MinValue)
            {
                MessageBox.Show("A 'Data' é obrigatório.");
                return;
            }

            
            if (dtpFim.Value == null || dtpFim.Value == DateTime.MinValue)
            {
                MessageBox.Show("A 'Data' é obrigatório.");
                return;
            }

            if (string.IsNullOrEmpty(txtDias.Text))
            {
                MessageBox.Show("O campo 'Dias' é obrigatório.");
                return;

            }

            if (string.IsNullOrEmpty(cmbHorario.Text))
            {
                MessageBox.Show("O campo 'Horário' é obrigatório.");
                return;
            }

            if (string.IsNullOrEmpty(txtMeta.Text))
            {
                MessageBox.Show("O campo 'Meta' é obrigatório.");
                return;
            }

            if (string.IsNullOrEmpty(txtRealizado.Text))
            {
                MessageBox.Show("O campo 'Realizado' é obrigatório.");
                return;
            }

            if (string.IsNullOrWhiteSpace(mtbValor.Text))
            {
                MessageBox.Show("O campo 'Valor' é obrigatório.");
                return;
            }

            if (string.IsNullOrEmpty(txtTurma.Text))
            {
                MessageBox.Show("O campo 'Turma' é obrigatório.");
                return;
            }

            if (string.IsNullOrEmpty(txtSala.Text))
            {
                MessageBox.Show("O campo 'Sala' é obrigatório.");
                return;
            }

            var nome = cmbCurso.Text;
            var inicio = dtpInicio.Value;
            var fim = dtpFim.Value;
            var meta = txtMeta.Text;
            var dias = txtDias.Text;
            var horario = cmbHorario.Text;
            var realizado = txtRealizado.Text;
            var valor = mtbValor.Text;
            var turma = txtTurma.Text;
            var sala = txtSala.Text;



            using (var bd = new BancoDeDados())
            {
                var turmaExistente = bd.AgendaCursos
            .FirstOrDefault(c => c.Turma == turma && c.Sala == sala);

                if (turmaExistente != null)
                {
                    // Verificar se o curso existente tem o mesmo horário
                    var horarioExistente = bd.AgendaCursos
                        .FirstOrDefault(c => c.Turma == turma && c.Sala == sala && c.Horario == horario);

                    if (horarioExistente != null)
                    {
                        MessageBox.Show("Já existe um curso na mesma turma, sala e horário. Não é possível adicionar.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                    var curso = new AgendaCurso()
                {
                    Nome = cmbCurso.Text,
                    Inicio = dtpInicio.Value.Date,
                    Fim = dtpFim.Value.Date,
                    Dias = txtDias.Text,
                    Horario = cmbHorario.Text,
                    Meta = txtMeta.Text,
                    Realizado = txtRealizado.Text,
                    Valor = mtbValor.Text,
                    Turma = txtTurma.Text,
                    Sala = txtSala.Text,

                };

                bd.Historicos.Add(new Historico
                {
                    Login = Autenticacao.UsuarioAtual?.Login,
                    DataHora = DateTime.Now,
                    Alteracao = "Adição de Curso",
                    Detalhes = $"Adicionado curso: {nome}"
                });

                

                bd.AgendaCursos.Add(curso);
                bd.SaveChanges();

                MessageBox.Show("Curso adicionado com sucesso.",
                "Agenda de Cursos", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

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
                var Curso = bd.AgendaCursos.ToList();

                foreach (var curso in Curso)
                {
                    gridCurso.Rows.Add(
                        curso.Id,
                        curso.Nome,
                        curso.Inicio,
                        curso.Fim,
                        curso.Dias,
                        curso.Horario,
                        curso.Meta,
                        curso.Realizado,
                        curso.Valor,
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
            cmbHorario.Text = String.Empty;
            txtMeta.Text = String.Empty;
            txtRealizado.Text = String.Empty;
            mtbValor.Text = String.Empty;
            txtTurma.Text = String.Empty;
            txtSala.Text = String.Empty;


        }

        private void iExcluir()
        {
            if (!Autenticacao.UsuarioTemPermissaoAdministrador())
            {
                MessageBox.Show("Você não tem permissão para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Por favor, informe o curso antes de tentar excluir.");
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
                            var curso = bd.AgendaCursos.FirstOrDefault(w => w.Id == Convert.ToInt32(txtId.Text));

                            if (curso != null)
                            {
                                AdicionarHistoricoExclusao(bd, curso);

                                bd.AgendaCursos.Remove(curso);
                                bd.SaveChanges();
                                Listar();
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Curso não encontrado. Verifique o curso informado.");
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

        private void AdicionarHistoricoExclusao(BancoDeDados bd, AgendaCurso curso)
        {
            bd.Historicos.Add(new Historico
            {
                Login = Autenticacao.UsuarioAtual?.Login,
                DataHora = DateTime.Now,
                Alteracao = "Exclusão de Curso",
                Detalhes = $"Excluído do curso: {curso.Id}, Nome: {curso.Nome}, Início: {curso.Inicio}, Fim: {curso.Fim}"
                
            });
        }
        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            iExcluir();

        }

        private void Agenda_de_Curso_Load(object sender, EventArgs e)
        {
            CarregarCombos();
            Listar();
        }

        public void CarregarCombos()
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

        private void iAlterar()
        {
            if (!Autenticacao.UsuarioTemPermissaoAdministrador())
            {
                MessageBox.Show("Você não tem permissão para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var bd = new BancoDeDados())
            {

                var curso = bd.AgendaCursos
                    .Where(w => w.Id == Convert.ToInt32(txtId.Text))
                    .FirstOrDefault();

                if (curso != null)
                {
                    string nomeOriginal = curso.Nome;
                    DateTime inicioOriginal = curso.Inicio;
                    DateTime fimOriginal = curso.Fim;
                    string diasOriginal = curso.Dias;
                    string horarioOriginal = curso.Horario;
                    string metaOriginal = curso.Meta;
                    string realizadoOriginal = curso.Realizado;
                    string valorOriginal = curso.Valor;
                    string turmaOriginal = curso.Turma;
                    string salaOriginal = curso.Sala;

                    curso.Nome = cmbCurso.Text;
                    curso.Inicio = dtpInicio.Value.Date;
                    curso.Fim = dtpFim.Value.Date;
                    curso.Dias = txtDias.Text;
                    curso.Horario = cmbHorario.Text;
                    curso.Meta = txtMeta.Text;
                    curso.Realizado = txtRealizado.Text;
                    curso.Valor = Convert.ToString(mtbValor.Text);
                    curso.Turma = txtTurma.Text;
                    curso.Sala = txtSala.Text;

                    AdicionarHistorico(bd, nomeOriginal, curso.Nome, "Nome do Curso");
                    AdicionarHistorico(bd, inicioOriginal.ToString(), curso.Inicio.ToString(), "Data de Início");
                    AdicionarHistorico(bd, fimOriginal.ToString(), curso.Fim.ToString(), "Data de Fim");
                    AdicionarHistorico(bd, diasOriginal, curso.Dias, "Dias");
                    AdicionarHistorico(bd, horarioOriginal, curso.Horario, "Horário");
                    AdicionarHistorico(bd, metaOriginal, curso.Meta, "Meta");
                    AdicionarHistorico(bd, realizadoOriginal, curso.Realizado, "Realizado");
                    AdicionarHistorico(bd, valorOriginal, curso.Valor, "Valor");
                    AdicionarHistorico(bd, turmaOriginal, curso.Turma, "Turma");
                    AdicionarHistorico(bd, salaOriginal, curso.Sala, "Sala");

                    MessageBox.Show("Deseja realmente alterar?", "Agenda de Cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    bd.SaveChanges();
                    Listar();
                    LimparCampos();
                }
            }
        }

        private void AdicionarHistorico(BancoDeDados bd, string valorAntigo, string valorNovo, string nomeCampo)
        {
            if (valorAntigo != valorNovo)
            {
                bd.Historicos.Add(new Historico
                {
                    Login = Autenticacao.UsuarioAtual?.Login,
                    DataHora = DateTime.Now,
                    Alteracao = $"Alteração de {nomeCampo}",
                    Detalhes = $"Valor antigo: {valorAntigo}, Novo valor: {valorNovo}"
                });
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            iAlterar();
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }

            else
            {

                if (e.KeyChar >= '0' && e.KeyChar <= '9')
                {

                    e.Handled = false;

                }

                else
                {

                    MessageBox.Show("Digite apenas números", "Erro: Apenas números", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    e.Handled = true;
                }
            }


        }
        private void LogOut()
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
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
                LogOut();
                this.Close();
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

                var todosCursos = bd.AgendaCursos.ToList();

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage excelPackage = new ExcelPackage())
                {

                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Cursos");

                    worksheet.Cells[1, 1].Value = "ID";
                    worksheet.Cells[1, 2].Value = "Curso";
                    worksheet.Cells[1, 3].Value = "Inicio";
                    worksheet.Cells[1, 4].Value = "Fim";
                    worksheet.Cells[1, 5].Value = "Dias";
                    worksheet.Cells[1, 6].Value = "Horario";
                    worksheet.Cells[1, 7].Value = "Meta";
                    worksheet.Cells[1, 8].Value = "Realizado";
                    worksheet.Cells[1, 9].Value = "Valor";
                    worksheet.Cells[1, 10].Value = "Turma";
                    worksheet.Cells[1, 11].Value = "Sala";

                    int row = 2;
                    foreach (var curso in todosCursos)
                    {
                        worksheet.Cells[row, 1].Value = curso.Id;
                        worksheet.Cells[row, 2].Value = curso.Nome;
                        worksheet.Cells[row, 3].Value = curso.Inicio.ToString("dd-MM-yyyy");
                        worksheet.Cells[row, 4].Value = curso.Fim.ToString("dd-MM-yyyy");
                        worksheet.Cells[row, 5].Value = curso.Dias;
                        worksheet.Cells[row, 6].Value = curso.Horario;
                        worksheet.Cells[row, 7].Value = curso.Meta;
                        worksheet.Cells[row, 8].Value = curso.Realizado;
                        worksheet.Cells[row, 9].Value = curso.Valor;
                        worksheet.Cells[row, 10].Value = curso.Turma;
                        worksheet.Cells[row, 11].Value = curso.Sala;

                        row++;
                    }


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

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iExportar();
        }

        private void gridCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = gridCurso.CurrentRow.Cells[0].Value.ToString();
            cmbCurso.Text = gridCurso.CurrentRow.Cells[1].Value.ToString();
            dtpInicio.Text = gridCurso.CurrentRow.Cells[2].Value.ToString();
            dtpFim.Text = gridCurso.CurrentRow.Cells[3].Value.ToString();
            txtDias.Text = gridCurso.CurrentRow.Cells[4].Value.ToString();
            cmbHorario.Text = gridCurso.CurrentRow.Cells[5].Value.ToString();
            txtMeta.Text = gridCurso.CurrentRow.Cells[6].Value.ToString();
            txtRealizado.Text = gridCurso.CurrentRow.Cells[7].Value.ToString();
            mtbValor.Text = gridCurso.CurrentRow.Cells[8].Value.ToString();
            txtTurma.Text = gridCurso.CurrentRow.Cells[9].Value.ToString();
            txtSala.Text = gridCurso.CurrentRow.Cells[10].Value.ToString();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iExcluir();
        }

        private void TextOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !
                    char.IsLetter(e.KeyChar) && !
                    char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Aceito somente letras.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void cadastrarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCurso cadastroCurso = new CadastroCurso(this);

            cadastroCurso.Show();
            this.Hide();
        }


        private void cadastrarUsuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Autenticacao.UsuarioTemPermissaoAdministrador())
            {
                CadastroUsuario cadastroUsuario = new CadastroUsuario();
                cadastroUsuario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Você não tem acesso administrador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void acessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Autenticacao.UsuarioTemPermissaoAdministrador())
            {
                ControleAcesso controleAcesso = new ControleAcesso();
                controleAcesso.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Você não tem acesso administrador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
    }
}























