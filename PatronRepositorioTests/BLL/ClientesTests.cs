using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class ClientesTests
    {
        [TestMethod]
        public void GuardarTest()
        {
            Clientes c = new Clientes();
            c.Idcliente = 1;
            c.Nombre = "Juan";
            c.Direccion = "LOLO";

            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            bool paso = false;
            paso = repositorio.Guardar(c);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            bool paso = false;
            Clientes c = repositorio.Buscar(1);
            c.Nombre = "Jose";
            paso = repositorio.Modificar(c);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes c = repositorio.Buscar(1);
            Assert.IsNotNull(c);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            List<Clientes> lista = new List<Clientes>();
            lista = repositorio.GetList(c => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
