using Autofac;
using IdentityService.Business.Abstract;
using IdentityService.Business.Concrete;
using IdentityService.DataAccess.Abstract;
using IdentityService.DataAccess.Concrete;

namespace IdentityService.Business.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthManager>().As<IAuthService>();

            builder.RegisterType<UserDal>().As<IUserDal>();
            builder.RegisterType<UserManager>().As<IUserService>();
        }
    }
}