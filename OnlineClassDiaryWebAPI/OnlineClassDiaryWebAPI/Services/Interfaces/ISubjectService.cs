using OnlineClassDiaryWebAPI.Entities.Dtos;
using System.Collections.Generic;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface ISubjectService
    {
        public bool CreateSubject(string name);
        public List<SubjectDto> GetSubjects();
        bool DeleteSubject(string name);
    }
}
