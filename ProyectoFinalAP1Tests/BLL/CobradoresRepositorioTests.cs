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
    public class CobradoresRepositorioTests
    {
        [TestMethod()]
        public void DesactivarTest()
        {
            bool paso = false;
            CobradoresRepositorio repositorio = new CobradoresRepositorio();

            paso = repositorio.Desactivar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Cobradores cobrador = new Cobradores();
            CobradoresRepositorio repositorio = new CobradoresRepositorio();

            cobrador.CobradorId = 0;
            cobrador.UsuarioId = 1;
            cobrador.Fecha = DateTime.Now;
            cobrador.Nombres = "Prueba";
            cobrador.Apellidos = "Prueba";
            cobrador.Direccion = "Prueba";
            cobrador.Email = "Prueba";
            cobrador.Cedula = "000-0000000-0";
            cobrador.Telefono = "000-000-0000";
            cobrador.Activo = true;

            paso = repositorio.Guardar(cobrador);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Cobradores cobrador = new Cobradores();
            CobradoresRepositorio repositorio = new CobradoresRepositorio();

            cobrador.CobradorId = 1;
            cobrador.UsuarioId = 1;
            cobrador.Fecha = DateTime.Now;
            cobrador.Nombres = "Prueba";
            cobrador.Apellidos = "Prueba";
            cobrador.Direccion = "Prueba";
            cobrador.Email = "Prueba";
            cobrador.Cedula = "000-0000000-0";
            cobrador.Telefono = "000-000-0000";
            cobrador.Activo = true;

            paso = repositorio.Modificar(cobrador);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Cobradores cobrador = new Cobradores();
            CobradoresRepositorio repositorio = new CobradoresRepositorio();

            cobrador = repositorio.Buscar(1);
            Assert.IsTrue(cobrador != null);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            CobradoresRepositorio repositorio = new CobradoresRepositorio();

            paso = repositorio.Eliminar(1);
            Assert.AreEqual(paso, true);
        }
    }
}