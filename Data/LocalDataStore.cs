using LegalEntityForm.Models;

namespace LegalEntityForm.Data
{
    public class LocalDataStore 
    { 
        private readonly List<LegalEntityFormBase> _legalEntityForms = new();

        public void AddLegalEntityForm(LegalEntityFormBase legalEntity)
        {
            legalEntity.Id = _legalEntityForms.Count + 1;
            _legalEntityForms.Add(legalEntity);
        }

        public LegalEntityFormBase GetLegalEntityFormById(int id)
        {
            return _legalEntityForms.FirstOrDefault(le => le.Id == id);
        }
    }
}
