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
        public override bool Modificar(Prestamos entity)
        {
            try
            {
                var Anterior = _contexto.Prestamo.Find(entity.PrestamoId);
                foreach (var item in Anterior.Cuotas)
                {
                    if (!entity.Cuotas.Exists(d => d.PrestamoId == item.PrestamoId))
                        _contexto.Entry(entity).State = EntityState.Deleted;
                }
            }
            catch(Exception)
            {
                throw;
            }

            bool paso = base.Modificar(entity);

            return paso;
        }

        public override Prestamos Buscar(int id)
        {
            Prestamos prestamos = new Prestamos();
            
            prestamos = base.Buscar(id);

            if (prestamos != null)
                prestamos.Cuotas.Count();//Para que se ejecute el Lazyloading cuando se encuentre un registro de un prestamo

            return prestamos;
        }
    }
}
