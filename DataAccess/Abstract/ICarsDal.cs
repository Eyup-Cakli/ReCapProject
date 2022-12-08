using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarsDal
    {
        List<Cars> GetAllCars();
        public void Add(Cars car);
        public void Update(Cars car);
        public void Delete(Cars car);
        List<Cars>GetAllByBrandId(int BrandId);
    }
}
