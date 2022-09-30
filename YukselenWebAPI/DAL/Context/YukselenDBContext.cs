using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using YukselenWebAPI.EntityLayer.Entities;
using YukselenWebAPI.EntityLayer.Entities.Common;

namespace YukselenWebAPI.DAL.Context
{
    public class YukselenDBContext : DbContext
    {
        public YukselenDBContext(DbContextOptions<YukselenDBContext> options)
        : base(options)
        {
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<AnswerQuestionsWellBeing> AnswerQuestionsWellBeing { get; set; }
        public DbSet<AnswersDetails> AnswersDetails { get; set; }
        public DbSet<AnswersDetails_> AnswersDetails_ { get; set; }
        public DbSet<AnswersQuestions> AnswersQuestions { get; set; }
        public DbSet<Formlar> Formlar { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionsWellBeing> QuestionsWellBeing { get; set; }
        public DbSet<SurveyResult> SurveyResult { get; set; }
        public DbSet<Users> Users { get; set; }

        }
}
