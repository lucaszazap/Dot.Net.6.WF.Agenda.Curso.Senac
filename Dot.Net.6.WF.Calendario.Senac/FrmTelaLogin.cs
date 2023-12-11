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
    public partial class FrmTelaLogin : Form
    {


        public FrmTelaLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
            txtSenha.PasswordChar = '*';


        }




        private void button1_Click_1()
        {
            string nomeUsuario = "admin";
            string senha = "senha";

            if (txtUsuario.Text == nomeUsuario & txtSenha.Text == senha)
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
            try
            {
                using (var bd = new BancoDeDadosCadastroUsuario())
                {

                    var adminExistente = bd.CadastroUsuario.FirstOrDefault(u => u.ID.ToString() == "admin");

                    // Se o usuário administrador não existe, crie-o
                    if (adminExistente == null)
                    {
                        var admin = new CadastroUsuario()
                        {
                            Login = "admin",
                            Senha = "senha",  // Lembre-se de tratar senhas de maneira segura em uma aplicação real
                            Administrador = true,
                            Ativo = true,
                        };

                        bd.CadastroUsuario.Add(admin);
                        bd.SaveChanges();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Apenas usuários administradores podem cadastrar novos usuários.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frmUsuarioCadastro = new FrmCadastroUsuario();
            frmUsuarioCadastro.ShowDialog();

        }

        private void consultarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarUsuario frmConsultarUsuario = new FrmConsultarUsuario();
            frmConsultarUsuario.ShowDialog();
        }

       private void FrmTelaLogin_Load(object sender, EventArgs e)
        {
             try
              {
                using (var bd = new BancoDeDadosCadastroUsuario())

               {
                    // Verifica se existe pelo menos um usuário administrador no banco de dados
                    var adminExistente = bd.CadastroUsuario.Any(u => u.Administrador);
    
                    // Se não há administradores, exibe uma mensagem e encerra a aplicação
                     if (!adminExistente)
                      {
                          MessageBox.Show("Não há administradores cadastrados. A aplicação será encerrada.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                      }
}
    }
                  catch (Exception ex)
                   {
                      MessageBox.Show("Erro ao verificar administradores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
}
     }
}












