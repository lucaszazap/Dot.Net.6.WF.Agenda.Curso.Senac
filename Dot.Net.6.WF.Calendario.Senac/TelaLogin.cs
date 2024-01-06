using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Collections.Generic;

namespace Dot.Net._6.WF.Calendario.Senac
{
    public partial class TelaLogin : Form
    {
        public static Usuario UsuarioLogado { get; private set; }
        private bool _podeVerSenha = false;
        public TelaLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
            
            picLoading.Hide();
            btnEntrar.Click += btnEntrar_Click;
            picSenha.Click += PicSenha_Click;

        }

        private void PicSenha_Click(object sender, EventArgs e)
        {
            _podeVerSenha = !_podeVerSenha;

            if (_podeVerSenha)
            {
                picSenha.Image = Properties.Resources.hide;
                txtSenha.PasswordChar = '•';
            }
            else
            {
                picSenha.Image = Properties.Resources.show;
                txtSenha.PasswordChar = '\0';
            }
        }

        private void AbrirFormPrincipal()
        {
            Agenda_de_Curso agenda_De_Curso = new Agenda_de_Curso();
            agenda_De_Curso.Show();
            this.Hide();
        }

        private void BtnEntrar(object sender, EventArgs e)
        {

            LimparCampos();

        }


        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnEntrar_Click(this, new EventArgs());
            }
        }

        private void LimparCampos()
        {
            txtUsuario.Focus();
            txtUsuario.Text = "";
            txtSenha.Text = "";
           

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private async void btnEntrar_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            picLoading.Show();
            await Task.Delay(2000);
            picLoading.Hide();

            using (var bd = new BancoDeDados())
            {

                if (Autenticacao.AutenticarUsuario(usuario, senha))
                {

                    UsuarioLogado = bd.Usuarios.FirstOrDefault(u => u.Login == usuario);

                    MessageBox.Show($"Bem-Vindo: {TelaLogin.UsuarioLogado.Login}", "Senac", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ControleAcesso controleAcesso = new ControleAcesso(UsuarioLogado);


                    AbrirFormPrincipal();
                }
                else
                {
                    MessageBox.Show("Falha no login. Verifique suas credenciais.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Deseja realmente cancelar?",
                "Alerta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            Application.Exit();
        }
    }
}














