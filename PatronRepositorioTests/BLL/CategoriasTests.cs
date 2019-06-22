using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class CategoriasTests
    {
        [TestMethod]
        public void GuardarTest()
        {
            Categorias c = new Categorias();
            c.Idcategoria = 1;
            c.Nombrecategoria = "Jose";
            c.Descripcion = "XXXXX";
            RepositorioBase<Categorias> repositoriobase = new RepositorioBase<Categorias>();
            bool paso = false;
            paso = repositoriobase.Guardar(c);
            Assert.AreEqual(true, paso);
        }
        [TestMethod]
        public void ModificarTest()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            bool paso = false;
            Categorias c = repositorio.Buscar(1);
            c.Nombrecategoria = "lol";
            paso = repositorio.Modificar(c);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            Categorias c = repositorio.Buscar(1);
            Assert.IsNotNull(c);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            List<Categorias> lista = new List<Categorias>();
            lista = repositorio.GetList(c => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod]
        public void EliminarTest()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
