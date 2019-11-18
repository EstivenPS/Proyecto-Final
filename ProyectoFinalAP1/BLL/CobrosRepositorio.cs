using ProyectoFinalAP1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAP1.BLL
{
    public class CobrosRepositorio : RepositorioBase<Cobros>
    {
        public virtual bool CobrarCuota(Cobros cobro)
        {
            bool paso = false;
            PrestamosRepositorio repositorio = new PrestamosRepositorio();

            try
            {
                List<PrestamosDetalles> cuotas = repositorio.Buscar(cobro.PrestamoId).Cuotas;

                foreach (var item in cuotas)
                {
                    if (item.NumeroCuota == cobro.NumeroCuota)
                    {
                        if (item.Balance != 0)
                            item.Balance = item.Balance - cobro.Monto;
                        
                        _contexto.Entry(item).State = EntityState.Modified;
                        paso = _contexto.SaveChanges() > 0;
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return paso;
        }
    }
}
