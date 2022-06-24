namespace OnlineClassDiaryWebAPI.Entities
{
    public class Subject
    {
        public Subject()
        {
            Name = String.Empty;
            Description = String.Empty;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
