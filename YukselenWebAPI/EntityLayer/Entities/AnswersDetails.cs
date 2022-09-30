using System;
using YukselenWebAPI.EntityLayer.Entities.Common;

namespace YukselenWebAPI.EntityLayer.Entities
{
    public class AnswersDetails : BaseEntity
    {
        public Nullable<int> AnswersID { get; set; }
        public Nullable<int> QuestionsID { get; set; }
        public Nullable<int> Value { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
