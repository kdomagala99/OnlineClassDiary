using System.Collections.Generic;

namespace OnlineClassDiaryWebAPI.Entities
{
    public class Class
    {
        public Class()
        {
            Name = string.Empty;
            Teacher = new();
            Description = string.Empty;
            StudentsList = new();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public User Teacher { get; set; }
        public List<User> StudentsList { get; set; }
        public string Description { get; set; }
    }
}
