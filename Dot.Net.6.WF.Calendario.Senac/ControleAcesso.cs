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
        private Usuario usuarioLogado;
        public ControleAcesso(Usuario usuarioLogado)
        {
            InitializeComponent();
            this.usuarioLogado = usuarioLogado;
            AdicionarUsuarioAoGrid(usuarioLogado);
        }



        private void AdicionarUsuarioAoGrid(Usuario usuario)
        {
            try
            {
                using (var bd = new BancoDeDados())
                {
                    var usuarioAtual = bd.Usuarios.FirstOrDefault(u => u.Login == usuario.Login);

                    if (usuarioAtual != null)
                    {
                        GridControleAcesso.Rows.Add(usuarioAtual.Login, DateTime.Now);
                    }
                    else
                    {
                        MessageBox.Show($"Erro: Usuário '{usuario.Login}' não encontrado no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu uma exceção: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AbrirFormAgenda()
        {
            Agenda_de_Curso agenda_De_Curso = new Agenda_de_Curso();
            agenda_De_Curso.Show();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente cancelar?",
            "Alerta",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                AbrirFormAgenda();
            }
        }

    }
}
