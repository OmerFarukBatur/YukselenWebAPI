using System;
using System.ComponentModel.DataAnnotations;
using YukselenWebAPI.EntityLayer.Entities.Common;

namespace YukselenWebAPI.EntityLayer.Entities
{
    public class Question : BaseEntity
    {
        [StringLength(250)]
        public string? Questions { get; set; }
        public Nullable<int> FormID { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
