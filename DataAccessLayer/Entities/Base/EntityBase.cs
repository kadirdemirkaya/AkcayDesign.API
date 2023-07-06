using Dapper.Contrib.Extensions;

namespace DataAccessLayer.Entities.Base
{
    public class EntityBase
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime? DeletedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public bool IsSuccess { get; set; } = true;
    }
}
