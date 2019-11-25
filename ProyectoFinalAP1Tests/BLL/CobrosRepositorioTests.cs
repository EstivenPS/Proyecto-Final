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
        public void ModificarTest()
        {
            CobrosRepositorio repositorio = new CobrosRepositorio();
            Cobros cobro = new Cobros();

            cobro.CobroId = 1;

            Assert.IsTrue(repositorio.Modificar(cobro));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            CobrosRepositorio repositorio = new CobrosRepositorio();

            paso = repositorio.Eliminar(1);

            Assert.Equals(paso, 1);
        }

        [TestMethod()]
        public void CobrarCuotaTest()
        {
            Cobros cobro = new Cobros();
            CobrosRepositorio repositorio = new CobrosRepositorio();

            cobro.CobroId = 1;
            cobro.Fecha = DateTime.Now;
            cobro.ClienteId = 1;
            cobro.PrestamoId = 1;
            cobro.NumeroCuota = 1;
            cobro.Monto = 1;

            Assert.IsTrue(repositorio.CobrarCuota(cobro));
        }
    }
}