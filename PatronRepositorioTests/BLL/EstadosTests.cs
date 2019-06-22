using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class EstadosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            bool paso = false;
            Estados e = new Estados();
            e.Idestado = 1;
            e.Fechainicio = DateTime.Now;
            e.Fechafin = DateTime.Today;
            e.Estado = "XXXXX";

            paso = repositorio.Guardar(e);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            bool paso = false;
            Estados e = repositorio.Buscar(1);
            e.Estado = "LLLLL";
            paso = repositorio.Modificar(e);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            Estados e = repositorio.Buscar(1);
            Assert.IsNotNull(e);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            List<Estados> lista = new List<Estados>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
