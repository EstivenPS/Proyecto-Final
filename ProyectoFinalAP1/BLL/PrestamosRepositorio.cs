using ProyectoFinalAP1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAP1.BLL
{
    public class PrestamosRepositorio : RepositorioBase<Prestamos>
    {
        public override bool Modificar(Prestamos prestamo)
        {
            bool paso = false;

            foreach (var item in prestamo.Cuotas)
            {
                if (item.CuotaId == 0)
                    base._contexto.Entry(item).State = EntityState.Added;
                else
                    base._contexto.Entry(item).State = EntityState.Modified;
            }

            return base.Modificar(prestamo);
        }

        public override Prestamos Buscar(int id)
        {
            Prestamos prestamo = new Prestamos();

            try
            {
                prestamo = base.Buscar(id);

                if (prestamo != null)
                    prestamo.Cuotas.Count();//Para que se ejecute el Lazyloading cuando se encuentre un registro de un prestamo
            }
            catch(Exception)
            {
                throw;
            }

            return prestamo;
        }
    }
}
