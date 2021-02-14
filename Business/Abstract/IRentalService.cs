using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);

        IDataResult<List<Rental>> GetAll();
        IResult Delete(Rental rental);
        IResult Update(Rental rental);

        IDataResult<Rental> GetById(int id);
    }
}
