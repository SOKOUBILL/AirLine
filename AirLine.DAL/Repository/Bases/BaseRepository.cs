
using AirLine.BO.Entities;

namespace AirLine.DAL.Repository.Bases
{
    public class BaseRepository<TModel> : IBaseRepository<TModel>
        where TModel :BaseEntity
    {

        static IList<TModel> Databases { get; set; } = new List<TModel>();
        public Task<TModel> Add(TModel model)
        {
            Databases.Add(model);
            return Task.FromResult(model);
        }

        public Task<bool> Delete(int Id)
        {
            var model = Databases.FirstOrDefault(x => x.Id == Id);

            if (model != null)
            {
                Databases.Remove(model);
            }

            return Task.FromResult(model != null);
        }

        public Task<IList<TModel>> FindAll()
        {
            return Task.FromResult(Databases);
        }

        public Task<TModel> FindById(int Id)
        {
            var model = Databases.FirstOrDefault(x => x.Id == Id);
            return Task.FromResult(model);
        }

        public Task<TModel> Update(TModel model)
        {
            var index = Databases.Select(x => x.Id).ToList().IndexOf(model.Id);
            Databases.RemoveAt(index);
            Databases.Insert(index, model);

            return Task.FromResult(model);
        }
    }
    
}
