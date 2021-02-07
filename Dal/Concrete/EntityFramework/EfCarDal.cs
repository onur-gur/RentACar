using Core.DataAccess.EntityFramework;
using Dal.Abstract;
using Dal.Concrete.EntityFramework.Context;
using Entity.Concrete;
using Entity.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Dal.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto { CarId = c.Id, BrandId = b.BrandId, BrandName = b.BrandName, Description = c.Description, DailyPrice = c.DailyPrice, ModelYear = c.ModelYear, ColorName = co.ColorName };
                return result.ToList();
            }
        }
    }
}
