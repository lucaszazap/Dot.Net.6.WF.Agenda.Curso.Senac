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
    public partial class Cadastramento_de_Cursos : Form
    {

        public Cadastramento_de_Cursos()
        {
            InitializeComponent();


            txtCadastramento.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeCurso = txtCadastramento.Text;

            if (txtCadastramento.Text == nomeCurso);
            {
                MessageBox.Show("O campo não pode estar vazio.");

                AgendamentoCurso formPrincipal = new AgendamentoCurso();
               formPrincipal.Nome = nomeCurso;
                this.Hide();

            }

            MessageBox.Show("O curso foi cadastrado com sucesso.");

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Deseja realmente cancelar?",
                "Alerta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            this.Close();
        }

        private void Cadastramento_de_Cursos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
