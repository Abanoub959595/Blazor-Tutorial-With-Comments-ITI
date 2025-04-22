namespace LabOneBlazor.Services.@interface
{
    public interface IService<T>
    {
        public List<T> GetAll();    
        public T GetById (int id);  

    }
}
