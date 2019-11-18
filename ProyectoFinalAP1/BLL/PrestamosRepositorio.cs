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

            try
            {
                var Anterior = _contexto.Prestamos.Find(prestamo.PrestamoId);
                foreach (var item in Anterior.Cuotas)
                {
                    if (!prestamo.Cuotas.Exists(d => d.PrestamoId == item.PrestamoId))
                        _contexto.Entry(item).State = EntityState.Deleted;
                }
            }
            catch(Exception)
            {
                throw;
            }

            paso = base.Modificar(prestamo);

            return paso;
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
