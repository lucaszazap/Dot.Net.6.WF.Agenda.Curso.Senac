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
            string nomeUsuario = "teste";
            string senha = "123";

            using (var bd = new BancoDeDados())
            {
                var usuario = bd.Usuarios.FirstOrDefault(u => u.Login == txtUsuario.Text && u.Senha == txtSenha.Text);

                if (usuario != null)
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
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            button1_Click_1();
            ValidarLogin();

        }

        private void ValidarLogin()
        {
            using (var bd = new BancoDeDados())
            {
                // Verifica se já existe um usuário administrador
                var adminExistente = bd.Usuarios.FirstOrDefault(u => u.Login == "admin");

                // Exibe uma mensagem informando que o usuário administrador já existe
                if (adminExistente != null)
                {
                    MessageBox.Show("Usuário administrador já existe.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


    }
}














