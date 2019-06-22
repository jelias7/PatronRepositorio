using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class VentasTests
    {
        [TestMethod()]

        public void GuardarTest()
        {
            Ventas v = new Ventas();

            v.Idventa = 1;
            v.Idusuario = 1;
            v.Idcliente = 1;
            v.Idtipocomprobante = 1;
            v.Fechaventa = DateTime.Now;
            v.Igv = 1;
            v.SubTotal = 1;
            v.Costoventa = 1;

            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            bool paso = false;
            paso = repositorio.Guardar(v);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            bool paso = false;
            Ventas v = repositorio.Buscar(1);
            v.Idtipocomprobante = 11;
            paso = repositorio.Modificar(v);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            Ventas v = repositorio.Buscar(1);
            Assert.IsNotNull(v);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            List<Ventas> lista = new List<Ventas>();
            lista = repositorio.GetList(v => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
