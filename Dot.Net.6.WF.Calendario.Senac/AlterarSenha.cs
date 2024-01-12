using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot.Net._6.WF.Calendario.Senac
{
    public class AlterarSenha
    {
        [Key]
       public int Id { get; set; }
       public string Login { get; set; }
       public string Senha { get; set; }

    }
}
