using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            UsuarioId = 0;
            Fecha = DateTime.Now;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            Email = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Direccion = string.Empty;
            Activo = false;
        }
    }
}
