using CorePackage.DataAccess.EntityFramework;
using CorePackage.Entities.Concrete;
using IdentityService.DataAccess.Abstract;

namespace IdentityService.DataAccess.Concrete
{
    public class UserDal : EfRepositoryBase<User, AppDbContext>, IUserDal
    {
    }
}
