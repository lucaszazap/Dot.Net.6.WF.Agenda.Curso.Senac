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



        private async void btnEntrar_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            picLoading.Show();
            await Task.Delay(1000);
            picLoading.Hide();

            using (var bd = new BancoDeDados())
            {
                if (Autenticacao.AutenticarUsuario(usuario, senha))
                {
                    Usuario usuarioLogado = bd.Usuarios.FirstOrDefault(u => u.Login == usuario);

                    if (usuarioLogado != null)
                    {
                        MessageBox.Show($"Bem-Vindo: {usuarioLogado.Login}", "Senac", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        AbrirFormPrincipal();
                    }

                }
                else
                {
                    MessageBox.Show("Falha no login. Verifique suas credenciais.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}

















