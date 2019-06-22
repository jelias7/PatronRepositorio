using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class CargosTests
    {
        [TestMethod]
        public void GuardarTest()
        {
            Cargos c = new Cargos();
            c.IdCargo = 1;
            c.Nombrecargo = "Gerente";
            c.Idestado = 1;

            RepositorioBase<Cargos> repositorio = new RepositorioBase<Cargos>();
            bool paso = false;
            paso = repositorio.Guardar(c);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Cargos> repositorio = new RepositorioBase<Cargos>();
            bool paso = false;
            Cargos c = repositorio.Buscar(1);
            c.Nombrecargo = "Vice Gerente";
            paso = repositorio.Modificar(c);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Cargos> repositoriobase = new RepositorioBase<Cargos>();
            Cargos c = repositoriobase.Buscar(1);
            Assert.IsNotNull(c);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Cargos> repositorio = new RepositorioBase<Cargos>();
            List<Cargos> lista = new List<Cargos>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Cargos> repositoriobase = new RepositorioBase<Cargos>();
            bool paso = false;
            paso = repositoriobase.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
