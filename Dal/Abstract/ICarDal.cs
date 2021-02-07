
using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs;
using System.Collections.Generic;

namespace Dal.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetDetails();
    }
}
