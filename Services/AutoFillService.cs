//using LegalEntityForm.Models;

//namespace LegalEntityForm.Services
//{
//    public class AutoFillService
//    {
//        private readonly List<LegalEntity> _legalEntities = new()
//        {
//            new LegalEntity
//            {
//                Id = 1,
//                ActivityType = "OOO",
//                Inn = "1234567890",
//                FullName = "ООО Ромашка",
//                ShortName = "Ромашка",
//                RegistrationDate = DateTime.Parse("2020-01-01"),
//                Ogrn = "1234567890123"
//            },
//            new LegalEntity
//            {
//                Id = 2,
//                ActivityType = "OOO",
//                Inn = "9876543210",
//                FullName = "ООО Лилия",
//                ShortName = "Лилия",
//                RegistrationDate = DateTime.Parse("2019-05-15"),
//                Ogrn = "9876543210123"
//            },
//            new LegalEntity
//            {
//                Id = 3,
//                ActivityType = "IP",
//                Inn = "1111111111",
//                FullName = "ИП Иванов Иван Иванович",
//                ShortName = "ИП Иванов",
//                RegistrationDate = DateTime.Parse("2018-03-10"),
//                Ogrnip = "111111111111111"
//            },
//            new LegalEntity
//            {
//                Id = 4,
//                ActivityType = "IP",
//                Inn = "2222222222",
//                FullName = "ИП Петров Петр Петрович",
//                ShortName = "ИП Петров",
//                RegistrationDate = DateTime.Parse("2017-07-20"),
//                Ogrnip = "222222222222222"
//            },
//            new LegalEntity
//            {
//                Id = 5,
//                ActivityType = "OOO",
//                Inn = "333333333333",
//                FullName = "ООО Василек",
//                ShortName = "Василек",
//                RegistrationDate = DateTime.Parse("2021-11-30"),
//                Ogrn = "3333333333333"
//            }
//        };

//        private readonly List<BankDetails> _bankDetails = new()
//        {
//            new BankDetails
//            {
//                Id = 1,
//                BankBik = "044525225",
//                BankName = "Сбербанк России",
//                CorrespondentAccount = "30101810400000000225"
//            },
//            new BankDetails
//            {
//                Id = 2,
//                BankBik = "044525545",
//                BankName = "ВТБ",
//                CorrespondentAccount = "30101810400000000545"
//            },
//            new BankDetails
//            {
//                Id = 3,
//                BankBik = "044525659",
//                BankName = "Альфа-Банк",
//                CorrespondentAccount = "30101810400000000659"
//            },
//            new BankDetails
//            {
//                Id = 4,
//                BankBik = "044525987",
//                BankName = "Газпромбанк",
//                CorrespondentAccount = "30101810400000000987"
//            },
//            new BankDetails
//            {
//                Id = 5,
//                BankBik = "044525333",
//                BankName = "Райффайзенбанк",
//                CorrespondentAccount = "30101810400000000333"
//            }
//        };

//        public LegalEntity GetLegalEntityByInn(string inn)
//        {
//            return _legalEntities.FirstOrDefault(le => le.Inn == inn);
//        }

//        public BankDetails GetBankDetailsByBik(string bik)
//        {
//            return _bankDetails.FirstOrDefault(bd => bd.BankBik == bik);
//        }
//    }
//}
