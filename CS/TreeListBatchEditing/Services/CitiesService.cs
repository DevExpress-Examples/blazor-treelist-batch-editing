using Microsoft.EntityFrameworkCore;
using TreeListBatchEditing.Data;

namespace TreeListBatchEditing.Services {
    public class CitiesService {
        CitiesContext _context;
        public CitiesService(IDbContextFactory<CitiesContext> contextFactory) {
            _context = contextFactory.CreateDbContext();
        }
        public void SeedData() {
            _context.Database.EnsureCreated();
            if (_context.Locations.Any())
                return;
            var stream = File.OpenRead(@"cities.json");
            var cities = System.Text.Json.JsonSerializer.Deserialize<Location[]>(stream);
            if (cities == null)
                return;
            _context.Locations.AddRange(cities);
            _context.SaveChanges();
        }

        public async Task<IQueryable<Location>> GetCitiesAsync() {
            return _context.Locations;
        }
    }
}
