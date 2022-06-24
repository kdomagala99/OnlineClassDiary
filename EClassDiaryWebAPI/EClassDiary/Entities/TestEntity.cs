namespace EClassDiary.Entities
{
    public class TestEntity
    {
        public string prop { get; set; }
        public TestEntity()
        {
            prop = String.Empty;
        }
        public TestEntity(string prop)
        {
            this.prop = prop;
        }
    }
}
