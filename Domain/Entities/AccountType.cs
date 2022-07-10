namespace Domain.Entities
{
    public class AccountType : BaseEntity
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public int OrderMov { get; set; }
        public User Users { get; set; }        
    }
}
