using FluentValidation;
using LegalEntityForm.Models;

namespace LegalEntityForm.Validators
{
    public class BankDetailsValidator : AbstractValidator<BankDetails>
    {
        public BankDetailsValidator()
        {
            RuleFor(x => x.BankBik)
                .NotEmpty()
                .Matches(@"^\d{9}$")
                .WithMessage("БИК должен состоять из 9 цифр");
            RuleFor(x => x.BankName).NotEmpty();
            RuleFor(x => x.CheckingAccount)
                .NotEmpty()
                .Matches(@"^\d{20}$")
                .WithMessage("Расчетный счет должен состоять из 20 цифр");
            RuleFor(x => x.CorrespondentAccount)
                .NotEmpty()
                .Matches(@"^\d{20}$")
                .WithMessage("Корреспондентский счет должен состоять из 20 цифр");
        }
    }
}
