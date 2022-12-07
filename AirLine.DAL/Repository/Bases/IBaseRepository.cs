

namespace AirLine.DAL.Repository.Bases
{
    public interface IBaseRepository<T> where T : class
    {
        static IList<T> Databases { get; set; }
        Task<T> Add(T model);
        Task<T> Update(T model);
        Task<bool> Delete(int Id);
        Task<T> FindById(int Id);
        Task<IList<T>> FindAll();
    }
    
}
