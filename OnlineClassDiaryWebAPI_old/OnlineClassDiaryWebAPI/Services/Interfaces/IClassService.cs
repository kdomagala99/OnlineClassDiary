using OnlineClassDiaryWebAPI.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IClassService
    {
        public ClassDto GetClass(int id);
        public void CreateClass(ClassDto classDto);
        public void EditClass(int id, ClassDto classDto);
        public void DeleteClass(int id);
    }
}
