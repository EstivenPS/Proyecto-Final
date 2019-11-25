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
    public class ClientesRepositorioTests
    {
        [TestMethod()]
        public void DesactivarTest()
        {
            bool paso = false;
            ClientesRepositorio repositorio = new ClientesRepositorio();

            paso = repositorio.Desactivar(1);

            Assert.Equals(paso, true);
        }
    }
}