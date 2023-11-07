using OtoServisSatis.Data;
using OtoServisSatis.Data.Concrete;
using OtoServisSatis.Entities;
using OtoServisSatis.Servis.Abstract;

namespace OtoServisSatis.Servis.Concrete
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IEntity, new()
    {
        public Service(DatabaseContext context) : base(context)
        {
        }
    }
}
