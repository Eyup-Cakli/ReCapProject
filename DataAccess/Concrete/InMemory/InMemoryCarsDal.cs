using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarsDal : ICarsDal
    {
        List<Cars> _cars;
        public InMemoryCarsDal()
        {
            _cars = new List<Cars>
            {
                new Cars {CarId=1,BrandId=1,ColorId=1,CarModelYear=2022,CarDailyPrice=950,CarDescription="S 400d"},
                new Cars {CarId=2,BrandId=1,ColorId=2,CarModelYear=2022,CarDailyPrice=900,CarDescription="E 200d"},
                new Cars {CarId=3,BrandId=1,ColorId=3,CarModelYear=2022,CarDailyPrice=800,CarDescription="C 300"},
                new Cars {CarId=4,BrandId=2,ColorId=4,CarModelYear=2022,CarDailyPrice=900,CarDescription="iX40"},
                new Cars {CarId=5,BrandId=2,ColorId=1,CarModelYear=2022,CarDailyPrice=850,CarDescription="M440"}
            };
        }
        public void Add(Cars car)
        {
            _cars.Add(car);
        }

        public void Delete(Cars car)
        {
            Cars carsToDelet=_cars.SingleOrDefault(p=>p.CarId==car.CarId);
            _cars.Remove(car);
        }

        public List<Cars> GetAllByBrandId(int BrandId)
        {
            return _cars.Where(p=>p.BrandId==BrandId).ToList();
        }

        public List<Cars> GetAllCars()
        {
            return _cars;
        }

        public void Update(Cars car)
        {
            Cars carsToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carsToUpdate.CarId=car.CarId;
            carsToUpdate.BrandId=car.BrandId;
            carsToUpdate.ColorId=car.ColorId;
            carsToUpdate.CarModelYear=car.CarModelYear;
            carsToUpdate.CarDailyPrice=car.CarDailyPrice;
            carsToUpdate.CarDescription=car.CarDescription;
        }
    }
}
