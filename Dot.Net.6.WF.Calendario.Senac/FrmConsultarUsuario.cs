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

        private void ListarCampo()
        {
        
            using (var bd = new BancoDeDados())
            {
                var CadastroUsuario = bd.Usuarios.ToList();

                foreach (var cadastrousuario in CadastroUsuario)
                {
                    GridConsultarUsuario.Rows.Add(
                        cadastrousuario.Login,
                        cadastrousuario.Nome,
                        cadastrousuario.Email,
                        cadastrousuario.Senha,
                        cadastrousuario.Administrador,
                        cadastrousuario.Ativo);
                }

             
                
            }

            
        }

        private void GridConsultarUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
          
        }

        private void FrmConsultarUsuario_Load(object sender, EventArgs e)
        {
        
           ListarCampo();
        }
    }
}

    

