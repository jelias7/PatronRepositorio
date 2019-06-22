using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class ModelosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Modelos m = new Modelos();
            m.Idmodelo = 1;
            m.Nombremodelo = "Ejem";

            RepositorioBase<Modelos> repositorio = new RepositorioBase<Modelos>();
            bool paso = false;
            paso = repositorio.Guardar(m);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Modelos> repositorio = new RepositorioBase<Modelos>();
            bool paso = false;
            Modelos m = repositorio.Buscar(1);
            m.Nombremodelo = "Ejem2";
            paso = repositorio.Modificar(m);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Modelos> repositorio = new RepositorioBase<Modelos>();
            Modelos m = repositorio.Buscar(1);
            Assert.IsNotNull(m);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Modelos> repositorio = new RepositorioBase<Modelos>();
            List<Modelos> lista = new List<Modelos>();
            lista = repositorio.GetList(m => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Modelos> repositorio = new RepositorioBase<Modelos>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
