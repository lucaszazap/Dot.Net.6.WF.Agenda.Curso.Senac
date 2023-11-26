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

        private bool AutenticacaoBemSucedida(string nomeUsuario, string senha)
        {
            // Substitua esta lógica com sua própria autenticação (por exemplo, consultando um banco de dados)
            return (nomeUsuario == "admin" && senha == "senha123");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (AutenticacaoBemSucedida(nomeUsuario, senha))
            {
                // Crie o formulário principal
                Agenda_de_Curso formPrincipal = new Agenda_de_Curso();

                // Exiba o formulário principal como um diálogo
                if (formPrincipal.ShowDialog() == DialogResult.OK)
                {
                    // Aqui você pode adicionar lógica adicional após o fechamento bem-sucedido do formulário principal
                    // Por exemplo, mostrar outra tela, fazer alguma ação, etc.
                    MostrarOutraTela();
                }

                // Esconda a tela de login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login falhou. Verifique suas credenciais.");
            }
        }
        private void MostrarOutraTela()
        {
            // Crie uma instância do novo formulário
           Login formOutraTela = new Login();

            // Exiba o novo formulário
            formOutraTela.ShowDialog();


        }


    }



    

}


