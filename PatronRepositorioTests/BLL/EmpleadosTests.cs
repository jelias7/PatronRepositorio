using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;

namespace PatronRepositorioTests.BLL
{
    [TestClass]
    public class EmpleadosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Empleados e = new Empleados();

            e.Idempleado = 1;
            e.Idestado = 1;
            e.Idcargo = 1;
            e.Idpersona = 1;

            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            bool paso = false;
            paso = repositorio.Guardar(e);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            bool paso = false;
            Empleados e = repositorio.Buscar(1);
            e.Idcargo = 11;
            paso = repositorio.Modificar(e);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            Empleados e = repositorio.Buscar(1);
            Assert.IsNotNull(e);
        }


        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            List<Empleados> lista = new List<Empleados>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
