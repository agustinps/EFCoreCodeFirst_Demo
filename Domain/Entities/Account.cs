namespace Domain.Entities
{
    public class Account : BaseEntity
    {
        public string Name { get; set; }        
        public decimal Balance { get; set; }
        public string Description { get; set; }
        public int AccountTypeId { get; set; }
        public AccountType AccountType { get; set; }
    }
}
