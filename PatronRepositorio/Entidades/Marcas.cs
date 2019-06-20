using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Marcas
    {
        [Key]
        public int Idmarca { get; set; }
        public string Nombremarca { get; set; }

        public Marcas()
        {
            Idmarca = 0;
            Nombremarca = string.Empty;

        }
    }
}
