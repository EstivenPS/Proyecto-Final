using ProyectoFinalAP1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAP1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Empresas> Empresa { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Cobradores> Cobrador { get; set; }
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
        public DbSet<Cobros> Cobro { get; set; }

        public Contexto() : base("ConStr") { }
    }
}
