using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class DetalleVentasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            bool paso = false;
            DetalleVentas d = new DetalleVentas();

            d.Iddetalleventa = 1;
            d.Idventa = 1;
            d.Idproducto = 1;
            d.Unidades = 2;
            d.Costounidad = 10;
            d.Descuentounidad = 5;
            d.Total = 10;
            paso = repositorio.Guardar(d);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            bool paso = false;
            DetalleVentas d = repositorio.Buscar(1);
            d.Unidades = 20;
            paso = repositorio.Modificar(d);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            DetalleVentas d = repositorio.Buscar(1);
            Assert.IsNotNull(d);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            List<DetalleVentas> lista = new List<DetalleVentas>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
