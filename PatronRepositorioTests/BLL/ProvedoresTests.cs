using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class ProvedoresTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Provedores p = new Provedores();
            p.Idproveedor = 1;
            p.Idpersona = 1;

            RepositorioBase<Provedores> repositorio = new RepositorioBase<Provedores>();
            bool paso = false;
            paso = repositorio.Guardar(p);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Provedores> repositorio = new RepositorioBase<Provedores>();
            bool paso = false;
            Provedores p = repositorio.Buscar(1);
            p.Idpersona = 11;
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Provedores> repositorio = new RepositorioBase<Provedores>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Provedores> repositorio = new RepositorioBase<Provedores>();
            Provedores p = repositorio.Buscar(1);
            Assert.IsNotNull(p);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Provedores> repositorio = new RepositorioBase<Provedores>();
            List<Provedores> lista = new List<Provedores>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }

    }
}
