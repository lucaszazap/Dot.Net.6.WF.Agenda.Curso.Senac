using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dot.Net._6.WF.Calendario.Senac
{

    public partial class CadastroCurso : Form
    {
        private Agenda_de_Curso agenda_De_Curso;

        public CadastroCurso(Agenda_de_Curso agenda_De_Curso)
        {

            InitializeComponent();
            agenda_De_Curso = agenda_De_Curso;
            txtCadastroCurso.Focus();

        }

        private void iCadastrar()
        {
            {
                Agenda_de_Curso agenda_De_Curso = new Agenda_de_Curso();
                agenda_De_Curso.CarregarCombos();

                var nome = txtCadastroCurso.Text;

                using (var bd = new BancoDeDados())
                {
                    var curso = new Curso()
                    {
                        Nome = nome,
                    };

                    bd.Cursos.Add(curso);

                    bd.SaveChanges();

                    agenda_De_Curso.CarregarCombos();


                    MessageBox.Show("Curso adicionado com sucesso.",
                    "Cadastro de Curso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    Listar();
                }

            }
        }


        private void btnCadastrar_Click(object sender, EventArgs e)

        {
            iCadastrar();


        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Deseja realmente cancelar?",
             "Alerta",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Cadastramento_de_Cursos_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void txtCadastroCurso_Click(object sender, EventArgs e)
        {

        }
        private void Listar()
        {
            GridViewCadastroCurso.Rows.Clear();

            using (var bd = new BancoDeDados())
            {
                var Curso = bd.Cursos.ToList();

                foreach (var curso in Curso)
                {
                    GridViewCadastroCurso.Rows.Add(
                        curso.Id,
                        curso.Nome);
                }

            }
        }


        private void GridViewCadastroCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtCadastroCurso.Text = GridViewCadastroCurso.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCadastroCurso.Text))
            {
                MessageBox.Show("Deve selecionar o usuário que deseja excluir.");
                return;

            }
            else
            {

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                using (var bd = new BancoDeDados())
                {
                    var usuario = bd.Usuarios.Where(w => w.ID == Convert.ToInt32(txtCadastroCurso.Text)).First();

                    bd.Usuarios.Remove(usuario);
                    bd.SaveChanges();
                    Listar();


                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

