using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinalAP1.BLL;
using ProyectoFinalAP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAP1.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void RepositorioBaseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Empresas empresa = new Empresas();
            RepositorioBase<Empresas> repositorio = new RepositorioBase<Empresas>();

            empresa.EmpresaId = 0;
            empresa.Nombre = "Prueba";
            empresa.Direccion = "Prueba";
            empresa.Telefono = "000-000-0000";

            paso = repositorio.Guardar(empresa);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Empresas empresa = new Empresas();
            RepositorioBase<Empresas> repositorio = new RepositorioBase<Empresas>();

            empresa.EmpresaId = 0;
            empresa.Nombre = "PruebaModificado";
            empresa.Direccion = "PruebaModificado";
            empresa.Telefono = "000-000-0000";

            paso = repositorio.Modificar(empresa);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            RepositorioBase<Empresas> repositorio = new RepositorioBase<Empresas>();

            paso = repositorio.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Empresas empresa = new Empresas();
            RepositorioBase<Empresas> repositorio = new RepositorioBase<Empresas>();

            empresa = repositorio.Buscar(1);
            Assert.IsTrue(empresa != null);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DisposeTest()
        {
            Assert.Fail();
        }
    }
}