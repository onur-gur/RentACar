using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetByBrandId(int brandId);
        List<Car> GetByColorId(int colorId);
        void Add(Car car);

        List<Car> GetAll();

        List<CarDetailDto> GetDetail();
    }
}
