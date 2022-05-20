using OnlineClassDiaryWebAPI.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface ISemesterService
    {
        public SemesterDto CreateSemester(SemesterDto semesterDto);
        public SemesterDto EditSemester(int semesterId, SemesterDto semesterDto);
        public SemesterDto DeleteSemester(int semesterId);
        public SemesterDto GetSemester(int semesterId);
        public SemesterDto GetSemesters();
    }
}
