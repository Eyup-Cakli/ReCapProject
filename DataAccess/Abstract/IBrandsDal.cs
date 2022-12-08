using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBrandsDal
    {
        List<Brands> GetAllBrands();
        public void Add(Brands brand);
        public void Update(Brands brand);
        public void Delete(Brands brand);
    }
}
