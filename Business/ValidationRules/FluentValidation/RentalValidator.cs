using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CustomerId).NotEmpty().GreaterThan(0);
            RuleFor(r => r.CarId).NotEmpty().GreaterThan(0);
            RuleFor(r => r.RentDate).NotEmpty().GreaterThanOrEqualTo(DateTime.Now);
        }
    }
}
