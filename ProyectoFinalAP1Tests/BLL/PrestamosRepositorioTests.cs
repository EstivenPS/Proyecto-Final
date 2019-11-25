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
    public class PrestamosRepositorioTests
    {
        [TestMethod()]//31
        public void GuardarTest()
        {
            bool paso = false;
            Prestamos prestamo = new Prestamos();
            PrestamosRepositorio repositorio = new PrestamosRepositorio();

            prestamo.PrestamoId = 0;
            prestamo.ClienteId = 1;
            prestamo.UsuarioId = 1;
            prestamo.CobradorId = 1;
            prestamo.Fecha = DateTime.Now;
            prestamo.MontoPrestado = 1000;
            prestamo.PorcientoInteres = 8;
            prestamo.Interes = 80;
            prestamo.Balance = 1080;
            prestamo.CantidadCuotas = 4;
            prestamo.Cuotas = new List<PrestamosDetalles>();

            paso = repositorio.Guardar(prestamo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Prestamos prestamo = new Prestamos();
            PrestamosRepositorio repositorio = new PrestamosRepositorio();

            prestamo.PrestamoId = 1;
            prestamo.ClienteId = 1;
            prestamo.UsuarioId = 1;
            prestamo.CobradorId = 1;
            prestamo.Fecha = DateTime.Now;
            prestamo.MontoPrestado = 1000;
            prestamo.PorcientoInteres = 8;
            prestamo.Interes = 80;
            prestamo.Balance = 1080;
            prestamo.CantidadCuotas = 4;
            prestamo.Cuotas = new List<PrestamosDetalles>();

            paso = repositorio.Modificar(prestamo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Prestamos prestamo = new Prestamos();
            PrestamosRepositorio repositorio = new PrestamosRepositorio();

            prestamo = repositorio.Buscar(1);
            Assert.IsTrue(prestamo != null);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            PrestamosRepositorio repositorio = new PrestamosRepositorio();

            paso = repositorio.Eliminar(1);
            Assert.AreEqual(paso, true);
        }
    }
}