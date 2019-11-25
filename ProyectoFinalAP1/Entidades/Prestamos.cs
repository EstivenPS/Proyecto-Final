using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAP1.Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
        public int CobradorId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoPrestado { get; set; }
        public decimal PorcientoInteres { get; set; }
        public decimal Interes { get; set; }
        public decimal Balance { get; set; }
        public int CantidadCuotas { get; set; }
        public virtual List<PrestamosDetalles> Cuotas { get; set; }

        public Prestamos()
        {
            PrestamoId = 0;
            ClienteId = 0;
            UsuarioId = 0;
            CobradorId = 0;
            Fecha = DateTime.Now;
            MontoPrestado = 0;
            PorcientoInteres = 0;
            Interes = 0;
            Balance = 0;
            CantidadCuotas = 0;
            Cuotas = new List<PrestamosDetalles>();
        }
    }
}
