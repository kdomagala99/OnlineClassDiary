using OnlineClassDiaryWebAPI.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface ISubjectService
    {
        public void CreateSubject(SubjectDto subjectDto);
        public void EditSubject(string subjectname, SubjectDto subjectDto);
        public void DeleteSubject(string subjectname);
        public SubjectDto GetSubject(string subjectname);
        public SubjectDto GetSubjects();
    }
}
