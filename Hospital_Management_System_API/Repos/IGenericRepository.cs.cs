namespace Hospital_Management_System_API.Repos
{
    public interface IGenericRepo<T> where T : class
    {
        IEnumerable<T> GetAll();
        T? GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        int save();
    }
}
