using OnlineClassDiaryWebAPI.Dtos;

namespace OnlineClassDiaryWebAPI.Services.Interfaces
{
    public interface IClassService
    {
        public ClassDto GetClass(int id);
        public ClassDto CreateClass(ClassDto classDto);
        public ClassDto EditClass(int id, ClassDto classDto);
        public ClassDto DeleteClass(int id);
    }
}
