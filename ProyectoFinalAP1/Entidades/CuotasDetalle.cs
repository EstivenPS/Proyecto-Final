using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAP1.Entidades
{
    public class CuotasDetalle
    {
        [Key]
        public int CuotaId { get; set; }
        public int PrestamoId { get; set; }
        public DateTime Fecha { get; set; }
        public int NumeroCuota { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal Total { get; set; }
        public decimal Balance { get; set; }

        public CuotasDetalle()
        {
            CuotaId = 0;
            PrestamoId = 0;
            Fecha = DateTime.Now;
            NumeroCuota = 0;
            Capital = 0;
            Interes = 0;
            Total = 0;
            Balance = 0;
        }
    }
}
