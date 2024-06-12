using System.ComponentModel.DataAnnotations;

namespace LegalEntityForm.Models
{
    public class BankDetails
    {
        [Required]
        public string BankBik { get; set; }

        [Required]
        public string BankName { get; set; }

        [Required]
        public string CheckingAccount { get; set; }

        [Required]
        public string CorrespondentAccount { get; set; }
    }
}
