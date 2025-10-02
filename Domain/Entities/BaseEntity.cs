namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
        public DateTime? DeletedAt { get; private set; }

        public int CreatedBy { get; private set; }
        public int? UpdatedBy { get; private set; }
        public int? DeletedBy { get; private set; }

        public void MarkCreated(int userId)
        {
            CreatedBy = userId;
            CreatedAt = DateTime.UtcNow;
            IsDeleted = false;
        }

        public void MarkUpdated(int userId)
        {
            UpdatedBy = userId;
            UpdatedAt = DateTime.UtcNow;
        }

        public void MarkDeleted(int userId)
        {
            DeletedBy = userId;
            DeletedAt = DateTime.UtcNow;
            IsDeleted = true;
        }
    }

}
