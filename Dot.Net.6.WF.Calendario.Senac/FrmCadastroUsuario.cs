using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dot.Net._6.WF.Calendario.Senac
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            ValidarForm();
        }

        private void ValidarForm()
        {
            if (string.IsNullOrEmpty(txtNomeLogin.Text))
            {
                MessageBox.Show("O campo 'Nome de Login' é obrigatório.");
                txtNomeLogin.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNomeCompleto.Text))
            {
                MessageBox.Show("O campo 'Nome Completo' é obrigatório.");
                txtNomeCompleto.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("O campo 'E-mail' é obrigatório.");
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("O campo 'Senha' é obrigatório.");
                txtSenha.Focus();
                return;
            }

            using (var bd = new BancoDeDadosCadastroUsuario())
            {
                // Verifica se o usuário administrador já existe
                var adminExistente = bd.CadastroUsuario.FirstOrDefault(u => u.Login == "admin");

                // Se o usuário administrador não existe, crie-o
                if (adminExistente == null)
                {
                    var admin = new CadastroUsuario()
                    {
                        Login = "admin",
                        Senha = "senha",
                        Email = " ",
                        Nome = " ",
                        Administrador = true,
                        Ativo = true,
                    };

                    bd.CadastroUsuario.Add(admin);
                    bd.SaveChanges();
                }

                // verificar o usuário logado como administrador e criar um novo usuário
                var usuarioLogado = bd.CadastroUsuario.FirstOrDefault(u => u.Login == "admin" && u.Senha == "senha");

                if (usuarioLogado != null && usuarioLogado.Administrador)
                {
                    // Cria um novo usuário apenas se o usuário logado for administrador
                    var cadastrousuario = new CadastroUsuario()
                    {
                        Login = txtNomeLogin.Text,
                        Nome = txtNomeCompleto.Text,
                        Email = txtEmail.Text,
                        Senha = txtSenha.Text,
                        Administrador = chkAdministrador.Checked,
                        Ativo = chkAtivo.Checked,
                    };

                    bd.CadastroUsuario.Add(cadastrousuario);
                    bd.SaveChanges();

                    MessageBox.Show("O usuário foi cadastrado com sucesso.");
                    LimparCampos();
                    txtNomeLogin.Focus();
                }
                else
                {
                    MessageBox.Show("Apenas usuários administradores podem cadastrar novos usuários.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LimparCampos()
        {
            txtNomeLogin.Clear();
            txtNomeCompleto.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            chkAdministrador.Checked = false;
            chkAtivo.Checked = false;
        }
    }
}









