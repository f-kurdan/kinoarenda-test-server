using System.ComponentModel.DataAnnotations;

public class IPForm : LegalEntityFormBase
{
    public string? Ogrnip { get; set; }

    public IFormFile? OgrnipScan { get; set; }

    public string? OgrnipScanPath { get; set; }
}
