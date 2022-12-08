using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarsManager carsManager = new CarsManager(new InMemoryCarsDal());
            BrandsManager brandsManager = new BrandsManager(new InMemoryBrandsDal());
            ColorsManager colorsManager = new ColorsManager(new InMemoryColorsDal());
            Console.WriteLine("Araç Listesi");
            foreach (var car in carsManager.GetAll())
            {
                Console.WriteLine(" Araç Id :"+car.CarId+" Marka Id:"+car.BrandId+" Renk Id:"+car.ColorId+" Yıl :"+car.CarModelYear+" Model Açıklama :"+car.CarDescription+" Günlük Kiralama Bedeli :"+car.CarDailyPrice+"TL");
            }
            Console.WriteLine("\nMarka Listesi");
            foreach (var brand in brandsManager.GetAll())
            {
                Console.WriteLine(" Marka Id :"+brand.BrandId+" Marka Adı:"+brand.BrandName);
            }
            Console.WriteLine("\nRenk Listesi");
            foreach (var color in colorsManager.GetAll())
            {
                Console.WriteLine(" Renk Id :"+color.ColorId+" Renk Adı:"+color.ColorName);
            }
        }
    }
}
