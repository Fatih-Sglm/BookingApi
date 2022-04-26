using KodHub.Domain.Entities.Common;

namespace KodHub.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}
