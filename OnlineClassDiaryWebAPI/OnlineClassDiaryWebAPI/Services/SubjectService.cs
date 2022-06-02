using OnlineClassDiaryWebAPI.Database;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Services.Interfaces;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly OnlineClassDiaryDbContext _dbContext;

        public SubjectService(OnlineClassDiaryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateSubject(SubjectDto subjectDto)
        {
            var subject = new Subject()
            {
                Name = subjectDto.Name,
                Description = subjectDto.Description
            };

            _dbContext.Subjects.Add(subject);
            _dbContext.SaveChanges();
        }

        public void DeleteSubject(string subjectname)
        {
            var subject = _dbContext.Subjects.FirstOrDefault(s => s.Name.Equals(subjectname));
            if(subject != null)
            {
                _dbContext.Subjects.Remove(subject);
                _dbContext.SaveChanges();
            }
        }

        public void EditSubject(string subjectname, SubjectDto subjectDto)
        {
            var subjectDb = _dbContext.Subjects.FirstOrDefault(s => s.Name.Equals(subjectname));
            subjectDb.Name = subjectDto.Name;

            _dbContext.SaveChanges();
        }

        public SubjectDto GetSubject(string subjectname)
        {
            var subjectDto = new SubjectDto();
            var subjectDb = _dbContext.Subjects.FirstOrDefault(s => s.Name.Equals(subjectname));
            if(subjectDb == null)
                throw new System.NotImplementedException();

            subjectDto.Name = subjectDb.Name;

            return subjectDto;
        }

        public SubjectDto GetSubjects()
        {
            throw new System.NotImplementedException();
        }
    }
}
