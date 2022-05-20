using OnlineClassDiaryWebAPI.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface ISubjectService
    {
        public SubjectDto CreateSubject(SubjectDto subjectDto);
        public SubjectDto EditSubject(string subjectname, SubjectDto subjectDto);
        public SubjectDto DeleteSubject(string subjectname);
        public SubjectDto GetSubject(string subjectname);
        public SubjectDto GetSubjects();
    }
}
