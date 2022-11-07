using Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace ServiceType.Service
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<ServiceTypeEntity> ServiceTypes { get; set; }
    }
}