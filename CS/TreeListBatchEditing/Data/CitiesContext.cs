using Microsoft.EntityFrameworkCore;
using TreeListBatchEditing.Services;

namespace TreeListBatchEditing.Data {
    public class CitiesContext : DbContext {
        public DbSet<Location> Locations { get; set; }
        public CitiesContext(DbContextOptions<CitiesContext> options) : base(options) { }
    }
}
