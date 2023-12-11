using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dot.Net._6.WF.Calendario.Senac
{
    public partial class FrmConsultarUsuario : Form
    {
        public FrmConsultarUsuario()
        {
            InitializeComponent();
        }

       
        private void MostrarUsuario()
        {
            using (var bd = new BancoDeDadosCadastroUsuario())
            {
                var usuarios = bd.CadastroUsuario.ToList();
                GridConsultarUsuario.DataSource = usuarios;
            }

        }
                    

        private void ListarCampo()
        {
            

            using (var bd = new BancoDeDadosCadastroUsuario())
            {
                var usuarios = bd.CadastroUsuario.ToList();

                foreach (var usuario in usuarios)
                {
                    GridConsultarUsuario.Rows.Add(
                        usuario.Login,
                        usuario.Nome,
                        usuario.Email,
                        usuario.Senha,
                        usuario.Administrador,
                        usuario.Ativo);
                }
                
            }

            
        }

        private void GridConsultarUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarUsuario();
           ListarCampo();
        }

        private void FrmConsultarUsuario_Load(object sender, EventArgs e)
        {
            MostrarUsuario();
            ListarCampo();
        }
    }
}

    

