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
        public override bool Modificar(Cobros entity)
        {
            bool paso = false;
            List<PrestamosDetalles> cuotas = new List<PrestamosDetalles>();
            RepositorioBase<PrestamosDetalles> repositorioCuotas = new RepositorioBase<PrestamosDetalles>();

            try
            {
                var Anterior = _contexto.Cobro.Find(entity.CobroId);

                //Uso el GetList debido a que es el único que conozco que me permite aplicar condiciones a la hora de buscar registros
                cuotas = repositorioCuotas.GetList(c => true).Where(c => c.PrestamoId == entity.PrestamoId && c.NumeroCuota == entity.NumeroCuota).ToList();

                //Uso el foreach para poder sacar el único elemento que tendrá la lista enlazada, el cual es la cuota seleccionada
                foreach (var item in cuotas)
                {
                    item.Balance += Anterior.Monto;
                    item.Balance -= entity.Monto;

                    _contexto.Entry(item).State = EntityState.Modified;
                    _contexto.SaveChanges();
                    break;
                }
            }
            catch(Exception)
            {

            }

            paso = base.Modificar(entity);

            return paso;
        }
        public override bool Eliminar(int id)
        {   //Esto es para que cuando se elimine un cobro, el monto de ese cobro se le vuelva a sumar a su respectiva cuota
            List<PrestamosDetalles> cuotas = new List<PrestamosDetalles>();
            RepositorioBase<PrestamosDetalles> repositorioCuotas = new RepositorioBase<PrestamosDetalles>();
            Cobros cobro = new Cobros();

            try
            {
                cobro = base.Buscar(id);
                //Uso el GetList debido a que es el único que conozco que me permite aplicar condiciones a la hora de buscar registros
                cuotas = repositorioCuotas.GetList(c => true).Where(c => c.PrestamoId == cobro.PrestamoId && c.NumeroCuota == cobro.NumeroCuota).ToList();
                //Uso el foreach para poder sacar el único elemento que tendrá la lista enlazada, el cual es la cuota seleccionada
                foreach (var item in cuotas)
                {
                    item.Balance += cobro.Monto;
                    _contexto.Entry(item).State = EntityState.Modified;
                    _contexto.SaveChanges();
                    break;
                }
            }
            catch(Exception)
            {
                throw;
            }

            return base.Eliminar(id);
        }

        public virtual bool CobrarCuota(Cobros cobro)
        {
            bool paso = false;
            var cuotas = new List<PrestamosDetalles>();
            Prestamos prestamo = new Prestamos();
            PrestamosRepositorio repositorio = new PrestamosRepositorio();

            try
            {
                cuotas = repositorio.Buscar(cobro.PrestamoId).Cuotas;

                foreach (var item in cuotas)
                {
                    if (item.NumeroCuota == cobro.NumeroCuota)
                    {
                        item.Balance -= cobro.Monto;

                        _contexto.Entry(item).State = EntityState.Modified;
                        paso = _contexto.SaveChanges() > 0;
                        break;
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
