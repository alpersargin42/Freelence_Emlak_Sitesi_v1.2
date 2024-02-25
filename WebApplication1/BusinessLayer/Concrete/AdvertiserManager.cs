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
	public class AdvertiserManager : IAdvertiserService
	{
		IAdvertiserDal _advertiserdal;

		public AdvertiserManager(IAdvertiserDal advertiserdal)
		{
			_advertiserdal = advertiserdal;
		}
		public void AdvertiserAdd(Advertiser advertiser)
		{
			_advertiserdal.Insert(advertiser);
		}

		public Advertiser GetById(int id)
		{
			return _advertiserdal.GetByID(id);
		}

		public List<Advertiser> GetList()
		{
            return _advertiserdal.GetListAll();
        }

		public void TAdd(Advertiser t)
		{
			_advertiserdal.Insert(t);
		}

		public void TDelete(Advertiser t)
		{
			_advertiserdal.Delete(t);
		}

		public void TUpdate(Advertiser t)
		{
			_advertiserdal.Update(t);
		}
	}
}
