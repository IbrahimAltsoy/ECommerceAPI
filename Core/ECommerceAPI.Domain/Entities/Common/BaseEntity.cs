namespace ECommerceAPI.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public DateTime UpdateDate { get; set; }= DateTime.Now;
       
    }
}
