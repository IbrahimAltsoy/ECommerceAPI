using ECommerceAPI.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceAPI.Domain.Entities
{
    public class File:BaseEntity
    {
        [NotMapped]
        public override DateTime UpdateDate { get => base.UpdateDate; set => base.UpdateDate = value; }// Base entity propertilerinden updateDate i burada eklenmesini istemedigimiz icin boyle yaptik. 
        public string FileName { get; set; }
        public string Path { get; set; }
    }
}
