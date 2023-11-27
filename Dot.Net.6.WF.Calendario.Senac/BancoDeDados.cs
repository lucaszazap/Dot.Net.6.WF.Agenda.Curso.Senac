using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot.Net._6.WF.Calendario.Senac
{
    public class BancoDeDados : DbContext
    {
           public DbSet<Curso> Cursos { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder opt)
            {
                opt.UseSqlite("Data Source=Cursos.db");
            }
        }
    }

