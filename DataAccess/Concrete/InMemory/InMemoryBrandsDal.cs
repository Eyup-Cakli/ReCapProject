using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandsDal : IBrandsDal
    {
        List<Brands> _brands;
        public InMemoryBrandsDal()
        {
            _brands = new List<Brands>
            {
                new Brands{BrandId=1,BrandName="Mercedes"},
                new Brands{BrandId=2,BrandName="BMW"}
            };
        }
        public void Add(Brands brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brands brand)
        {
            Brands brandsToDelete=_brands.SingleOrDefault(p=>p.BrandId==brand.BrandId);
            _brands.Remove(brandsToDelete);
        }

        public List<Brands> GetAllBrands()
        {
            return _brands;
        }

        public void Update(Brands brand)
        {
            Brands brandsToUpdate=_brands.SingleOrDefault(p=>p.BrandId==brand.BrandId);
            brandsToUpdate.BrandId=brand.BrandId;
            brandsToUpdate.BrandName=brand.BrandName;
        }
    }
}
