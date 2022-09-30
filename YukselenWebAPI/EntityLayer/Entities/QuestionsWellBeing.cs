using YukselenWebAPI.EntityLayer.Entities.Common;

namespace YukselenWebAPI.EntityLayer.Entities
{
    public class QuestionsWellBeing : BaseEntity
    {
        public string? Questions { get; set; }
        public bool? IsActive { get; set; }
    }
}
