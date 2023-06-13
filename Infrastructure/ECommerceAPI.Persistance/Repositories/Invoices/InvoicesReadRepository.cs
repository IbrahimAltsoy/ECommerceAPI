using ECommerceAPI.Application.Repositories.Invoice;
using ECommerceAPI.Persistance.Contexts;
using I = ECommerceAPI.Domain.Entities;
namespace ECommerceAPI.Persistance.Repositories.Invoices
{
    public class InvoicesReadRepository : ReadRepository<I.InvoiceFile>, IInvoiceFilesWriteRepository
    {
        public InvoicesReadRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
}
