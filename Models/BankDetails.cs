using System.ComponentModel.DataAnnotations;

namespace LegalEntityForm.Models
{
    public class BankDetails
    {
        public string? BankBik { get; set; }

        public string? BankName { get; set; }

        public string? CheckingAccount { get; set; }

        public string? CorrespondentAccount { get; set; }
    }
}
