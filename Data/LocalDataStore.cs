using LegalEntityForm.Models;

namespace LegalEntityForm.Data
{
    public class LocalDataStore
    {
        private readonly List<LegalEntity> _legalEntities = new();
        private readonly List<BankDetails> _bankDetails = new();
        private readonly List<LegalEntityFormBase> _legalEntityForms = new();

        public void AddLegalEntity(LegalEntity legalEntity)
        {
            legalEntity.Id = _legalEntities.Count + 1;
            _legalEntities.Add(legalEntity);
        }

        public void AddLegalEntityForm(LegalEntityFormBase legalEntity)
        {
            _legalEntityForms.Id = _legalEntityForms.Count + 1;
            _legalEntityForms.Add(legalEntity);
        }

        public void AddBankDetails(BankDetails bankDetails)
        {
            bankDetails.Id = _bankDetails.Count + 1;
            _bankDetails.Add(bankDetails);
        }

        public LegalEntity GetLegalEntityById(int id)
        {
            return _legalEntities.FirstOrDefault(le => le.Id == id);
        }

        public BankDetails GetBankDetailsById(int id)
        {
            return _bankDetails.FirstOrDefault(bd => bd.Id == id);
        }
    }
}
