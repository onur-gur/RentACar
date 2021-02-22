using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidtor : AbstractValidator<Customer>
    {
        public CustomerValidtor()
        {
            RuleFor(c => c.CompanyName).NotEmpty().Length(2, 20);
        }
    }
}
