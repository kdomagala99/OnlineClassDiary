using AutoMapper;
using OnlineClassDiaryWebAPI.Database;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Entities.Dtos;
using OnlineClassDiaryWebAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly IMapper _mapper;
        private readonly OnlineClassDiaryDbContext _dbContext;
        public SubjectService(OnlineClassDiaryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
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

        public List<SubjectDto> GetSubjects()
        {
            var subjects = _mapper.Map<List<SubjectDto>>(_dbContext.Subjects.ToList());
            return subjects;
        }

    }
}
