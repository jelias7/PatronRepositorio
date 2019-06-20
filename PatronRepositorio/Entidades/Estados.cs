using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Estados
    {
        [Key]
        public int Idestado { get; set; }
        public DateTime Fechainicio { get; set; }
        public DateTime Fechafin { get; set; }
        public string Estado { get; set; }

        public Estados()
        {
            Idestado = 0;
            Fechainicio = DateTime.Now;
            Fechafin = DateTime.Now;
            Estado = string.Empty;
        }
    }
}
