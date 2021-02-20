using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0).NotEmpty();
            RuleFor(c => c.ModelYear).GreaterThan(2005);
            RuleFor(c => c.Description).NotEmpty().MinimumLength(2);
            RuleFor(c => c.BrandId).NotEmpty().GreaterThan(0);
            RuleFor(c => c.ColorId).NotEmpty().GreaterThan(0);
            
        }
    }
}
