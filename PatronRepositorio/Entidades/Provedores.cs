using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Provedores
    {
        [Key]
        public int Idproveedor { get; set; }
        public int Idpersona { get; set; }

        public Provedores()
        {
            Idproveedor = 0;
            Idpersona = 0;
        }
    }
}
