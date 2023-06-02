using ECommerceAPI.Application.ViewModels.Products;
using FluentValidation;

namespace ECommerceAPI.Application.Validators.Product
{
    public class Create_Product_Validator : AbstractValidator<VM_Create_Product>
    {
       public Create_Product_Validator() 
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lutfen urun ismi giriniz")
                .MaximumLength(25)
                    .WithMessage("urunu en fazla {MaxLength} karakter olmalidir.")
                .MinimumLength(2)
                    .WithMessage("urunu en az {MinLength} karakter olmalidir.");


            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lutfen urun stogunu giriniz")
                .Must(p => p >= 0)
                    .WithMessage("Urun stogunu en az 0 olmalidir.");



            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lutfen fiyat bilgisini giriniz")
                .Must(p => p >= 0)
                    .WithMessage("Fiyat bilgisi en az 0 olmalidir.");





        }
    }
}
