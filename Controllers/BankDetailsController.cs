using Microsoft.AspNetCore.Mvc;
using LegalEntityForm.Data;
using LegalEntityForm.Models;
using FluentValidation;
using FluentValidation.Results;
using LegalEntityForm.Services;
using fdf

namespace LegalEntityForm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankDetailsController : ControllerBase
    {
        private readonly LocalDataStore _dataStore;
        private readonly IValidator<BankDetails> _validator;
        private readonly AutoFillService _autoFillService;

        public BankDetailsController(LocalDataStore dataStore, IValidator<BankDetails> validator, AutoFillService autoFillService)
        {
            _dataStore = dataStore;
            _validator = validator;
            _autoFillService = autoFillService;
        }

        [HttpPost]
        public IActionResult CreateBankDetails([FromBody] BankDetails bankDetails)
        {
            ValidationResult result = _validator.Validate(bankDetails);

            if (!result.IsValid)
            {
                return BadRequest(result.Errors);
            }

            _dataStore.AddBankDetails(bankDetails);
            return Ok(bankDetails);
        }

        [HttpGet("{bik}")]
        public IActionResult GetByBik(string bik)
        {
            var bankDetails = _autoFillService.GetBankDetailsByBik(bik);
            if (bankDetails == null)
            {
                return NotFound();
            }

            var result = new
            {
                bankDetails.BankName,
                bankDetails.CorrespondentAccount
            };

            return Ok(result);
        }
    }
}
