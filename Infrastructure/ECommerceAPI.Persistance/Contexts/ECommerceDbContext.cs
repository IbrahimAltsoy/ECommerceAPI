using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Persistance.Contexts
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // ChangeTracker = Entiti uzerinde yapilan degisiklerin ya da  yeni eklenen verilerin yakalanmasini saglayan propertidir. Track edilen verlen yakalanmasini saglar
            var models = ChangeTracker
                .Entries<BaseEntity>();
            foreach (var model in models)
            {
                _ = model.State switch
                {
                    EntityState.Added => model.Entity.CreatedDate = DateTime.Now,
                    EntityState.Modified => model.Entity.UpdateDate =DateTime.Now,
                    _ => DateTime.Now

                };
            }
           
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
