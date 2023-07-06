using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Entities
{
    public class Register : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string? Message { get; set; }
    }
}
