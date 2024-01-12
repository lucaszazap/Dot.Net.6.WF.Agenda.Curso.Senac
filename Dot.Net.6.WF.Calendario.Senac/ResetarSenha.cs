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
    public partial class ResetarSenha : Form
    {
        string login = enviarCodigo.de;
        public ResetarSenha()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtAlterarSenha.Text == txtAlterarValidar.Text)
            {

            }
        }
    }
}
