using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Kategori açıklaması boş geçilemez");
            RuleFor(x => x.Name).MaximumLength(10).WithMessage("Lütfen en fazla 10 karakter girişi yapın");
        }
    }
}
