using Core.DataAccess.EntityFramework;
using Dal.Abstract;
using Dal.Concrete.EntityFramework.Context;
using Entity.Concrete;
using Entity.DTOs;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using System;
using System.Linq.Expressions;

namespace Dal.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {

                var result = from r in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brands
                             on r.Id equals b.BrandId
                             join cus in context.Customers
                             on r.CustomerId equals cus.Id
                             select new RentalDetailDto
                             {
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 CarId = c.Id,
                                 CarDescription = c.Description,
                                 CustomerId = cus.Id,
                                 CompanyName = cus.CompanyName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
