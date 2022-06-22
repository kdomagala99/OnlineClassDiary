using AutoMapper;
using OnlineClassDiaryWebAPI.Database;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Services
{
    public class ClassService : IClassService
    {
        private readonly OnlineClassDiaryDbContext _dbContext;
        private readonly IMapper _mapper;

        public ClassService(OnlineClassDiaryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void CreateClass(ClassDto classDto)
        {
            var _class = _mapper.Map<Class>(classDto);
            _dbContext.Classes.Add(_class);
            _dbContext.SaveChanges();
        }

        public void DeleteClass(int id)
        {
            var _class = _dbContext.Classes.FirstOrDefault(c => c.Id == id);
            if (_class != null)
            {
                _dbContext.Classes.Remove(_class);
                _dbContext.SaveChanges();
            }
        }

        public void EditClass(int id, ClassDto classDto)
        {
            var _class = _dbContext.Classes.FirstOrDefault(_c => _c.Id == id);

            _class.Name = classDto.Name;
            _class.Teacher = _mapper.Map<User>(classDto.Teacher);
            _class.Description = classDto.Description;
            _class.Students_List = _mapper.Map<List<User>>(classDto.Students_List);

            _dbContext.SaveChanges(true);
        }

        public ClassDto GetClass(int id)
        {
            var classDb = _dbContext.Classes.FirstOrDefault(a => a.Id.Equals(id));
            if (classDb == null)
                return null;

            var classDto = _mapper.Map<ClassDto>(classDb);
            return classDto;
        }
    }
}
