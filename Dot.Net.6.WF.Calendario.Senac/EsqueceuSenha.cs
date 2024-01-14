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
    public partial class EsqueceuSenha : Form
    {
        public EsqueceuSenha()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
           string CpfDigitado = txtCpfUsuario.Text;
            DateTime dataNascimento = dtpDataNascimento.Value;

            using ( var bd = new BancoDeDados())
            {
                var usuario = bd.Usuarios.FirstOrDefault(u => u.Cpf == CpfDigitado &&
                u.DataNascimento == dataNascimento);

                if (usuario != null)
                {
                    this.Close();
                    AbrirNovaSenha(usuario);

                   
                }
                else
                {
                    MessageBox.Show("CPF ou data de nascimento inválidos.", "Falha ao alterar.", MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }

        }

        private void AbrirNovaSenha(Usuario usuario)
        {
           NovaSenha novaSenha = new NovaSenha(usuario);
           novaSenha.Show();
        }

        private void TelaLogin()
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar?",
                    "Alerta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                TelaLogin();
                this.Close();
            }
        }
    }
}
