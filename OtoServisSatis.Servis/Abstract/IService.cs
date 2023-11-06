using OtoServisSatis.Data.Abstract;
using OtoServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Servis.Abstract
{
	public interface IService<T> : IRepository<T> where T : class, IEntity, new()
	{


	}
}
