using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class ImagenesTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Imagenes i = new Imagenes();
            i.Idimagen = 1;
            i.Rutaimagen = "lolo";

            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            bool paso = false;
            paso = repositorio.Guardar(i);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            bool paso = false;
            Imagenes i = repositorio.Buscar(1);
            i.Rutaimagen = "xlxlx";
            paso = repositorio.Modificar(i);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            Imagenes i = repositorio.Buscar(1);
            Assert.IsNotNull(i);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            List<Imagenes> lista = new List<Imagenes>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
