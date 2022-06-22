namespace OnlineClassDiaryWebAPI.Entities
{
    public class User
    {
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
#nullable disable
    }
}
