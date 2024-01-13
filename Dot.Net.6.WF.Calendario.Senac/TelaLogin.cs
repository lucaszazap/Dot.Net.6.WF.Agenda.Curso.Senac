namespace Dot.Net._6.WF.Calendario.Senac
{
    public partial class TelaLogin : Form
    {

        private bool _podeVerSenha = false;

        public TelaLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
            picLoading.Hide();
            picSenha.Click += PicSenha_Click;

        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            picLoading.Show();
            await Task.Delay(1000);
            picLoading.Hide();

            using (var bd = new BancoDeDados())
            {
                var usuarioExistente = bd.Usuarios.FirstOrDefault(u => u.Login == usuario);

                if (usuarioExistente != null && Autenticacao.AutenticarUsuario(usuario, senha))
                {
                    MessageBox.Show($"Bem-vindo: {usuarioExistente.Login}", "Senac", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bd.Historicos.Add(new Historico
                    {
                        Login = usuario,
                        DataHora = DateTime.Now,
                        Alteracao = $"Login de {usuarioExistente.Login}",
                        Detalhes = $"Usuário {usuarioExistente.Nome} fez login."
                    });

                    bd.SaveChanges();

                    AbrirFormPrincipal();

                    ControleAcesso controleAcesso = Application.OpenForms.OfType<ControleAcesso>().FirstOrDefault();

                    if (controleAcesso != null)
                    {
                        controleAcesso.CarregarHistorico();
                    }
                }
                else
                {
                    MessageBox.Show("Falha no login. Verifique suas credenciais.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LimparCampos();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar?",
                    "Alerta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void PicSenha_Click(object sender, EventArgs e)
        {
            _podeVerSenha = !_podeVerSenha;

            if (_podeVerSenha)
            {
                picSenha.Image = Properties.Resources.hide4;
                txtSenha.PasswordChar = '•';
            }
            else
            {
                picSenha.Image = Properties.Resources.show4;
                txtSenha.PasswordChar = '\0';
            }
        }

        private void AbrirFormPrincipal()
        {
            Agenda_de_Curso agenda_De_Curso = new Agenda_de_Curso();
            agenda_De_Curso.Show();
            this.Hide();
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
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();

        }

        private void TelaLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick ();
            }
        }
    }
}

















