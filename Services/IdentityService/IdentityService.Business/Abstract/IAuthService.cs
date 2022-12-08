using CorePackage.Entities.Concrete;
using CorePackage.Helpers.Result.Abstract;
using static IdentityService.Entities.DTOs.UserDTO;

namespace IdentityService.Business.Abstract
{
    public interface IAuthService
    {
        IResult Login(LoginDTO login);
        IResult Register(RegisterDTO register);
        IDataResult<User> GetUserByEmail(string email);
    }
}