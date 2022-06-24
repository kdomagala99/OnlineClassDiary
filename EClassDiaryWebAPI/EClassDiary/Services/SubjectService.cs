using AutoMapper;
using EClassDiary.Database;
using EClassDiary.Entities;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Entities.Dtos;

namespace EClassDiary.Services
{
    public class SubjectService
    {
        private readonly IMapper _mapper;
        private readonly EClassDiaryDbContext _dbContext;

        public SubjectService(EClassDiaryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<SubjectDto> GetAllSubjects()
        {
            var subjects = _mapper.Map<List<SubjectDto>>(_dbContext.Subjects.ToList());
            return subjects;
        }

        public bool CreateSubject(string name)
        {
            Subject subject = new();
            subject.Name = name;
            subject.Description = string.Empty;
            _dbContext.Subjects.Add(subject);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteSubject(string name)
        {
            var subject = _dbContext.Subjects.FirstOrDefault(s => s.Name == name);
            if (subject == null)
                return false;
            _dbContext.Subjects.Remove(subject);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
