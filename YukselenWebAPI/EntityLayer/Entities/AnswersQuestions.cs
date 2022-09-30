using System;
using YukselenWebAPI.EntityLayer.Entities.Common;

namespace YukselenWebAPI.EntityLayer.Entities
{
    public class AnswersQuestions : BaseEntity
    {
        public Nullable<int> QuestionsID { get; set; }
        public Nullable<int> AnswersID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> SplashPuan { get; set; }
        public Nullable<int> FormID { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
