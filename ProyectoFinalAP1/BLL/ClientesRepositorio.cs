using ProyectoFinalAP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAP1.BLL
{
    public class ClientesRepositorio : RepositorioBase<Clientes>
    {
        public virtual bool Desactivar(int id)
        {
            bool paso = false;
            
            try
            {
                Clientes cliente = _contexto.Cliente.Find(id);
                cliente.Activo = false;
                paso = _contexto.SaveChanges() > 0;
            }
            catch(Exception)
            {
                throw;
            }

            return paso;
        }
    }
}
