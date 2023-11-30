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
            txtSenha.PasswordChar = '*';
           
        }
                                  
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nomeUsuario = "admin";
            string senha = "senha123";

            if(txtUsuario.Text == nomeUsuario & txtSenha.Text == senha)
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

       
    }

}



    




