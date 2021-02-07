using Dal.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dal.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        List<Brand> _brands;
        List<Color> _color;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=100_000,ModelYear=2018,Description="Ford C Max"},
                new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=100_000,ModelYear=2020,Description="BMW i30"},
                new Car{Id=3,BrandId=3,ColorId=3,DailyPrice=100_000,ModelYear=2021,Description="Mercedes CLA300"}
            };
            _color = new List<Color>
            {
                new Color{ColorId=1,ColorName="Gri"},
                new Color{ColorId=2,ColorName="Kırmızı"},
                new Color{ColorId=3,ColorName="Beyaz"}
            };
            _brands = new List<Brand>
            {
                new Brand{BrandId=1,BrandName="Ford"},
                new Brand{BrandId=2,BrandName="BMW"},
                new Brand{BrandId=3,BrandName="Mercedes"}
            };
        }

        public void Delete(Car car)
        {
            Car deletedCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(deletedCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Add(Car car)
        {
            try
            {
                var existBrand = _brands.Single(b => b.BrandId == car.BrandId);
                var existColor = _color.Single(c => c.ColorId == car.ColorId);
                _cars.Add(car);
            }
            catch (InvalidOperationException e)
            {
                throw new InvalidOperationException();
            }


        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.Single(c => c.Id == car.Id);

            try
            {
                var existBrand = _brands.Single(b => b.BrandId == car.BrandId);
                var existColor = _color.Single(c => c.ColorId == car.ColorId);
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;
                carToUpdate.ModelYear = car.ModelYear;
            }
            catch (InvalidOperationException e)
            {
                throw new InvalidOperationException();
            }
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
