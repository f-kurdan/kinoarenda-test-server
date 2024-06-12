using LegalEntityForm.Models;
using System.ComponentModel.DataAnnotations;

public abstract class LegalEntityFormBase
{
    [Required]
    [RegularExpression(@"\d{10}|\d{12}", ErrorMessage = "ИНН должен содержать 10 или 12 цифр.")]
    public string Inn { get; set; }
    
    [Required]
    public IFormFile InnScan { get; set; }

    public string? InnScanPath { get; set; }

    [Required]
    public DateTime RegistrationDate { get; set; }

    [Required]
    public IFormFile EgripScan { get; set; }

    public string? EgripScanPath { get; set; }

    public IFormFile? LeaseContractScan { get; set; }

    public string? LeaseContractScanPath { get; set; }

    [Required]
    public List<BankDetails> BankDetails { get; set; }
}
