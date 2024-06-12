using System.ComponentModel.DataAnnotations;

public class OOOForm : LegalEntityFormBase
{
    public string FullName { get; set; }

    public string ShortName { get; set; }

    public string? Ogrn { get; set; }

    public IFormFile? OgrnScan { get; set; }

    public string? OgrnScanPath { get; set; }
}
