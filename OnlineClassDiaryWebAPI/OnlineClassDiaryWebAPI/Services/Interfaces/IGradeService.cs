using OnlineClassDiaryWebAPI.Entities.Dtos;
using System.Collections.Generic;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IGradeService
    {
        public List<List<GradeDto>> GetStudentGrades(string name, string surname);
        public bool AddGrade(string imie, string nazwisko, decimal value, string subject, string email);
    }
}
