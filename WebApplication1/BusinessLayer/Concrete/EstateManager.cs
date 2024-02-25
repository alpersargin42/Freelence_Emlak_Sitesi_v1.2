using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class EstateManager : IEstateService
	{
		IEstateDal _estateDal;

		public EstateManager(IEstateDal estateDal)
		{
			_estateDal = estateDal;
		}
		public Estate GetById(int id)
		{
			return _estateDal.GetByID(id);

		}

		public List<Estate> GetList()
		{
			return _estateDal.GetListAll();

		}

		public List<Estate> GetListWithCategory()
		{
			return _estateDal.GetListWithCategory();
		}
        public List<Estate> GetListWithCategoryByAdvertiserEm(int id)
        {
            return _estateDal.GetListWithCategoryByAdvertiser(id);
        }

        public List<Estate> GetEstateByID(int id)
		{
			return _estateDal.GetListAll(x => x.EstateID == id);
		}
		public List<Estate> GetEstateListWithCategory()
		{
			return _estateDal.GetListWithCategory();
		}
		public void TAdd(Estate t)
		{
			_estateDal.Insert(t);
		}

		public void TDelete(Estate t)
		{
			_estateDal.Delete(t);

		}

		public void TUpdate(Estate t)
		{
			_estateDal.Update(t);

		}

        public List<Estate> GetEstateListByAdvertiser(int id)
        {
			return _estateDal.GetListAll(x=>x.Advertiser.AdvertiserID==id);
        }
    }
}
