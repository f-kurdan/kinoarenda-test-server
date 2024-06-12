using System.ComponentModel.DataAnnotations;

public class IPForm : LegalEntityFormBase
{
    [RegularExpression(@"\d{15}", ErrorMessage = "ОГРНИП должен содержать 15 цифр.")]
    public string? Ogrnip { get; set; }

    [Required]
    public IFormFile? OgrnipScan { get; set; }

    public string? OgrnipScanPath { get; set; }
}
