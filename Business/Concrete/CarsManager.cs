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
    public class CarsManager : ICarsService
    {
        ICarsDal _carDal;

        public CarsManager(ICarsDal carDal)
        {
            _carDal = carDal;
        }

        public List<Cars> GetAll()
        {
            return _carDal.GetAllCars();
        }
    }
}
