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
            PrestamosDetalles cuota = new PrestamosDetalles();
            RepositorioBase<PrestamosDetalles> repositorio = new RepositorioBase<PrestamosDetalles>();

            cuota.CuotaId = 0;
            cuota.PrestamoId = 1;
            cuota.Fecha = DateTime.Now;
            cuota.NumeroCuota = 1;
            cuota.Capital = 25;
            cuota.Interes = 2;
            cuota.Balance = 27;

            paso = repositorio.Guardar(cuota);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            PrestamosDetalles cuota = new PrestamosDetalles();
            RepositorioBase<PrestamosDetalles> repositorio = new RepositorioBase<PrestamosDetalles>();

            cuota.CuotaId = 1;
            cuota.PrestamoId = 1;
            cuota.Fecha = DateTime.Now;
            cuota.NumeroCuota = 2;
            cuota.Capital = 25;
            cuota.Interes = 2;
            cuota.Balance = 27;

            paso = repositorio.Modificar(cuota);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            RepositorioBase<PrestamosDetalles> repositorio = new RepositorioBase<PrestamosDetalles>();

            paso = repositorio.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            PrestamosDetalles cuota = new PrestamosDetalles();
            RepositorioBase<PrestamosDetalles> repositorio = new RepositorioBase<PrestamosDetalles>();

            cuota = repositorio.Buscar(1);
            Assert.IsTrue(cuota != null);
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