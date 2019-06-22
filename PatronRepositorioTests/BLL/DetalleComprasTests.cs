using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class DetalleComprasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            bool paso = false;
            DetalleCompras d = new DetalleCompras();

            d.Iddetallecompra = 1;
            d.Idcompra = 1;
            d.Idproducto = 1;
            d.Unidades = 10;
            d.Costounidad = 8;
            d.Total = 80;
            paso = repositorio.Guardar(d);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            bool paso = false;
            DetalleCompras d = repositorio.Buscar(1);
            d.Idproducto = 2;
            paso = repositorio.Modificar(d);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            DetalleCompras detalle = repositorio.Buscar(1);
            Assert.IsNotNull(detalle);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            List<DetalleCompras> lista = new List<DetalleCompras>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
