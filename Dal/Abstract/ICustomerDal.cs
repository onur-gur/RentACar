using Core.DataAccess;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
