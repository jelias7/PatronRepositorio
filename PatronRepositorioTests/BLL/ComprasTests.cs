using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class ComprasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Compras c = new Compras();
            c.Idcompra = 1;
            c.Idusuario = 1;
            c.Fechacompra = DateTime.Now;
            c.Idproveedor = 1;
            c.Idtipocomprobante = 1;
            c.Costocomprobante = 1;
            RepositorioBase<Compras> repositorio = new RepositorioBase<Compras>();
            bool paso = false;
            paso = repositorio.Guardar(c);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Compras> repositorio = new RepositorioBase<Compras>();
            bool paso = false;
            Compras c = repositorio.Buscar(1);
            c.Idproveedor = 10;
            paso = repositorio.Modificar(c);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Compras> repositorio = new RepositorioBase<Compras>();
            Compras c = repositorio.Buscar(1);
            Assert.IsNotNull(c);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Compras> repositorio = new RepositorioBase<Compras>();
            List<Compras> lista = new List<Compras>();
            lista = repositorio.GetList(c => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Compras> repositorio = new RepositorioBase<Compras>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
