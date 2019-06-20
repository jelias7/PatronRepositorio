using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Unidadmedidas
    {
        [Key]
        public int Idunidadmedida { get; set; }
        public string Nombreunidad { get; set; }

        public Unidadmedidas()
        {
            Idunidadmedida = 0;
            Nombreunidad = string.Empty;
        }
    }
}
