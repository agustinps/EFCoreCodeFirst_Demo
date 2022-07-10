namespace Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public int MovementTypeId { get; set; }
        public User User { get; set; }
        public MovementType MovementType { get; set; }
    }
}
