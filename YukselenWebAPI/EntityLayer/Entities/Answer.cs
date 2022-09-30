using System;
using System.ComponentModel.DataAnnotations;
using YukselenWebAPI.EntityLayer.Entities.Common;

namespace YukselenWebAPI.EntityLayer.Entities
{
    public class Answer : BaseEntity
    {
        [StringLength(150)]
        public string? Answers { get; set; }
    }
}
