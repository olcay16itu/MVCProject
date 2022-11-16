using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validator
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(p => p.CategoryName).NotEmpty().WithMessage("Kategori adı boş kalamaz.");
            RuleFor(p => p.CategoryDescription).NotEmpty().WithMessage("Kategori tanımı boş kalamaz.");
            RuleFor(p => p.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz");
            RuleFor(p => p.CategoryName).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter giriniz");
        }
    }
}
