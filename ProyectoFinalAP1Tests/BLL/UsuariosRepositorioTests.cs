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
            Usuarios usuario = new Usuarios();
            UsuariosRepositorio repositorio = new UsuariosRepositorio();

            usuario.UsuarioId = 0;
            usuario.Fecha = DateTime.Now;
            usuario.Nombres = "Usuario";
            usuario.Apellidos = "Administrador";
            usuario.Cedula = "000-0000000-0";
            usuario.Email = "admin@ucne.edu.do";
            usuario.NombreUsuario = "admin";
            usuario.ClaveUsuario = "admin";
            usuario.TipoUsuario = 0;
            usuario.Activo = true;

            repositorio.Guardar(usuario);

            paso = repositorio.Desactivar(1);

            Assert.Equals(paso, true);
        }
    }
}