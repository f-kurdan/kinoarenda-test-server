using FluentValidation;
using LegalEntityForm.Validators;

namespace KinoarendTest.Validators
{
    public class IPFormValidator : AbstractValidator<IPForm>
    {
        public IPFormValidator()
        {
            RuleFor(x => x.Inn)
                .NotEmpty()
                .Matches(@"^\d{10}$|^\d{12}$")
                .WithMessage("ИНН должен состоять из 10 или 12 цифр");
            RuleFor(x => x.Ogrnip)
                .Matches(@"^\d{15}$")
                .WithMessage("ОГРНИП должен состоять из 15 цифр");
            RuleForEach(x => x.BankDetails)
                .SetValidator(x => new BankDetailsValidator());
            RuleFor(x => x.InnScan).NotNull();
            RuleFor(x => x.EgripScan).NotNull();
        }
    }
}
