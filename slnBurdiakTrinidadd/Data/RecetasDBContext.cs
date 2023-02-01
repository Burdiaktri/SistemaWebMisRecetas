using Microsoft.EntityFrameworkCore;
using slnBurdiakTrinidad.Models;

namespace slnBurdiakTrinidad.Data
{
    public class RecetasDBContext : DbContext
    {
        public RecetasDBContext(DbContextOptions<RecetasDBContext> options) : base(options) { }
        public DbSet<Receta> Recetas { get; set; }
    }
}
