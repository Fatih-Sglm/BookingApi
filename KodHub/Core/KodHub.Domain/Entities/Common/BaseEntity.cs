namespace KodHub.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdadeAt { get; set; }
        public bool Status { get; set; } = false;
    }

}
