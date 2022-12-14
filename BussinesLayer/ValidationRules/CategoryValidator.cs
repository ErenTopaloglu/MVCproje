using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category Name Cannot empty");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Description Cannot Empty");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Please enter minimum 3 characters ");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Please enter maximum 20 characters");
        }
    }
}
