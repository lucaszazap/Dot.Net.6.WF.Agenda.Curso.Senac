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
       

        public CadastroCurso()
        {
            InitializeComponent();
            txtCadastroCurso.Focus();
          
        }

       

        private void btnCadastrar_Click(object sender, EventArgs e)

        {
            Agenda_de_Curso agenda_De_Curso = new Agenda_de_Curso(txtCadastroCurso.Text);
            agenda_De_Curso.Show();
            
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

        }
        private void txtCadastroCurso_Click(object sender, EventArgs e)
        {
         
        }
    }
}
