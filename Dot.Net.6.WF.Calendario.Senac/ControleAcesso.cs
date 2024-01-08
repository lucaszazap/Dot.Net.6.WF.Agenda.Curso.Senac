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
    public partial class ControleAcesso : Form
    {

        public ControleAcesso()
        {
            InitializeComponent();
            CarregarHistorico();
        }

        public void CarregarHistorico()
        {
            gridHistorico.Rows.Clear();

            using (var bd = new BancoDeDados())
            {

                var historico = bd.Historicos.ToList();

                foreach (var registro in historico)
                {
                    gridHistorico.Rows.Add(
                        registro.Id,
                        registro.Login,
                        registro.DataHora,
                        registro.Alteracao,
                        registro.Detalhes

                    );
                }
            }
        }


        private void AbrirFormAgenda()
        {
            Agenda_de_Curso agenda_De_Curso = new Agenda_de_Curso();
            agenda_De_Curso.Show();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?",
            "Alerta",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                AbrirFormAgenda();
                this.Close();
            }
        }

        private void gridHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
