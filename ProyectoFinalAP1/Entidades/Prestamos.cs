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
        public int CobradorId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoPrestamo { get; set; }
        public decimal Mora { get; set; }
        public decimal Interes { get; set; }
        public decimal Balance { get; set; }
        public virtual List<CuotasDetalle> Cuotas { get; set; }

        public Prestamos()
        {
            PrestamoId = 0;
            ClienteId = 0;
            CobradorId = 0;
            Fecha = DateTime.Now;
            MontoPrestamo = 0;
            Mora = 0;
            Interes = 0;
            Balance = 0;
            Cuotas = new List<CuotasDetalle>();
        }
    }
}
