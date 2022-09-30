using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using YukselenWebAPI.BL.Repositories.AnswersQuestions;
using YukselenWebAPI.BL.Repositories.Question;
using YukselenWebAPI.BL.Repositories.User;
using YukselenWebAPI.DAL.ViewModel;

namespace YukselenWebAPI.BL.Services
{
    public class SubdoshaQuestionsCreate
    {
        readonly IQuestionReadRepository _questionsRead;
        readonly IAnswersQuestionsWriteRepository _answersQuestionsWriteRepository;

        public SubdoshaQuestionsCreate(IQuestionReadRepository questionsRead, IAnswersQuestionsWriteRepository answersQuestionsWriteRepository)
        {
            _questionsRead = questionsRead;
            _answersQuestionsWriteRepository = answersQuestionsWriteRepository;
        }

        public async Task FormOneQuestionsCreate(VM_Subdosha vM_Subdosha, int userId)
        {

            var f1_vata = await _questionsRead.GetWhere(f1 => f1.FormID == 9).ToArrayAsync();
            var f1_pıtta = await _questionsRead.GetWhere(f1 => f1.FormID == 10).ToArrayAsync();
            var f1_kapha = await _questionsRead.GetWhere(f1 => f1.FormID == 11).ToArrayAsync();


             //5 = Beni oldukça doğru bir şekilde temsil ediyor 12
             //3 = Beni ikinci dereceden temsil ediyor 11 
             //1 = Beni nadiren temsil ediyor 10
             // diger degerler null 13
            for (int i = 0; i < f1_vata.Length; i++)
            {
                YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form1_vata = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
                {
                    QuestionsID = f1_vata[i].Id,
                    AnswersID = FormOneResult(vM_Subdosha.f1_vata[i]),
                    UserID = userId,
                    SplashPuan = vM_Subdosha.f1_vata[i],
                    FormID = f1_vata[i].FormID,
                    CreateDate = DateTime.Now
                };

                 await _answersQuestionsWriteRepository.AddAsync(form1_vata);
                 //await  _answersQuestionsWriteRepository.SaveAsync();

            }

            for (int j = 0; j < f1_pıtta.Length; j++)
            {
                YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form1_pıtta = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
                {
                    QuestionsID = f1_pıtta[j].Id,
                    AnswersID = FormOneResult(vM_Subdosha.f1_pıtta[j]),
                    UserID = userId,
                    SplashPuan = vM_Subdosha.f1_pıtta[j],
                    FormID = f1_pıtta[j].FormID,
                    CreateDate = DateTime.Now
                };

                 await _answersQuestionsWriteRepository.AddAsync(form1_pıtta);
                 //await _answersQuestionsWriteRepository.SaveAsync();


            }

            for (int k = 0; k < f1_kapha.Length; k++)
            {
                YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form1_kapha = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
                {
                    QuestionsID = f1_kapha[k].Id,
                    AnswersID = FormOneResult(vM_Subdosha.f1_kapha[k]),
                    UserID = userId,
                    SplashPuan = vM_Subdosha.f1_kapha[k],
                    FormID = f1_kapha[k].FormID,
                    CreateDate = DateTime.Now
                };

                 await _answersQuestionsWriteRepository.AddAsync(form1_kapha);
                 //await _answersQuestionsWriteRepository.SaveAsync();
            }
        }

        public int FormOneResult(int value)
        {
            switch (value)
            {
                case 1:
                    return 10;
                case 3:
                    return 11;
                case 5:
                    return 12;
                default:
                    return 16;
            }
        }

        public async Task FormTwoQuestionsCreate(VM_Subdosha vM_Subdosha, int userId)
        {
             // 83 -92

            var f2VataZihin = await _questionsRead.GetWhere(f2z => f2z.FormID == 13).ToArrayAsync();
            var f2VataBeden = await _questionsRead.GetWhere(f2b => f2b.FormID == 14).ToArrayAsync();


            // ASLA 1      13
            // BAZEN 3     14
            // SIKLIKLA 5  15
            // BOŞ         16

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_zihin_1 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataZihin[0].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_zihin_1),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_zihin_1,
                FormID = f2VataZihin[0].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_zihin_1);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_zihin_2 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataZihin[1].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_zihin_2),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_zihin_2,
                FormID = f2VataZihin[1].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_zihin_2);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_zihin_3 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataZihin[2].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_zihin_3),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_zihin_3,
                FormID = f2VataZihin[2].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_zihin_3);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_zihin_4 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataZihin[3].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_zihin_4),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_zihin_4,
                FormID = f2VataZihin[3].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_zihin_4);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_zihin_5 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataZihin[4].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_zihin_5),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_zihin_5,
                FormID = f2VataZihin[4].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_zihin_5);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_zihin_6 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataZihin[5].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_zihin_6),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_zihin_6,
                FormID = f2VataZihin[5].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_zihin_6);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_zihin_7 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataZihin[6].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_zihin_7),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_zihin_7,
                FormID = f2VataZihin[6].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_zihin_7);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_zihin_8 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataZihin[7].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_zihin_8),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_zihin_8,
                FormID = f2VataZihin[7].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_zihin_8);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_zihin_9 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataZihin[8].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_zihin_9),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_zihin_9,
                FormID = f2VataZihin[8].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_zihin_9);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_zihin_10 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataZihin[9].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_zihin_10),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_zihin_10,
                FormID = f2VataZihin[9].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_zihin_10);



            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_beden_1 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataBeden[0].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_beden_1),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_beden_1,
                FormID = f2VataBeden[0].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_beden_1);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_beden_2 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataBeden[1].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_beden_2),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_beden_2,
                FormID = f2VataBeden[1].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_beden_2);



            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_beden_3 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataBeden[2].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_beden_3),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_beden_3,
                FormID = f2VataBeden[2].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_beden_3);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_beden_4 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataBeden[3].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_beden_4),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_beden_4,
                FormID = f2VataBeden[3].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_beden_4);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_beden_5 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataBeden[4].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_beden_5),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_beden_5,
                FormID = f2VataBeden[4].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_beden_5);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_beden_6 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataBeden[5].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_beden_6),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_beden_6,
                FormID = f2VataBeden[5].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_beden_6);



            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_beden_7 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataBeden[6].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_beden_7),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_beden_7,
                FormID = f2VataBeden[6].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_beden_7);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_beden_8 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataBeden[7].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_beden_8),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_beden_8,
                FormID = f2VataBeden[7].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_beden_8);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_beden_9 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataBeden[8].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_beden_9),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_beden_9,
                FormID = f2VataBeden[8].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_beden_9);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form2_vata_beden_10 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f2VataBeden[9].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f2_vata_beden_10),
                UserID = userId,
                SplashPuan = vM_Subdosha.f2_vata_beden_10,
                FormID = f2VataBeden[9].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form2_vata_beden_10);


             //await _answersQuestionsWriteRepository.SaveAsync();
        }


        public async Task FormThreeQuestionsCreate(VM_Subdosha vM_Subdosha, int userId)
        {
            

            var f3PittaZihin = await _questionsRead.GetWhere(f3z => f3z.FormID == 15).ToArrayAsync();
            var f3PittaBeden = await _questionsRead.GetWhere(f3b => f3b.FormID == 16).ToArrayAsync();

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_zihin_1 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaZihin[0].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_zihin_1),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_zihin_1,
                FormID = f3PittaZihin[0].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_zihin_1);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_zihin_2 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaZihin[1].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_zihin_2),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_zihin_2,
                FormID = f3PittaZihin[1].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_zihin_2);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_zihin_3 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaZihin[2].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_zihin_3),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_zihin_3,
                FormID = f3PittaZihin[2].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_zihin_3);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_zihin_4 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaZihin[3].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_zihin_4),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_zihin_4,
                FormID = f3PittaZihin[3].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_zihin_4);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_zihin_5 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaZihin[4].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_zihin_5),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_zihin_5,
                FormID = f3PittaZihin[4].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_zihin_5);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_zihin_6 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaZihin[5].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_zihin_6),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_zihin_6,
                FormID = f3PittaZihin[5].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_zihin_6);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_zihin_7 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaZihin[6].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_zihin_7),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_zihin_7,
                FormID = f3PittaZihin[6].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_zihin_7);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_zihin_8 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaZihin[7].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_zihin_8),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_zihin_8,
                FormID = f3PittaZihin[7].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_zihin_8);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_zihin_9 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaZihin[8].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_zihin_9),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_zihin_9,
                FormID = f3PittaZihin[8].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_zihin_9);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_zihin_10 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaZihin[9].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_zihin_10),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_zihin_10,
                FormID = f3PittaZihin[9].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_zihin_10);



            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_beden_1 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaBeden[0].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_beden_1),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_beden_1,
                FormID = f3PittaBeden[0].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_beden_1);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_beden_2 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaBeden[1].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_beden_2),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_beden_2,
                FormID = f3PittaBeden[1].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_beden_2);



            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_beden_3 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaBeden[2].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_beden_3),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_beden_3,
                FormID = f3PittaBeden[2].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_beden_3);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_beden_4 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaBeden[3].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_beden_4),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_beden_4,
                FormID = f3PittaBeden[3].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_beden_4);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_beden_5 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaBeden[4].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_beden_5),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_beden_5,
                FormID = f3PittaBeden[4].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_beden_5);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_beden_6 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaBeden[5].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_beden_6),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_beden_6,
                FormID = f3PittaBeden[5].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_beden_6);



            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_beden_7 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaBeden[6].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_beden_7),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_beden_7,
                FormID = f3PittaBeden[6].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_beden_7);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_beden_8 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaBeden[7].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_beden_8),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_beden_8,
                FormID = f3PittaBeden[7].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_beden_8);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_beden_9 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaBeden[8].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_beden_9),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_beden_9,
                FormID = f3PittaBeden[8].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_beden_9);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form3_pıtta_beden_10 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f3PittaBeden[9].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f3_pıtta_beden_10),
                UserID = userId,
                SplashPuan = vM_Subdosha.f3_pıtta_beden_10,
                FormID = f3PittaBeden[9].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form3_pıtta_beden_10);


             //await _answersQuestionsWriteRepository.SaveAsync();
        }


        public async Task FormFourQuestionsCreate(VM_Subdosha vM_Subdosha, int userId)
        {
            

            var f4KaphaZihin = await _questionsRead.GetWhere(f4z => f4z.FormID == 17).ToArrayAsync();
            var f4KaphaBeden = await _questionsRead.GetWhere(f4b => f4b.FormID == 18).ToArrayAsync();

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_zihin_1 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaZihin[0].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_zihin_1),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_zihin_1,
                FormID = f4KaphaZihin[9].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_zihin_1);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_zihin_2 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaZihin[1].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_zihin_2),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_zihin_2,
                FormID = f4KaphaZihin[1].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_zihin_2);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_zihin_3 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaZihin[2].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_zihin_3),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_zihin_3,
                FormID = f4KaphaZihin[2].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_zihin_3);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_zihin_4 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaZihin[3].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_zihin_4),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_zihin_4,
                FormID = f4KaphaZihin[3].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_zihin_4);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_zihin_5 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaZihin[4].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_zihin_5),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_zihin_5,
                FormID = f4KaphaZihin[4].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_zihin_5);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_zihin_6 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaZihin[5].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_zihin_6),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_zihin_6,
                FormID = f4KaphaZihin[5].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_zihin_6);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_zihin_7 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaZihin[6].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_zihin_7),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_zihin_7,
                FormID = f4KaphaZihin[6].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_zihin_7);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_zihin_8 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaZihin[7].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_zihin_8),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_zihin_8,
                FormID = f4KaphaZihin[7].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_zihin_8);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_zihin_9 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaZihin[8].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_zihin_9),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_zihin_9,
                FormID = f4KaphaZihin[8].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_zihin_9);

            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_zihin_10 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaZihin[9].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_zihin_10),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_zihin_10,
                FormID = f4KaphaZihin[9].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_zihin_10);



            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_beden_1 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaBeden[0].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_beden_1),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_beden_1,
                FormID = f4KaphaBeden[0].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_beden_1);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_beden_2 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaBeden[1].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_beden_2),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_beden_2,
                FormID = f4KaphaBeden[1].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_beden_2);



            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_beden_3 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaBeden[2].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_beden_3),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_beden_3,
                FormID = f4KaphaBeden[2].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_beden_3);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_beden_4 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaBeden[3].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_beden_4),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_beden_4,
                FormID = f4KaphaBeden[3].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_beden_4);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_beden_5 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaBeden[4].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_beden_5),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_beden_5,
                FormID = f4KaphaBeden[4].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_beden_5);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_beden_6 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaBeden[5].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_beden_6),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_beden_6,
                FormID = f4KaphaBeden[5].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_beden_6);



            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_beden_7 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaBeden[6].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_beden_7),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_beden_7,
                FormID = f4KaphaBeden[6].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_beden_7);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_beden_8 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaBeden[7].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_beden_8),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_beden_8,
                FormID = f4KaphaBeden[7].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_beden_8);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_beden_9 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaBeden[8].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_beden_9),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_beden_9,
                FormID = f4KaphaBeden[8].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_beden_9);


            YukselenWebAPI.EntityLayer.Entities.AnswersQuestions form4_kapha_beden_10 = new YukselenWebAPI.EntityLayer.Entities.AnswersQuestions
            {
                QuestionsID = f4KaphaBeden[9].Id,
                AnswersID = FormTwoResult(vM_Subdosha.f4_kapha_beden_10),
                UserID = userId,
                SplashPuan = vM_Subdosha.f4_kapha_beden_10,
                FormID = f4KaphaBeden[9].FormID,
                CreateDate = DateTime.Now
            };

            await _answersQuestionsWriteRepository.AddAsync(form4_kapha_beden_10);


             //await _answersQuestionsWriteRepository.SaveAsync();
        }

        public int FormTwoResult(int value)
        {
            switch (value)
            {
                case 1:
                    return 13;
                case 3:
                    return 14;
                case 5:
                    return 15;
                default:
                    return 16;
            }
        }

    }
}
