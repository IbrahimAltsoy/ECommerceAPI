using ECommerceAPI.Application.Repositories.Invoice;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistance.Contexts;

namespace ECommerceAPI.Persistance.Repositories.Invoices
{
    public class InvoicesWriteRepository  : WriteRepository<InvoiceFile>, IInvoiceFilessWriteRepository
    {
        public InvoicesWriteRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
}
