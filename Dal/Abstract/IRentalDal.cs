using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dal.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null);
    }
}
