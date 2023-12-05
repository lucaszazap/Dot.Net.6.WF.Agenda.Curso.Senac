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

namespace Dot.Net._6.WF.Calendario.Senac
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUsuario.Focus();
            txtSenha.PasswordChar = '*';

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            string nomeUsuario = "admin";
            string senha = "senha";

            if (txtUsuario.Text == nomeUsuario & txtSenha.Text == senha)
            {
                MessageBox.Show("Acesso liberado");
                Agenda_de_Curso formPrincipal = new Agenda_de_Curso();

                // Exiba o formulário principal como um diálogo
                formPrincipal.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Usuario/Senha incorretos");
            }
        }

   

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r' ) {
                button1_Click_1( this, new EventArgs());
            }
        }
    }
}










