using PatronRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Cargos> cargos { get; set; }
        public DbSet<Categorias> categorias { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Compras> compras { get; set; }
        public DbSet<DetalleCompras> detallecompras { get; set; }
        public DbSet<DetalleVentas> detalleventas { get; set; }
        public DbSet<Empleados> empleados { get; set; }
        public DbSet<Estados> estados { get; set; }
        public DbSet<Imagenes> imagenes { get; set; }
        public DbSet<Marcas> marcas { get; set; }
        public DbSet<Modelos> modelos { get; set; }
        public DbSet<Permisos> permisos { get; set; }
        public DbSet<Personas> personas { get; set; }
        public DbSet<Productos> productos { get; set; }
        public DbSet<Provedores> provedores { get; set; }
        public DbSet<TipoComprobantes> tipocomprobantes { get; set; }
        public DbSet<TipoPersonas> tipopersonas { get; set; }
        public DbSet<Unidadmedidas> unidadmedidas { get; set; }
        public DbSet<Usuario_has_permiso> Usuario_has_permiso { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<Ventas> ventas { get; set; }
        public Contexto() : base ("ConStr")
        {

        }
    }
}
