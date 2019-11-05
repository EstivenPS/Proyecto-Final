using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAP1.Entidades
{
    public class Empresas
    {
        [Key]
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public Empresas()
        {
            EmpresaId = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
        }
    }
}
