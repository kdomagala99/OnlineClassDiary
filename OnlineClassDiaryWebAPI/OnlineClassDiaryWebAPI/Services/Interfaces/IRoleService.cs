using OnlineClassDiaryWebAPI.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IRoleService
    {
        public RoleDto GetRole(int id);
        public RoleDto EditRole(int id, RoleDto roleDto);
        public RoleDto CreateRole(RoleDto roleDto);
        public RoleDto DeleteRole(int id);
    }
}
