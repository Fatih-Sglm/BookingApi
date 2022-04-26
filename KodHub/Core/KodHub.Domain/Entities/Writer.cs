using KodHub.Domain.Entities.Common;

namespace KodHub.Domain.Entities
{
    public class Writer : BaseEntity
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string linkedinAccount { get; set; }
        public string GitHubAccount { get; set; }
        public string PersonelWebsite { get; set; }
        public bool isAdmin { get; set; }

    }
}
