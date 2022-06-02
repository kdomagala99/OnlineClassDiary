using AutoMapper;
using OnlineClassDiaryWebAPI.Database;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly OnlineClassDiaryDbContext _dbContext;
        private readonly IMapper _mapper;

        public SubjectService(OnlineClassDiaryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper; 
        }

        public void CreateSubject(SubjectDto subjectDto)
        {
            var subject = _mapper.Map<Subject>(subjectDto);

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
            var subjectDb = _dbContext.Subjects.FirstOrDefault(s => s.Name.Equals(subjectname));
            if(subjectDb == null)
                throw new System.NotImplementedException();

            var subjectDto = _mapper.Map<SubjectDto>(subjectDb);
            return subjectDto;
        }

        public List<SubjectDto> GetSubjects()
        {
            var subjects = _mapper.Map<List<SubjectDto>>(_dbContext.Subjects.ToList());
            return subjects;
        }
    }
}
