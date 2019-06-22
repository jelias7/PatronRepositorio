using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class PermisosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Permisos p = new Permisos();
            p.Idpermiso = 2;
            p.Descripcion = "xxxx";
            p.Funcionalidad = "zzzz";

            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            bool paso = false;
            paso = repositorio.Guardar(p);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            bool paso = false;
            Permisos p = repositorio.Buscar(2);
            p.Funcionalidad = "ppp";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            Permisos p = repositorio.Buscar(3);
            Assert.IsNotNull(p);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            List<Permisos> lista = new List<Permisos>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            bool paso = false;
            paso = repositorio.Eliminar(3);
            Assert.AreEqual(true, paso);
        }
    }
}
