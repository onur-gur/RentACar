using Core.DataAccess.EntityFramework;
using Dal.Concrete.EntityFramework.Context;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User,ReCapContext>,
    {
    }
}
