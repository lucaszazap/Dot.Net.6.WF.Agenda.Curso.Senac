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

namespace Dot.Net._6.WF.Calendario.Senac
{
    public partial class TelaLogin : Form
    {
        public static Usuario UsuarioLogado { get; private set; }
        public TelaLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
            txtSenha.PasswordChar = '*';


        }

        private void button1_Click_1()
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            using (var bd = new BancoDeDados())
            {

                if (Autenticacao.AutenticarUsuario(usuario, senha))
                {
                    UsuarioLogado = bd.Usuarios.FirstOrDefault(u => u.Login == usuario);

                    //MessageBox.Show("Login bem-sucedido", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AbrirFormPrincipal();
                }
                else
                {
                    MessageBox.Show("Falha no login. Verifique suas credenciais.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
        private void AbrirFormPrincipal()
        {
            Agenda_de_Curso agenda_De_Curso = new Agenda_de_Curso();
            agenda_De_Curso.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1_Click_1();
            LimparCampos();

        }


        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                button1_Click_1(this, new EventArgs());
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
        private void LimparCampos()
        {
            txtUsuario.Focus();
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}














