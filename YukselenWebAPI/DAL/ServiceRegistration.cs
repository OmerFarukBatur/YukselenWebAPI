using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using YukselenWebAPI.BL.Repositories.AnswerQuestionsWellBeing;
using YukselenWebAPI.BL.Repositories.Answers;
using YukselenWebAPI.BL.Repositories.AnswersDetails;
using YukselenWebAPI.BL.Repositories.AnswersQuestions;
using YukselenWebAPI.BL.Repositories.Formlar;
using YukselenWebAPI.BL.Repositories.Question;
using YukselenWebAPI.BL.Repositories.QuestionsWellBeing;
using YukselenWebAPI.BL.Repositories.SurveyResult;
using YukselenWebAPI.BL.Repositories.User;
using YukselenWebAPI.BL.Services;
using YukselenWebAPI.DAL.Context;
using YukselenWebAPI.DAL.Repositories.Answer;
using YukselenWebAPI.DAL.Repositories.AnswerQuestionsWellBeing;
using YukselenWebAPI.DAL.Repositories.AnswersDetails;
using YukselenWebAPI.DAL.Repositories.AnswersDetails_;
using YukselenWebAPI.DAL.Repositories.AnswersQuestions;
using YukselenWebAPI.DAL.Repositories.Formlar;
using YukselenWebAPI.DAL.Repositories.Question;
using YukselenWebAPI.DAL.Repositories.QuestionsWellBeing;
using YukselenWebAPI.DAL.Repositories.SurveyResult;
using YukselenWebAPI.DAL.Repositories.User;
using YukselenWebAPI.DAL.Service;

namespace YukselenWebAPI.DAL
{
    public static class ServiceRegistration
    {
        public static void AddDALServices(this IServiceCollection services)
        {
            //services.AddDbContext<YukselenDBContext>(options => options.UseSqlServer(Configuration.ConfigurationString));

            services.AddScoped<IAnswerReadRepository, AnswerReadRepository>();
            services.AddScoped<IAnswerWriteRepository, AnswerWriteRepository>();

            services.AddScoped<IAnswerQuestionsWellBeingReadRepository, AnswerQuestionsWellBeingReadRepository>();
            services.AddScoped<IAnswerQuestionsWellBeingWriteRepository, AnswerQuestionsWellBeingWriteRepository>();            

            services.AddScoped<IAnswersDetailsReadRepository, AnswersDetailsReadRepository>();
            services.AddScoped<IAnswersDetailsWriteRepository, AnswersDetailsWriteRepository>();

            services.AddScoped<IAnswersDetails_ReadRepository, AnswersDetails_ReadRepository>();
            services.AddScoped<IAnswersDetails_WriteRepository, AnswersDetails_WriteRepository>();

            services.AddScoped<IAnswersQuestionsReadRepository, AnswersQuestionsReadRepository>();
            services.AddScoped<IAnswersQuestionsWriteRepository, AnswersQuestionsWriteRepository>();

            services.AddScoped<IFormlarReadRepository, FormlarReadRepository>();
            services.AddScoped<IFormlarWriteRepository, FormlarWriteRepository>();

            services.AddScoped<IQuestionReadRepository, QuestionReadRepository>();
            services.AddScoped<IQuestionWriteRepository, QuestionWriteRepository>();

            services.AddScoped<IQuestionsWellBeingReadRepository, QuestionsWellBeingReadRepository>();
            services.AddScoped<IQuestionsWellBeingWriteRepository, QuestionsWellBeingWriteRepository>();

            services.AddScoped<ISurveyResultReadRepository, SurveyResultReadRepository>();
            services.AddScoped<ISurveyResultWriteRepository, SurveyResultWriteRepository>();

            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();


            services.AddScoped<IQuestionService, QuestionService>();
        }
    }
}
