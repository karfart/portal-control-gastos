using ControlGastosBlazor.Components.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ControlGastosBlazor.Components.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoGasto> TipoGastos => Set<TipoGasto>();
        public DbSet<FondoMonetario> FondoMonetarios => Set<FondoMonetario>();
        public DbSet<Presupuesto> Presupuestos => Set<Presupuesto>();
        public DbSet<Gasto> Gastos => Set<Gasto>();
        public DbSet<GastoDetalle> GastoDetalles => Set<GastoDetalle>();
        public DbSet<Deposito> Depositos => Set<Deposito>();
    }
}
