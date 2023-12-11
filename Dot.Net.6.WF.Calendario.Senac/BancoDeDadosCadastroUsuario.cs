using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dot.Net._6.WF.Calendario.Senac;



namespace Dot.Net._6.WF.Calendario.Senac
{
    public class BancoDeDadosCadastroUsuario : DbContext
    {
      

        public DbSet<CadastroUsuario> CadastroUsuario { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlite("Data Source=cadastrousuario.db");
        }
    }
}
