using Entity_Layer.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class WriterDTOValidator : AbstractValidator<WriterDTO>
    {
        public WriterDTOValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("bu alan boş geçilemez").NotEmpty().WithMessage("bu alan boş geçilemez");
           RuleFor(x=>x.Surname).NotNull().WithMessage("bu alan boş geçilemez").NotEmpty().WithMessage("bu alan boş geçilemez");
           RuleFor(x=>x.Mail).NotNull().WithMessage("bu alan boş geçilemez").EmailAddress().WithMessage("Uygun bir mail adresi girmelisiniz");
        }
    }
}
