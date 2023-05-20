using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities.Common;
using ECommerceAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerceAPI.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity, new()
    {
        private readonly ECommerceDbContext _context;

        public ReadRepository(ECommerceDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;

        }


        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            //=>await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(
            // id));
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));

            // => await Table.FindAsync(Guid.Parse(id));
        }



        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        { // => await Table.FirstOrDefaultAsync(method);
            var query = Table.AsQueryable<T>();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);

        }



        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            // =>Table.Where(method);
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
            
        }


    }
}
