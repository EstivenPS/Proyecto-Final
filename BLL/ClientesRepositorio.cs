using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClientesRepositorio : RepositorioBase<Clientes>
    {
        public virtual bool Desactivar(int id)
        {
            bool paso = false;
            Clientes cliente = new Clientes();

            try
            {
                cliente = _contexto.Cliente.Find(id);
                cliente.Activo = false;
                _contexto.Entry(cliente).State = EntityState.Modified;
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
