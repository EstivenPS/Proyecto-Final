using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuariosRepositorio : RepositorioBase<Usuarios>
    {
        public virtual bool Desactivar(int id)
        {
            bool paso = false;
            Usuarios usuario = new Usuarios();

            try
            {
                usuario = _contexto.Usuario.Find(id);
                usuario.Activo = false;
                _contexto.Entry(usuario).State = EntityState.Modified;
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
