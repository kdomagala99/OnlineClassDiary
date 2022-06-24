using AutoMapper;
using EClassDiary.Database;
using EClassDiary.Entities;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Entities.Dtos;

namespace EClassDiary.Services
{
    public class GradeService
    {
        private EClassDiaryDbContext _dbContext;
        private readonly IMapper _mapper;

        public GradeService(EClassDiaryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<List<GradeDto>> GetStudentGrades(string name, string surname)
        {
            List<List<GradeDto>> list = new List<List<GradeDto>>();
            var s1 = _dbContext.Semesters.FirstOrDefault(s => s.Name == "Winter");
            var s2 = _dbContext.Semesters.FirstOrDefault(s => s.Name == "Summer");
            if (s1 == null || s2 == null)
                return list;
            var student = _dbContext.Users.FirstOrDefault(s => s.Name == name && s.Surname == surname);
            if (student == null)
                return list;
            List<GradeDto> l1 = _mapper.Map<List<GradeDto>>(_dbContext.Grades.Where(g => g.Semester.Equals(s1) && g.Student == student)
                .Select(g => new Grade
                {
                    Value = g.Value,
                    Name = g.Name,
                    Semester = g.Semester,
                    Student = g.Student,
                    Teacher = g.Teacher,
                    Date = g.Date,
                    Subject = g.Subject
                }).ToList());
            List<GradeDto> l2 = _mapper.Map<List<GradeDto>>(_dbContext.Grades.Where(g => g.Semester.Equals(s2) && g.Student == student)
                .Select(g => new Grade
                {
                    Value = g.Value,
                    Name = g.Name,
                    Semester = g.Semester,
                    Student = g.Student,
                    Teacher = g.Teacher,
                    Date = g.Date,
                    Subject = g.Subject
                }).ToList());

            if (l1 == null || l2 == null)
                return list;

            list.Add(l1);
            list.Add(l2);
            return list;
        }

        public bool AddGradeToStudent(string name, string surname, decimal value, string subject, string teacherEmail)
        {
            var teacher = _dbContext.Users.FirstOrDefault(u => u.Email == teacherEmail);
            if (teacher == null)
                return false;
            var student = _dbContext.Users.FirstOrDefault(u => u.Name == name && u.Surname == surname);
            if (student == null)
                return false;
            Grade grade = new Grade();
            grade.Student = student;
            grade.Teacher = teacher;
            grade.Value = value;
            grade.Name = "empty";
            var _subject = _dbContext.Subjects.FirstOrDefault(s => s.Name == subject);
            if (_subject == null)
                return false;
            grade.Subject = _subject;
            DateTime now = DateTime.Now;
            grade.Date = now;
            var semester = _dbContext.Semesters.FirstOrDefault(s => s.DateBegin <= now && s.DateEnd >= now);
            if (semester == null)
                return false;
            grade.Semester = semester;
            _dbContext.Grades.Add(grade);
            _dbContext.SaveChanges();
            return true;
        }

        public void DeleteAllGrades()
        {
            foreach (var grade in _dbContext.Grades)
            {
                _dbContext.Remove(grade);
            }
            _dbContext.SaveChanges();
        }
    }
}
