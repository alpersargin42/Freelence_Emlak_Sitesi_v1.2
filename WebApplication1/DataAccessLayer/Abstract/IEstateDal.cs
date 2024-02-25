using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IEstateDal : IGenericDal<Estate>
	{
		List<Estate> GetListWithCategory();
		List<Estate> GetListWithCategoryByAdvertiser(int id);
    }
}
