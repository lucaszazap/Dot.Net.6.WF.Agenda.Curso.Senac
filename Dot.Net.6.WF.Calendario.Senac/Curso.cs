using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot.Net._6.WF.Calendario.Senac
{
    public class Curso
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

    }
}

