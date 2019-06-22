using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class UnidadMedidasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Unidadmedidas u = new Unidadmedidas();
            u.Idunidadmedida = 1;
            u.Nombreunidad = "Kilos";

            RepositorioBase<Unidadmedidas> repositorio = new RepositorioBase<Unidadmedidas>();
            bool paso = false;
            paso = repositorio.Guardar(u);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Unidadmedidas> repositorio = new RepositorioBase<Unidadmedidas>();
            Unidadmedidas u = repositorio.Buscar(1);
            u.Nombreunidad = "Kilogramos";
            bool paso = false;
            paso = repositorio.Modificar(u);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Unidadmedidas> repositorio = new RepositorioBase<Unidadmedidas>();
            Unidadmedidas u = repositorio.Buscar(1);
            Assert.IsNotNull(u);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Unidadmedidas> repositorio = new RepositorioBase<Unidadmedidas>();
            List<Unidadmedidas> lista = new List<Unidadmedidas>();
            lista = repositorio.GetList(u => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Unidadmedidas> repositorio = new RepositorioBase<Unidadmedidas>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }

    }
}
