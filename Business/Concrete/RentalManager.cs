using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Results;
using Dal.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var result = _rentalDal.GetRentalDetails(r => r.CarId == rental.CarId);
            if (rental.RentDate < DateTime.Now || result.Count > 0)
            {
                return new ErrorResult(Messages.InvalidDate);

            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.Added);
        }

        public IResult ReturnCar(Rental rental)
        {
            var result = GetById(rental.Id);
            if (result != null && rental.ReturnDate >= result.Data.RentDate)
            {
                result.Data.ReturnDate = rental.ReturnDate;
                return Update(result.Data);
            }
            return new ErrorResult(Messages.InvalidDate);

        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id), Messages.Listed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.DeliveredCar);
        }

        public IDataResult<List<Rental>> GetByCarId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarId == id));
        }

        public IDataResult<List<Rental>> GetByCustomerId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CustomerId == id));
        }

        public IDataResult<List<Rental>> GetByRentDate(DateTime time)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.RentDate == time));
        }

        public IDataResult<List<Rental>> GetByReturnDate(DateTime time)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.RentDate == time));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }
    }
}
