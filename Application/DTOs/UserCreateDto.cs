﻿namespace Application.DTOs
{
    public class UserCreateDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string NormalizedMail { get; set; }
        public string PasswordHash { get; set; }
    }
}
