using LegalEntityForm.Models;
using System.ComponentModel.DataAnnotations;

public abstract class LegalEntityFormBase
{
    [Key]
    public int Id { get; set; }

    public string? Inn { get; set; }
    
    public IFormFile? InnScan { get; set; }

    public string? InnScanPath { get; set; }

    public DateTime RegistrationDate { get; set; }

    public IFormFile? EgripScan { get; set; }

    public string? EgripScanPath { get; set; }

    public IFormFile? LeaseContractScan { get; set; }

    public string? LeaseContractScanPath { get; set; }

    public List<BankDetails>? BankDetails { get; set; }
}
