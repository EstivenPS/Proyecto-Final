using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinalAP1.BLL;
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
            
            Assert.Equals(paso, true);
        }
    }
}