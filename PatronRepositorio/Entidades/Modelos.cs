using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Modelos
    {
        [Key]
        public int Idmodelo { get; set; }
        public string Nombremodelo { get; set; }

        public Modelos()
        {
            this.Idmodelo = 0;
            this.Nombremodelo = string.Empty;

        }
    }
}
