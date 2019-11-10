using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAP1.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public int EmpresaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public int TipoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ClaveUsuario { get; set; }
        public bool Activo { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            EmpresaId = 1;
            Fecha = DateTime.Now;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            TipoUsuario = 0;
            NombreUsuario = string.Empty;
            ClaveUsuario = string.Empty;
            Activo = false;
        }
    }
}
