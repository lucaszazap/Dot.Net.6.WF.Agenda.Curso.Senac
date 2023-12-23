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


        public TelaLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
            txtSenha.PasswordChar = '*';


        }

        private void button1_Click_1()
        {
            string nomeUsuario = "admin";
            string senha = "senha";

            if (txtUsuario.Text == nomeUsuario && txtSenha.Text == senha)


            {

                MessageBox.Show("Acesso liberado", "Agendamento de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Agenda_de_Curso formPrincipal = new Agenda_de_Curso();

                // Exiba o formulário principal como um diálogo
                formPrincipal.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Usuario/Senha incorretos", "Verifique suas credenciais", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsuario.Focus();
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1_Click_1();
            ValidarLogin();

        }

        private void ValidarLogin()
        {
            string nomeUsuarioNovo = txtUsuario.Text;
            string senhaNovo = txtSenha.Text;

            using (var bd = new BancoDeDados())
            {
                var usuarioNovo = bd.Usuarios.FirstOrDefault(u => u.Login == nomeUsuarioNovo && u.Senha == senhaNovo);

                if (usuarioNovo != null)
                {
                    MessageBox.Show("Acesso liberado para novo usuário", "Agendamento de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Agenda_de_Curso formPrincipal = new Agenda_de_Curso();

                    // Exiba o formulário principal como um diálogo
                    formPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    // Se o usuário não existir, crie um novo
                    var novoUsuario = new Usuario()
                    {
                        Login = nomeUsuarioNovo,
                        Senha = senhaNovo,
                        // Adicione outros campos conforme necessário
                    };

                    bd.Usuarios.Add(novoUsuario);
                  //  bd.SaveChanges();

                    MessageBox.Show("Novo usuário criado com sucesso", "Agendamento de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Continua o processo de login para o novo usuário
                    Agenda_de_Curso formPrincipal = new Agenda_de_Curso();
                    formPrincipal.Show();
                    this.Hide();

                }
            }

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

            this.Close();


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














