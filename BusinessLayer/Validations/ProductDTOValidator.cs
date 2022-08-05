using Entity_Layer.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class ProductDTOValidator : AbstractValidator<ProductDTO>
    {
        public ProductDTOValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("bu alan boş geçilemez").NotEmpty().WithMessage("bu alan boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("bu alan boş geçilemez");
        }
    }
}
