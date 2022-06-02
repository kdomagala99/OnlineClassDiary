using OnlineClassDiaryWebAPI.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IRoleService
    {
        public RoleDto GetRole(string name);
        public void EditRole(string name, RoleDto roleDto);
        public void CreateRole(RoleDto roleDto);
        public void DeleteRole(string name);
    }
}
