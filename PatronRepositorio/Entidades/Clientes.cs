using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Clientes
    {
        [Key]
        public int Idcliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public Clientes()
        {
            Idcliente = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
        }
    }
}
