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

            Assert.Equals(repositorio.Desactivar(1), true);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Clientes cliente = new Clientes();
            ClientesRepositorio repositorio = new ClientesRepositorio();

            cliente.ClienteId = 0;
            cliente.UsuarioId = 1;
            cliente.Fecha = DateTime.Now;
            cliente.Nombres = "Prueba";
            cliente.Apellidos = "Prueba";
            cliente.Direccion = "Prueba";
            cliente.Email = "Prueba";
            cliente.Cedula = "000-0000000-0";
            cliente.Telefono = "000-000-0000";
            cliente.Celular = "000-000-0000";
            cliente.Activo = true;

            paso = repositorio.Guardar(cliente);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Clientes cliente = new Clientes();
            ClientesRepositorio repositorio = new ClientesRepositorio();

            cliente.ClienteId = 1;
            cliente.UsuarioId = 1;
            cliente.Fecha = DateTime.Now;
            cliente.Nombres = "PruebaModificada";
            cliente.Apellidos = "PruebaModificada";
            cliente.Direccion = "PruebaModificada";
            cliente.Email = "PruebaModificada";
            cliente.Cedula = "000-0000000-0";
            cliente.Telefono = "000-000-0000";
            cliente.Celular = "000-000-0000";
            cliente.Activo = true;

            paso = repositorio.Modificar(cliente);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Clientes cliente = new Clientes();
            ClientesRepositorio repositorio = new ClientesRepositorio();

            cliente = repositorio.Buscar(1);
            Assert.IsTrue(cliente != null);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            ClientesRepositorio repositorio = new ClientesRepositorio();

            paso = repositorio.Eliminar(1);
            Assert.AreEqual(paso, true);
        }
    }
}