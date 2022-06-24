using System;

namespace OnlineClassDiaryWebAPI.Entities
{
    public class User
    {
        public User()
        {
            Name = String.Empty;
            Surname = String.Empty;
            PESEL = String.Empty;
            PasswordHash = String.Empty;
            Email = String.Empty;
            Role = new();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PESEL { get; set; }
        public string PasswordHash { get; set; }
        public virtual Role Role { get; set; }
#nullable enable
        public virtual User? Child { get; set; }
        public virtual Class? Class { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   Id == user.Id &&
                   Name == user.Name &&
                   Surname == user.Surname &&
                   Email == user.Email &&
                   PESEL == user.PESEL;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Surname, Email, PESEL);
        }
#nullable disable
    }
}
