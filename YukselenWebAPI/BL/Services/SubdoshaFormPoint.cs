using Microsoft.Extensions.Caching.Memory;
using System.Linq;
using System.Threading.Tasks;
using YukselenWebAPI.BL.Repositories.SurveyResult;
using YukselenWebAPI.BL.Repositories.User;
using YukselenWebAPI.DAL.ViewModel;

namespace YukselenWebAPI.BL.Services
{
    public class SubdoshaFormPoint
    {
        readonly ISurveyResultWriteRepository _surveyResultWriteRepository;
        readonly ISurveyResultReadRepository _surveyResultReadRepository;
        private readonly IMemoryCache _memCache;

        public SubdoshaFormPoint( IMemoryCache memCache, ISurveyResultWriteRepository surveyResultWriteRepository, ISurveyResultReadRepository surveyResultReadRepository)
        {
            _memCache = memCache;
            _surveyResultWriteRepository = surveyResultWriteRepository;
            _surveyResultReadRepository = surveyResultReadRepository;
        }

        public async Task FormPointCreate(VM_Subdosha vM_Subdosha)
        {
            int f1_vata_totalCount = 0,
                f1_pıtta_totalCount = 0,
                f1_kapha_totalCount = 0,
                f2_vata_zihin_totalCount = 0,
                f2_vata_beden_totalCount = 0,
                f3_pıtta_zihin_totalCount = 0,
                f3_pıtta_beden_totalCount = 0,
                f4_kapha_zihin_totalCount = 0,
                f4_kapha_beden_totalCount = 0;

            f1_vata_totalCount = vM_Subdosha.f1_vata.Sum();
            f1_pıtta_totalCount = vM_Subdosha.f1_pıtta.Sum();
            f1_kapha_totalCount = vM_Subdosha.f1_kapha.Sum();

            f2_vata_zihin_totalCount = vM_Subdosha.f2_vata_zihin_1 + vM_Subdosha.f2_vata_zihin_2 + vM_Subdosha.f2_vata_zihin_3 + vM_Subdosha.f2_vata_zihin_4 +
                vM_Subdosha.f2_vata_zihin_5 + vM_Subdosha.f2_vata_zihin_6 + vM_Subdosha.f2_vata_zihin_7 + vM_Subdosha.f2_vata_zihin_8 + vM_Subdosha.f2_vata_zihin_9 +
                vM_Subdosha.f2_vata_zihin_10;

            f2_vata_beden_totalCount = vM_Subdosha.f2_vata_beden_1 + vM_Subdosha.f2_vata_beden_2 + vM_Subdosha.f2_vata_beden_3 + vM_Subdosha.f2_vata_beden_4 +
                vM_Subdosha.f2_vata_beden_5 + vM_Subdosha.f2_vata_beden_6 + vM_Subdosha.f2_vata_beden_7 + vM_Subdosha.f2_vata_beden_8 + vM_Subdosha.f2_vata_beden_9 +
                vM_Subdosha.f2_vata_beden_10;

            f3_pıtta_zihin_totalCount = vM_Subdosha.f3_pıtta_zihin_1 + vM_Subdosha.f3_pıtta_zihin_2 + vM_Subdosha.f3_pıtta_zihin_3 + vM_Subdosha.f3_pıtta_zihin_4 +
                vM_Subdosha.f3_pıtta_zihin_5 + vM_Subdosha.f3_pıtta_zihin_6 + vM_Subdosha.f3_pıtta_zihin_7 + vM_Subdosha.f3_pıtta_zihin_8 + vM_Subdosha.f3_pıtta_zihin_9 +
                vM_Subdosha.f3_pıtta_zihin_10;

            f3_pıtta_beden_totalCount = vM_Subdosha.f3_pıtta_beden_1 + vM_Subdosha.f3_pıtta_beden_2 + vM_Subdosha.f3_pıtta_beden_3 + vM_Subdosha.f3_pıtta_beden_4 +
                vM_Subdosha.f3_pıtta_beden_5 + vM_Subdosha.f3_pıtta_beden_6 + vM_Subdosha.f3_pıtta_beden_7 + vM_Subdosha.f3_pıtta_beden_8 + vM_Subdosha.f3_pıtta_beden_9 +
                vM_Subdosha.f3_pıtta_beden_10;

            f4_kapha_zihin_totalCount = vM_Subdosha.f4_kapha_zihin_1 + vM_Subdosha.f4_kapha_zihin_2 + vM_Subdosha.f4_kapha_zihin_3 + vM_Subdosha.f4_kapha_zihin_4 +
                vM_Subdosha.f4_kapha_zihin_5 + vM_Subdosha.f4_kapha_zihin_6 + vM_Subdosha.f4_kapha_zihin_7 + vM_Subdosha.f4_kapha_zihin_8 + vM_Subdosha.f4_kapha_zihin_9 +
                vM_Subdosha.f4_kapha_zihin_10;

            f4_kapha_beden_totalCount = vM_Subdosha.f4_kapha_beden_1 + vM_Subdosha.f4_kapha_beden_2 + vM_Subdosha.f4_kapha_beden_3 + vM_Subdosha.f4_kapha_beden_4 +
                vM_Subdosha.f4_kapha_beden_5 + vM_Subdosha.f4_kapha_beden_6 + vM_Subdosha.f4_kapha_beden_7 + vM_Subdosha.f4_kapha_beden_8 + vM_Subdosha.f4_kapha_beden_9 +
                vM_Subdosha.f4_kapha_beden_10;


            
            var surveyResult = _surveyResultReadRepository.GetAll().ToArray();

            YukselenWebAPI.EntityLayer.Entities.SurveyResult form1_vata = new YukselenWebAPI.EntityLayer.Entities.SurveyResult
            {
                Id = surveyResult[surveyResult.Length - 1].Id + 1,
                Deger = f1_vata_totalCount,
                FormID = 9,
                AnketID = 1,
                Deger2 = f1_vata_totalCount,
                Sonuc = "Bos",
                Sonuc2 = "Bos"
            };

            await _surveyResultWriteRepository.AddAsync(form1_vata);

            YukselenWebAPI.EntityLayer.Entities.SurveyResult form1_pıtta = new YukselenWebAPI.EntityLayer.Entities.SurveyResult
            {
                Id = surveyResult[surveyResult.Length - 1].Id + 2,
                Deger = f1_pıtta_totalCount,
                FormID = 10,
                AnketID = 1,
                Deger2 = f1_pıtta_totalCount,
                Sonuc = "Bos",
                Sonuc2 = "Bos"
            };

            await _surveyResultWriteRepository.AddAsync(form1_pıtta);

            YukselenWebAPI.EntityLayer.Entities.SurveyResult form1_kapha = new YukselenWebAPI.EntityLayer.Entities.SurveyResult
            {
                Id = surveyResult[surveyResult.Length - 1].Id + 3,
                Deger = f1_kapha_totalCount,
                FormID = 11,
                AnketID = 1,
                Deger2 = f1_kapha_totalCount,
                Sonuc = "Bos",
                Sonuc2 = "Bos"
            };

            await _surveyResultWriteRepository.AddAsync(form1_kapha);

            YukselenWebAPI.EntityLayer.Entities.SurveyResult form2_vata_zihin = new YukselenWebAPI.EntityLayer.Entities.SurveyResult
            {
                Id = surveyResult[surveyResult.Length - 1].Id + 4,
                Deger = f2_vata_zihin_totalCount,
                FormID = 13,
                AnketID = 2,
                Deger2 = f2_vata_zihin_totalCount,
                Sonuc = "Bos",
                Sonuc2 = "Bos"
            };

            await _surveyResultWriteRepository.AddAsync(form2_vata_zihin);

            YukselenWebAPI.EntityLayer.Entities.SurveyResult form2_vata_beden = new YukselenWebAPI.EntityLayer.Entities.SurveyResult
            {
                Id = surveyResult[surveyResult.Length - 1].Id + 5,
                Deger = f2_vata_beden_totalCount,
                FormID = 14,
                AnketID = 2,
                Deger2 = f2_vata_beden_totalCount,
                Sonuc = "Bos",
                Sonuc2 = "Bos"
            };

            await _surveyResultWriteRepository.AddAsync(form2_vata_beden);


            YukselenWebAPI.EntityLayer.Entities.SurveyResult form3_pıtta_zihin = new YukselenWebAPI.EntityLayer.Entities.SurveyResult
            {
                Id = surveyResult[surveyResult.Length - 1].Id + 6,
                Deger = f3_pıtta_zihin_totalCount,
                FormID = 15,
                AnketID = 3,
                Deger2 = f3_pıtta_zihin_totalCount,
                Sonuc = "Bos",
                Sonuc2 = "Bos"
            };

            await _surveyResultWriteRepository.AddAsync(form3_pıtta_zihin);

            YukselenWebAPI.EntityLayer.Entities.SurveyResult form3_pıtta_beden = new YukselenWebAPI.EntityLayer.Entities.SurveyResult
            {
                Id = surveyResult[surveyResult.Length - 1].Id + 7,
                Deger = f3_pıtta_beden_totalCount,
                FormID = 16,
                AnketID = 3,
                Deger2 = f3_pıtta_beden_totalCount,
                Sonuc = "Bos",
                Sonuc2 = "Bos"
            };

            await _surveyResultWriteRepository.AddAsync(form3_pıtta_beden);


            YukselenWebAPI.EntityLayer.Entities.SurveyResult form4_kapha_zihin = new YukselenWebAPI.EntityLayer.Entities.SurveyResult
            {
                Id = surveyResult[surveyResult.Length - 1].Id + 8,
                Deger = f4_kapha_zihin_totalCount,
                FormID = 17,
                AnketID = 4,
                Deger2 = f4_kapha_zihin_totalCount,
                Sonuc = "Bos",
                Sonuc2 = "Bos"
            };

            await _surveyResultWriteRepository.AddAsync(form4_kapha_zihin);

            YukselenWebAPI.EntityLayer.Entities.SurveyResult form4_kapha_beden = new YukselenWebAPI.EntityLayer.Entities.SurveyResult
            {
                Id = surveyResult[surveyResult.Length - 1].Id + 9,
                Deger = f4_kapha_beden_totalCount,
                FormID = 18,
                AnketID = 4,
                Deger2 = f4_kapha_beden_totalCount,
                Sonuc = "Bos",
                Sonuc2 = "Bos"
            };

            await _surveyResultWriteRepository.AddAsync(form4_kapha_beden);
            //await _surveyResultWriteRepository.SaveAsync();

            _memCache.Remove("userCreate");
        }

    }
}
