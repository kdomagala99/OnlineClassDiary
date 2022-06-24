namespace OnlineClassDiaryWebAPI.Entities.Dtos
{
    public class GradeDto
    {
        public GradeDto()
        {
            Subject = String.Empty;
        }
        public decimal Value { get; set; }
        public string Subject { get; set; } 
    }
}
