using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class MarcasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Marcas m = new Marcas();
            m.Idmarca = 1;
            m.Nombremarca = "Juan";

            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            bool paso = false;
            paso = repositorio.Guardar(m);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            bool paso = false;
            Marcas m = repositorio.Buscar(1);
            m.Nombremarca = "Elias";
            paso = repositorio.Modificar(m);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            Marcas m = repositorio.Buscar(1);
            Assert.IsNotNull(m);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            List<Marcas> lista = new List<Marcas>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
