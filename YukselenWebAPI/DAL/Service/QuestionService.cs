using Microsoft.EntityFrameworkCore;
using YukselenWebAPI.BL.Repositories.Question;
using YukselenWebAPI.BL.Services;
using YukselenWebAPI.EntityLayer.Entities;

namespace YukselenWebAPI.DAL.Service
{
    public class QuestionService : IQuestionService
    {
        readonly IQuestionReadRepository _questionReadRepository;

        public QuestionService(IQuestionReadRepository questionReadRepository)
        {
            _questionReadRepository = questionReadRepository;
        }

        public async Task<List<Question>> GetQuestionsAsync(string formName)
        {
            List<Question> result = null;
            switch (formName)
            {
                case "form1Vata":
                    result = await _questionReadRepository.GetWhere(f1 => f1.FormID == 9).ToListAsync();
                    return result;
                case "form1Pitta":
                    result = await _questionReadRepository.GetWhere(f1 => f1.FormID == 10).ToListAsync();
                    return result;
                case "form1Kapha":
                    result = await _questionReadRepository.GetWhere(f1 => f1.FormID == 11).ToListAsync();
                    return result;
                case "form2VataZihin":
                    result = await _questionReadRepository.GetWhere(f1 => f1.FormID == 13).ToListAsync();
                    return result;
                case "form2VataBeden":
                    result = await _questionReadRepository.GetWhere(f1 => f1.FormID == 14).ToListAsync();
                    return result;
                case "form3PittaZihin":
                    result = await _questionReadRepository.GetWhere(f1 => f1.FormID == 15).ToListAsync();
                    return result;
                case "form3PittaBeden":
                    result = await _questionReadRepository.GetWhere(f1 => f1.FormID == 16).ToListAsync();
                    return result;
                case "form4KaphaZihin":
                    result = await _questionReadRepository.GetWhere(f1 => f1.FormID == 17).ToListAsync();
                    return result;
                case "form4KaphaBeden":
                    result = await _questionReadRepository.GetWhere(f1 => f1.FormID == 18).ToListAsync();
                    return result;
                default:
                    return result;
            }
        }
    }
}
