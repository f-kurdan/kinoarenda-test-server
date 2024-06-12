using FluentValidation;
using LegalEntityForm.Validators;

namespace KinoarendTest.Validators
{
    public class OOOFormValidator : AbstractValidator<OOOForm>
    {
        public OOOFormValidator()
        {
            RuleFor(x => x.FullName).NotEmpty();
            RuleFor(x => x.ShortName).NotEmpty();
            RuleFor(x => x.Inn)
                .NotEmpty()
                .Matches(@"^\d{10}$|^\d{12}$")
                .WithMessage("ИНН должен состоять из 10 или 12 цифр");
            RuleFor(x => x.Ogrn)
                .NotEmpty()
                .Matches(@"^\d{13}$")
                .WithMessage("ОГРН должен состоять из 13 цифр");
            RuleFor(x => x.InnScan).NotNull();
            RuleFor(x => x.OgrnScan).NotNull();
            RuleFor(x => x.EgripScan).NotNull();
            RuleForEach(x => x.BankDetails)
                .SetValidator(x => new BankDetailsValidator());
        }
    }
}
