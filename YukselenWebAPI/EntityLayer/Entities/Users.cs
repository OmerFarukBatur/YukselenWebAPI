using System;
using System.ComponentModel.DataAnnotations;
using YukselenWebAPI.EntityLayer.Entities.Common;

namespace YukselenWebAPI.EntityLayer.Entities
{
    public class Users : BaseEntity
    {
        [StringLength(250)]
        public string? MailAdress { get; set; }
        public string? NameSurname { get; set; }
        public DateTime? BirthDate { get; set; }
        [StringLength(1)]
        public string? Gender { get; set; }
        [StringLength(10)]
        public string? Password { get; set; }
        public bool? IsActive { get; set; }

    }
}
