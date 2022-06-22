using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Entities;
using System.Collections.Generic;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface ISemesterService
    {
        public void CreateSemester(SemesterDto semesterDto);
        public void EditSemester(int semesterId, SemesterDto semesterDto);
        public void DeleteSemester(int semesterId);
        public SemesterDto GetSemester(int semesterId);
        public List<SemesterDto> GetSemesters();
    }
}
