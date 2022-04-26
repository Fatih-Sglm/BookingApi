using KodHub.Domain.Entities.Common;

namespace KodHub.Domain.Entities
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string BlogContent { get; set; }
        public Guid CategoryId { get; set; }
        public Guid WriterId { get; set; }
        public Category Category { get; set; }
        public Writer Writer { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
