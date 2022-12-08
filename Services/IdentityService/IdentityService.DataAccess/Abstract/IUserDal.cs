using CorePackage.DataAccess;
using CorePackage.Entities.Concrete;

namespace IdentityService.DataAccess.Abstract
{
    public interface IUserDal : IRepositoryBase<User>
    {
    }
}