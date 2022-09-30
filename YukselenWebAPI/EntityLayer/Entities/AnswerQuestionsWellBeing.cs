using System;
using YukselenWebAPI.EntityLayer.Entities.Common;

namespace YukselenWebAPI.EntityLayer.Entities
{
    public class AnswerQuestionsWellBeing : BaseEntity
    {
        public Nullable<int> UserID { get; set; }
        public Nullable<int> QuestionID { get; set; }
        public Nullable<int> AnswersPuan { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
