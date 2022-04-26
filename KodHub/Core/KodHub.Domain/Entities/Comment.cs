using KodHub.Domain.Entities.Common;

namespace KodHub.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool isAdmin { get; set; }
        public Guid BlogId { get; set; }
        public Blog Blog { get; set; }


    }
}
