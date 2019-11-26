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
    public class UsuariosRepositorioTests
    {
        [TestMethod()]
        public void DesactivarTest()
        {
            bool paso = false;
            UsuariosRepositorio repositorio = new UsuariosRepositorio();
            
            paso = repositorio.Desactivar(1);

            Assert.Equals(paso, true);
        }
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Usuarios usuario = new Usuarios();
            UsuariosRepositorio repositorio = new UsuariosRepositorio();

            usuario.UsuarioId = 0;
            usuario.Fecha = DateTime.Now;
            usuario.Nombres = "Prueba";
            usuario.Apellidos = "Prueba";
            usuario.Cedula = "000-0000000-0";
            usuario.Email = "Prueba";
            usuario.NombreUsuario = "Prueba";
            usuario.ClaveUsuario = "Prueba";
            usuario.TipoUsuario = 2;
            usuario.Activo = true;

            paso = repositorio.Guardar(usuario);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Usuarios usuario = new Usuarios();
            UsuariosRepositorio repositorio = new UsuariosRepositorio();

            usuario.UsuarioId = 1;
            usuario.Fecha = DateTime.Now;
            usuario.Nombres = "PruebaModificada";
            usuario.Apellidos = "PruebaModificada";
            usuario.Cedula = "000-0000000-0";
            usuario.Email = "Prueba";
            usuario.NombreUsuario = "PruebaModificada";
            usuario.ClaveUsuario = "PruebaModificada";
            usuario.TipoUsuario = 2;
            usuario.Activo = true;

            paso = repositorio.Modificar(usuario);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Usuarios usuario = new Usuarios();
            UsuariosRepositorio repositorio = new UsuariosRepositorio();

            usuario = repositorio.Buscar(1);
            Assert.IsTrue(usuario != null);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            Usuarios usuario = new Usuarios();
            UsuariosRepositorio repositorio = new UsuariosRepositorio();

            paso = repositorio.Eliminar(1);
            Assert.AreEqual(paso, true);
        }
    }
}