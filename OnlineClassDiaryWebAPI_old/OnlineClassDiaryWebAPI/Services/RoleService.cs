using AutoMapper;
using OnlineClassDiaryWebAPI.Database;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OnlineClassDiaryWebAPI.Services
{
    public class RoleService : IRoleService
    {
        private readonly OnlineClassDiaryDbContext _dbContext;
        private readonly IMapper _mapper;
        public RoleService(OnlineClassDiaryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;   
        }
        public void CreateRole(RoleDto roleDto)
        {
            var role = _mapper.Map<Role>(roleDto);
            _dbContext.Roles.Add(role);
            _dbContext.SaveChanges();
        }

        public void DeleteRole(string name)
        {
            var role = _dbContext.Roles.FirstOrDefault(r => r.Name.Equals(name));
            if (role == null)
                return;
            _dbContext.Roles.Remove(role);
            _dbContext.SaveChanges();
        }

        public void EditRole(string name, RoleDto roleDto)
        {
            var role = _dbContext.Roles.FirstOrDefault(r => r.Name.Equals(name));
            if (role!=null)
                role.Name = roleDto.Name;
        }

        public RoleDto GetRole(string name)
        {
            var role = _dbContext.Roles.FirstOrDefault(r => r.Name.Equals(name));
            if (role == null)
                return null;
            return _mapper.Map<RoleDto>(role);
        }

        public List<RoleDto> GetRoles()
        {
            var roles = _dbContext.Roles.ToList();
            return _mapper.Map<List<RoleDto>>(roles);
        }
    }
}
