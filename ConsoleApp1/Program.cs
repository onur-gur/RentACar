﻿using Business.Concrete;
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
            //Console.WriteLine("Hello World!");

            //CarManager manager = new CarManager(new EfCarDal());

            //var cars = manager.GetDetail();

            //foreach (var car1 in cars.Data)
            //{
            //    Console.WriteLine(car1.BrandName + "/" + car1.Description + "/" + car1.DailyPrice + "/" + car1.ColorName);
            //}

            //Car car = new Car { BrandId = 3, ColorId = 3, ModelYear = 2021, DailyPrice = 1000000, Description = "CLA 200" };

            //manager.Add(car);

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //Rental rental = new Rental { CarId = 4, CustomerId = 2, RentDate = new DateTime(2021, 4, 30) };
            //Console.WriteLine(rentalManager.Add(rental).Message);

            Rental rental = new Rental { Id=7,CarId = 4, CustomerId = 2, RentDate = new DateTime(2021, 4, 30), ReturnDate = new DateTime(2021,5,30) };
            var result = rentalManager.ReturnCar(rental);
            Console.WriteLine(result.Message);
        }



    }
}
