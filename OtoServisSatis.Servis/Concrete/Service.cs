using OtoServisSatis.Data.Concrete;
using OtoServisSatis.Data;
using OtoServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Servis.Concrete
{
	public class Service<T> : Repository<T> where T : class, IEntity, new()
	{
		public Service(DatabaseContext context) : base(context)
		{
		}
	}
}
