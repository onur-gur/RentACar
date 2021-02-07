using Business.Concrete;
using Dal.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CarManager manager = new CarManager(new EfCarDal());

            //var cars = manager.GetAll();

            //foreach (var car1 in cars)
            //{
            //    Console.WriteLine(car1.Description);
            //}

            Car car = new Car { BrandId = 3, ColorId = 3, ModelYear = 2021, DailyPrice = 1000000, Description = "CLA 200" };

            manager.Add(car);
            //Console.WriteLine("Ekledi");
        }



    }
}
