using ProyectoFinalAP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAP1.BLL
{
    public class CobradoresRepositorio : RepositorioBase<Cobradores>
    {
        public virtual bool Desactivar(int id)
        {
            bool paso = false;

            try
            {
                Cobradores cobrador = _contexto.Cobrador.Find(id);
                cobrador.Activo = false;
                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
    }
}
