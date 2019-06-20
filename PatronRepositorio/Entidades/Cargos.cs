using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Cargos
    {
        [Key]
        public int IdCargo { get; set; }
        public string Nombrecargo { get; set; }
        public int Idestado { get; set; }

        public Cargos()
        {
            IdCargo = 0;
            Nombrecargo = string.Empty;
            Idestado = 0;

        }
    }
}
