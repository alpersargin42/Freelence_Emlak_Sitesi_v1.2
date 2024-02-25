using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AdvertiserValidator : AbstractValidator<Advertiser>
	{
		public AdvertiserValidator()
		{
			RuleFor(x => x.AdvertiserName).NotEmpty().WithMessage("Boş Geçilemez.");
			RuleFor(x => x.AdvertiserMail).NotEmpty().WithMessage("Boş Geçilemez.");
			RuleFor(x => x.AdvertiserPassword).NotEmpty().WithMessage("Boş Geçilemez.");
			RuleFor(x => x.AdvertiserPassword1).NotEmpty().WithMessage("Boş Geçilemez.");
			RuleFor(x => x.AdvertiserPassword).MinimumLength(8).WithMessage("Minimum 8 karakter girmelisiniz");
			RuleFor(x => x.AdvertiserPassword).MaximumLength(20).WithMessage("Maximum 20 karakter girmelisiniz");
			RuleFor(x => x.AdvertiserPassword1).MinimumLength(8).WithMessage("Minimum 8 karakter girmelisiniz");
			RuleFor(x => x.AdvertiserPassword1).MaximumLength(20).WithMessage("Maximum 20 karakter girmelisiniz");

			RuleFor(x => x).Custom((x, context) =>
			{
				if (x.AdvertiserPassword != x.AdvertiserPassword1)
				{
					context.AddFailure(nameof(x.AdvertiserPassword), "Şifreler Uyuşmuyor.");
				}
			});

		}
	}
}
