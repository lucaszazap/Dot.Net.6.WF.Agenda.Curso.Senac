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
        [Key] public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; } = string.Empty;
        [Required]
        public int Mes { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public string Dias { get; set; } = string.Empty;
        public int Meta { get; set; }
        public string Realizado { get; set; } = string.Empty;
        public string Turno { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public string Horario { get; set; } = string.Empty;
        public string Turma { get; set; } = string.Empty;
        public string Sala { get; set; } = string.Empty;
    }
}

