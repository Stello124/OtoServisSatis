using OtoServisSatis.Data.Abstract;
using OtoServisSatis.Entities;

namespace OtoServisSatis.Servis.Abstract
{
    public interface IService<T> : IRepository<T> where T : class, IEntity, new()
    {
    }
}
