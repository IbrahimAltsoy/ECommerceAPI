using ECommerceAPI.Domain.Entities.Common;

namespace ECommerceAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public string Address { get; set; }
        public Guid CustomerId { get; set; }

        public ICollection<Product> Products { get; set; }// her siparsin birden cok urunu olabilir
        public Customer Customer { get; set; }// bir siparisin tek musteriye ait olabilir coka tek iliskili 
    }
}
