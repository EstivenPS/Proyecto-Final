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
        [TestMethod()]
        public void ModificarTest()
        {
            PrestamosRepositorio repositorio = new PrestamosRepositorio();
            Prestamos prestamo = new Prestamos();

            prestamo.PrestamoId = 1;

            Assert.IsTrue(repositorio.Modificar(prestamo));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            PrestamosRepositorio repositorio = new PrestamosRepositorio();
            Prestamos prestamo = new Prestamos();

            prestamo = repositorio.Buscar(1);

            Assert.IsTrue(prestamo != null);
        }
    }
}