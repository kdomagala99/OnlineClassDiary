using OnlineClassDiaryWebAPI.Dtos;
using System.Collections.Generic;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IRoleService
    {
        public RoleDto GetRole(string name);
        public void EditRole(string name, RoleDto roleDto);
        public void CreateRole(RoleDto roleDto);
        public void DeleteRole(string name);
        public List<RoleDto> GetRoles();
    }
}
