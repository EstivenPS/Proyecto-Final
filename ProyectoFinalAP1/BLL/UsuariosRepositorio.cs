using ProyectoFinalAP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAP1.BLL
{
    public class UsuariosRepositorio : RepositorioBase<Usuarios>
    {
        public virtual bool Desactivar(int id)
        {
            bool paso = false;

            try
            {
                Usuarios usuario = _contexto.Usuario.Find(id);
                usuario.Activo = false;
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
