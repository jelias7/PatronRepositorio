using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class TipoComprobantesTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            TipoComprobantes t = new TipoComprobantes();
            t.Idtipocomprobante = 1;
            t.Nombrecomprobante = "Ejemplo";

            RepositorioBase<TipoComprobantes> repositorio = new RepositorioBase<TipoComprobantes>();
            bool paso = false;
            paso = repositorio.Guardar(t);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<TipoComprobantes> repositorio = new RepositorioBase<TipoComprobantes>();
            TipoComprobantes t = repositorio.Buscar(1);
            bool paso = false;
            t.Nombrecomprobante = "EEEJJEMPLO";
            paso = repositorio.Modificar(t);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<TipoComprobantes> repositorio = new RepositorioBase<TipoComprobantes>();
            TipoComprobantes t = repositorio.Buscar(1);
            Assert.IsNotNull(t);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<TipoComprobantes> repositorio = new RepositorioBase<TipoComprobantes>();
            List<TipoComprobantes> lista = new List<TipoComprobantes>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<TipoComprobantes> repositorio = new RepositorioBase<TipoComprobantes>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
