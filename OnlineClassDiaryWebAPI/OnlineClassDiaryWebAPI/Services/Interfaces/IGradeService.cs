using OnlineClassDiaryWebAPI.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IGradeService
    {
        public GradeDto GetGrade(int id);
        public GradeDto EditGrade(int id, GradeDto gradeDto);
        public GradeDto CreateGrade(GradeDto gradeDto);
        public GradeDto DeleteGrade(int id);
        
    }
}
