namespace Domain.Entities
{
    public class Movement : BaseEntity
    {
        public int UserId { get; set; }
        public int MovementTypeId { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }
        public decimal Amount { get; set; }
        public DateTime MovementDate { get; set; }     
        public string Notes { get; set; }
        public User User { get; set; }
        public MovementType MovementType { get; set; }
        public Account Account { get; set; }
        public Category Category { get; set; }
    }
}
