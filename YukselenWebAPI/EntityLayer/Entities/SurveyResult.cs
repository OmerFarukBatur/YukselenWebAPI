using System;
using System.ComponentModel.DataAnnotations;
using YukselenWebAPI.EntityLayer.Entities.Common;

namespace YukselenWebAPI.EntityLayer.Entities
{
    public class SurveyResult : BaseEntity
    {
        public Nullable<int> Deger { get; set; }
        public Nullable<int> Deger2 { get; set; }
        public string? Sonuc { get; set; }
        [StringLength(250)]
        public string? Sonuc2 { get; set; }
        public Nullable<int> FormID { get; set; }
        public Nullable<int> AnketID { get; set; }
    }
}
