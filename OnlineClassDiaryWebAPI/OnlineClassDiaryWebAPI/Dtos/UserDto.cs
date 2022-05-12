namespace OnlineClassDiaryWebAPI.Dtos
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }
        public string PESEL { get; set; }
        public RoleDto Role { get; set; }
#nullable enable
        public ClassDto? Class { get; set;}
        public UserDto? Child { get; set; }
#nullable disable
    }
}
