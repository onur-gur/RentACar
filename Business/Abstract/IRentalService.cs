using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult ReturnCar(Rental rental);

        IDataResult<List<Rental>> GetAll();
        IResult Delete(Rental rental);
        IResult Update(Rental rental);

        IDataResult<Rental> GetById(int id);

        IDataResult<List<Rental>> GetByCarId(int id);

        IDataResult<List<Rental>> GetByCustomerId(int id);
        IDataResult<List<Rental>> GetByRentDate(DateTime time);
        IDataResult<List<Rental>> GetByReturnDate(DateTime time);

        IDataResult<List<RentalDetailDto>> GetRentalDetails(Expression<Func<Rental, bool>> filter = null);
    }
}
