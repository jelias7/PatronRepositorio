using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class TipoPersonasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            TipoPersonas t = new TipoPersonas();
            t.IdTipoPersona = 1;
            t.Nombre = "Juan";
            RepositorioBase<TipoPersonas> repositorio = new RepositorioBase<TipoPersonas>();
            bool estado = false;
            estado = repositorio.Guardar(t);
            Assert.AreEqual(true, estado);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<TipoPersonas> repositorio = new RepositorioBase<TipoPersonas>();
            bool paso = false;
            TipoPersonas t = repositorio.Buscar(1);
            t.Nombre = "Elias";
            paso = repositorio.Modificar(t);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<TipoPersonas> repositorio = new RepositorioBase<TipoPersonas>();
            TipoPersonas t = repositorio.Buscar(1);
            Assert.IsNotNull(t);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<TipoPersonas> repositorio = new RepositorioBase<TipoPersonas>();
            List<TipoPersonas> lista = new List<TipoPersonas>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<TipoPersonas> repositorio = new RepositorioBase<TipoPersonas>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }

    }
}
