using BlazorDemo.Entities;
using FluentValidation;

namespace BlazorDemo.Validators;

public class PlaatsValidator : AbstractValidator<Plaats>
{
	public PlaatsValidator()
	{
		RuleFor(x => x.Name).NotEmpty().WithMessage("Vul in aub");
		RuleFor(x => x.Rating).NotEmpty().GreaterThan(0).LessThan(15).WithMessage("Tussen 0 en 15 graag");

		When(x => x.Rating > 5, () => { RuleFor(x => x.PhotoUrl).NotEmpty().WithMessage("Vul deze ook in aub"); });
	}
}