using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfEstateRepository : GenericRepository<Estate>, IEstateDal
	{
		public List<Estate> GetListWithCategory()
		{
			using (var c = new Context())
			{
				return c.Estates.Include(x => x.Category).ToList();
			}
		}

        public List<Estate> GetListWithCategoryByAdvertiser(int id)
        {
            using (var c = new Context())
            {
                return c.Estates.Include(x => x.Category).Where(x=>x.AdvertiserID==id).ToList();
            }
        }
    }
}
