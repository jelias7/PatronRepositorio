using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class ProductosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Productos p = new Productos();

            p.Idproducto = 1;
            p.Nombre = "Juan";
            p.Descripcion = "lololo";
            p.Fechafabricacion = DateTime.Now;
            p.Costocompra = 2;
            p.Stock = 10;
            p.Idunidadmedida = 1;
            p.Idimagen = 1;
            p.Idcategoria = 1;
            p.Idmarca = 1;
            p.Idmodelo = 1;

            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            bool paso = false;
            paso = repositorio.Guardar(p);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            bool paso = false;
            Productos p = repositorio.Buscar(1);
            p.Nombre = "Jose";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos p = repositorio.Buscar(1);
            Assert.IsNotNull(p);
        }


        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            List<Productos> lista = new List<Productos>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
