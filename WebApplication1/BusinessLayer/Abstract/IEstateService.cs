using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IEstateService : IGenericService<Estate>
	{
		List<Estate> GetListWithCategory();
		List<Estate> GetEstateListWithCategory();
		List<Estate> GetEstateListByAdvertiser(int id);

    }
}
