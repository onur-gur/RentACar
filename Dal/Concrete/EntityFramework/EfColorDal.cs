using Core.DataAccess.EntityFramework;
using Dal.Abstract;
using Dal.Concrete.EntityFramework.Context;
using Entity.Concrete;
namespace Dal.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, ReCapContext>, IColorDal
    {
    }
}
