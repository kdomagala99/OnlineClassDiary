using System.Collections.Generic;

namespace OnlineClassDiaryWebAPI.Dtos
{
    public class ClassDto
    {
        public string Name { get; set; }
        public UserDto Teacher { get; set; }
        public List<UserDto> Students_List { get; set; }
        public string Description { get; set; }

    }
}
