using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string NomeCurso { get; set; }
        public string CargaH { get; set; }
        public string Turno { get; set; }
        public string Descricao { get; set; }
    }
}
