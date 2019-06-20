using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Imagenes
    {
        [Key]

        public int Idimagen { get; set; }
        public string Rutaimagen { get; set; }

        public Imagenes()
        {
            Idimagen = 0;
            Rutaimagen = string.Empty;

        }
    }
}
