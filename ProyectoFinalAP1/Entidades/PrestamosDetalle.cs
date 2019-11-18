using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAP1.Entidades
{
    public class PrestamosDetalle
    {
        [Key]
        public int CuotaId { get; set; }
        public int PrestamoId { get; set; }
        public DateTime Fecha { get; set; }
        public int NumeroCuota { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal Balance { get; set; }

        public PrestamosDetalle()
        {
            CuotaId = 0;
            PrestamoId = 0;
            Fecha = DateTime.Now;
            NumeroCuota = 0;
            Capital = 0;
            Interes = 0;
            Balance = 0;
        }

        public PrestamosDetalle(int cuotaId, int prestamoId, DateTime fecha, int numerocuota, decimal capital, decimal interes, decimal balance)
        {
            CuotaId = cuotaId;
            PrestamoId = prestamoId;
            Fecha = fecha;
            NumeroCuota = numerocuota;
            Capital = capital;
            Interes = interes;
            Balance = balance;
        }
    }
}
