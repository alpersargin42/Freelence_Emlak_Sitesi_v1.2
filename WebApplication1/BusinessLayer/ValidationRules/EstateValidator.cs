using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class EstateValidator:AbstractValidator<Estate>
    {
        public EstateValidator()
        {
            RuleFor(x => x.EstateTitle).NotEmpty().WithMessage("Bu alan boş bırakılamaz!");
            RuleFor(x => x.EstateContent).NotEmpty().WithMessage("Bu alan boş bırakılamaz!");
            RuleFor(x => x.EstateImage).NotEmpty().WithMessage("Bu alan boş bırakılamaz!");
            RuleFor(x => x.EstateTitle).MaximumLength(100).WithMessage("Bu alana maksimum 100 karakter girebilirsiniz.");
            RuleFor(x => x.EstateContent).MaximumLength(500).WithMessage("Bu alana maksimum 500 karakter girebilirsiniz.");
            RuleFor(x => x.EstatePrice).NotEmpty().WithMessage("Bu alan boş bırakılamaz!");
        }
    }
}
