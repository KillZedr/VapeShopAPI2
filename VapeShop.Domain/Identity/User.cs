﻿namespace VapeShop.Domain.Identity

{
    public class User : Entity<int>
    {
       
        public required string FirstName { get; set; }
        public string? LastName { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public required string PasswordSalt { get; set; }

        public required UserRole Role { get; set; }
        public required UserSettings UserSettings { get; set; }


        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(LastName))
                {
                    return FirstName;
                }
                return $"{FirstName} {LastName}";
            }
        }
    }
}
