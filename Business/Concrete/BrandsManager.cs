using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandsManager : IBrandsService
    {
        IBrandsDal _berandDal;

        public BrandsManager(IBrandsDal berandDal)
        {
            _berandDal = berandDal;
        }

        public List<Brands> GetAll()
        {
            return _berandDal.GetAllBrands();
        }
    }
}
