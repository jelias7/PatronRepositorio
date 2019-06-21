using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.BLL.Tests
{
    [TestClass()]
    public class PersonasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Personas personas = new Personas();

            personas.Idpersona = 1;
            personas.Dni = 1;
            personas.Nombre = "x";
            personas.Materno = "x";
            personas.Paterno = "x";
            personas.FechaNacimiento = DateTime.Now;
            personas.Telefono = "123456";
            personas.Correo = "jajaja@gmail.com";
            personas.Sexo = "M";
            personas.Idimagen = 1;
            personas.Direccion = "jaja";
            personas.Idtipopersona = 1;

            RepositorioBase<Personas> repositorio = new RepositorioBase<Personas>();
            bool paso = false;
            paso = repositorio.Guardar(personas);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Personas> repositorio = new RepositorioBase<Personas>();
            bool paso = false;
            Personas p = repositorio.Buscar(1);
            p.Nombre = "Juan";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsNotNull(db.Buscar(1));

        }
        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsNotNull(db.GetList(p => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}