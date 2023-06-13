namespace ECommerceAPI.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
      virtual public DateTime UpdateDate { get; set; } // bunu virtual yaparak istemedigimiz entitylere eklemnmesini engellemis oluruz. Mesela biz bunu File entity sinifa eklemek istemedigimizden virtual yaptik. File de gecerli olmasi icin de override yapacaz orada geri kalan kodlar oradan takip edilebilir.
       
    }
}
