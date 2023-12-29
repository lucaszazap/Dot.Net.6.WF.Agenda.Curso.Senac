using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot.Net._6.WF.Calendario.Senac
{
    public static class Autenticacao
    {
         private static Usuario usuarioAtual;

            public static Usuario UsuarioAtual
            {
                get { return usuarioAtual; }
                private set { usuarioAtual = value; }
            }

            public static bool AutenticarUsuario(string nomeUsuario, string senha)
            {
                using (var bd = new BancoDeDados())
                {
             
                    var usuarioEncontrado = bd.Usuarios.FirstOrDefault(u => u.Login == nomeUsuario && u.Senha == senha && u.Ativo);

                   
                    if (usuarioEncontrado != null)
                    {
                        UsuarioAtual = usuarioEncontrado;
                        return true;
                    }
                    else
                    {
                        UsuarioAtual = null;
                        return false; 
                    }
                }
            }


            public static bool UsuarioTemPermissaoAdministrador()
            {
                return UsuarioAtual != null && UsuarioAtual.Administrador;
            }
        }

    }

