using OnlineClassDiaryWebAPI.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IGradeService
    {
        public GradeDto GetGrade(int id);
        public void EditGrade(int id, GradeDto gradeDto);
        public void CreateGrade(GradeDto gradeDto);
        public void DeleteGrade(int id);
        
    }
}
