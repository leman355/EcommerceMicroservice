using CorePackage.Helpers.Result.Abstract;
using static IdentityService.Entities.DTOs.UserDTO;

namespace IdentityService.Business.Abstract
{
    public interface IUserService
    {
        IDataResult<UserByEmailDTO> GetUserByEmail(string email);
    }
}