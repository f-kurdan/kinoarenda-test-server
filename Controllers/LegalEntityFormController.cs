using FluentValidation;
using LegalEntityForm.Data;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LegalEntityFormController : ControllerBase
    {
        private readonly LocalDataStore _dataStore;
        private readonly IWebHostEnvironment _environment;
        private readonly IValidator<OOOForm> _oooFormValidator;
        private readonly IValidator<IPForm> _ipFormValidator;

        public LegalEntityFormController(LocalDataStore dataStore, IWebHostEnvironment environment, IValidator<IPForm> ipFormvalidator, IValidator<OOOForm> oooFormValidator)
        {
            _dataStore = dataStore;
            _environment = environment;
            _oooFormValidator = oooFormValidator;
            _ipFormValidator = ipFormvalidator;
        }

        [HttpPost("ip")]
        public async Task<IActionResult> SaveIPForm([FromForm] IPForm form)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var uploadsPath = Path.Combine(_environment.ContentRootPath, "uploads");
            Directory.CreateDirectory(uploadsPath);

            if (form.InnScan != null)
            {
                var innScanPath = Path.Combine(uploadsPath, form.InnScan.FileName);
                using (var stream = new FileStream(innScanPath, FileMode.Create))
                {
                    await form.InnScan.CopyToAsync(stream);
                }
                form.InnScanPath = $"/uploads/{form.InnScan.FileName}";
            }

            if (form.OgrnipScan != null)
            {
                var ogrnipScanPath = Path.Combine(uploadsPath, form.OgrnipScan.FileName);
                using (var stream = new FileStream(ogrnipScanPath, FileMode.Create))
                {
                    await form.OgrnipScan.CopyToAsync(stream);
                }
                form.OgrnipScanPath = $"/uploads/{form.OgrnipScan.FileName}";
            }

            if (form.EgripScan != null)
            {
                var egripScanPath = Path.Combine(uploadsPath, form.EgripScan.FileName);
                using (var stream = new FileStream(egripScanPath, FileMode.Create))
                {
                    await form.EgripScan.CopyToAsync(stream);
                }
                form.EgripScanPath = $"/uploads/{form.EgripScan.FileName}";
            }

            if (form.LeaseContractScan != null)
            {
                var leaseContractScanPath = Path.Combine(uploadsPath, form.LeaseContractScan.FileName);
                using (var stream = new FileStream(leaseContractScanPath, FileMode.Create))
                {
                    await form.LeaseContractScan.CopyToAsync(stream);
                }
                form.LeaseContractScanPath = $"/uploads/{form.LeaseContractScan.FileName}";
            }

            _dataStore.AddLegalEntityForm(form);

            return Ok(new { Message = "Анкета ИП сохранена" });
        }

        [HttpPost("ooo")]
        public async Task<IActionResult> SaveOOOForm([FromForm] OOOForm form)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var uploadsPath = Path.Combine(_environment.ContentRootPath, "uploads");
            Directory.CreateDirectory(uploadsPath);

            if (form.InnScan != null)
            {
                var innScanPath = Path.Combine(uploadsPath, form.InnScan.FileName);
                using (var stream = new FileStream(innScanPath, FileMode.Create))
                {
                    await form.InnScan.CopyToAsync(stream);
                }
                form.InnScanPath = $"/uploads/{form.InnScan.FileName}";
            }

            if (form.EgripScan != null)
            {
                var egripScanPath = Path.Combine(uploadsPath, form.EgripScan.FileName);
                using (var stream = new FileStream(egripScanPath, FileMode.Create))
                {
                    await form.EgripScan.CopyToAsync(stream);
                }
                form.EgripScanPath = $"/uploads/{form.EgripScan.FileName}";
            }

            if (form.LeaseContractScan != null)
            {
                var leaseContractScanPath = Path.Combine(uploadsPath, form.LeaseContractScan.FileName);
                using (var stream = new FileStream(leaseContractScanPath, FileMode.Create))
                {
                    await form.LeaseContractScan.CopyToAsync(stream);
                }
                form.LeaseContractScanPath = $"/uploads/{form.LeaseContractScan.FileName}";
            }

            if (form.OgrnScan != null)
            {
                var ogrnScanPath = Path.Combine(uploadsPath, form.OgrnScan.FileName);
                using (var stream = new FileStream(ogrnScanPath, FileMode.Create))
                {
                    await form.OgrnScan.CopyToAsync(stream);
                }
                form.OgrnScanPath = $"/uploads/{form.OgrnScan.FileName}";
            }

            // Save form data in local collection
            _dataStore.AddLegalEntityForm(form);

            return Ok(new { Message = "Анкета ООО сохранена" });
        }
    }
}
