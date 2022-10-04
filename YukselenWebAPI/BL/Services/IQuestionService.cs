using YukselenWebAPI.EntityLayer.Entities;

namespace YukselenWebAPI.BL.Services
{
    public interface IQuestionService
    {
        public Task<List<Question>> GetQuestionsAsync(string formName);
    }
}
