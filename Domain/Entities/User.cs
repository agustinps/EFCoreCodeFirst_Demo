﻿namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string NormalizedMail { get; set; }
        public string PasswordHash { get; set; }        
    }
}
