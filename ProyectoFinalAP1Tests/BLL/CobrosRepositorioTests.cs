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
    public class CobrosRepositorioTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Cobros cobro = new Cobros();
            CobrosRepositorio repositorio = new CobrosRepositorio();

            cobro.CobroId = 0;
            cobro.UsuarioId = 1;
            cobro.ClienteId = 1;
            cobro.Fecha = DateTime.Now;
            cobro.PrestamoId = 1;
            cobro.NumeroCuota = 1;
            cobro.Monto = 1;

            paso = repositorio.Guardar(cobro);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Cobros cobro = new Cobros();
            CobrosRepositorio repositorio = new CobrosRepositorio();

            cobro.CobroId = 1;
            cobro.UsuarioId = 1;
            cobro.ClienteId = 1;
            cobro.Fecha = DateTime.Now;
            cobro.PrestamoId = 1;
            cobro.NumeroCuota = 1;
            cobro.Monto = 1;

            paso = repositorio.Modificar(cobro);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Cobros cobro = new Cobros();
            CobrosRepositorio repositorio = new CobrosRepositorio();

            cobro = repositorio.Buscar(1);
            Assert.IsTrue(cobro != null);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            CobrosRepositorio repositorio = new CobrosRepositorio();

            paso = repositorio.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void CobrarCuotaTest()
        {
            bool paso = false;
            Cobros cobro = new Cobros();
            CobrosRepositorio repositorio = new CobrosRepositorio();

            cobro.CobroId = 1;
            cobro.Fecha = DateTime.Now;
            cobro.ClienteId = 1;
            cobro.PrestamoId = 1;
            cobro.NumeroCuota = 1;
            cobro.Monto = 1;

            paso = repositorio.CobrarCuota(cobro);

            Assert.AreEqual(paso, true);
        }
    }
}