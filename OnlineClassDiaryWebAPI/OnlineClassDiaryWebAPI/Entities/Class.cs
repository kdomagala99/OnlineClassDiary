using System.Collections.Generic;

namespace OnlineClassDiaryWebAPI.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual User Teacher { get; set; }
        public string Description { get; set; }
        public virtual List<User> Students_List { get; set; }
    }
}
