using FluentValidation;
using Library.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.ValidationRules.FluentValidation
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Ürün ismi boş olamaz");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.AuthorId).NotEmpty();

            //GraterThan(0) 0'dan büyük olmalı

            //RuleFor(p => p.Name).Must(StartWithA).WithMessage("Ürün adı A ile başlamalı.");


        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
