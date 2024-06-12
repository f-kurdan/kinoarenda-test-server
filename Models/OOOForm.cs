using System.ComponentModel.DataAnnotations;

public class OOOForm : LegalEntityFormBase
{
    [Required]
    public string FullName { get; set; }

    [Required]
    public string ShortName { get; set; }

    [RegularExpression(@"\d{13}", ErrorMessage = "ОГРН должен содержать 13 цифр.")]
    public string? Ogrn { get; set; }

    [Required]
    public IFormFile? OgrnScan { get; set; }

    public string? OgrnScanPath { get; set; }
}
