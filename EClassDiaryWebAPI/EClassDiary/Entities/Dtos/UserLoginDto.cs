﻿namespace OnlineClassDiaryWebAPI.Entities.Dtos
{
    public class UserLoginDto
    {
        public UserLoginDto()
        {
            Role = String.Empty;
            Name = String.Empty;
            Surname = String.Empty;
        }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
