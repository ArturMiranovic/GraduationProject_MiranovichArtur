using WebApplication_Artur.EfStuff.Model.UserModel;

namespace WebApplication_Artur.Services
{
    public interface IUserService
    {
        void AllBikeUser(long id);
        User GetCurrent();
        bool IsAdmin();
        bool IsAdmin(long id);
        bool IsAdminOrOwner(long id);
        bool IsDontAnminMyUser(long id);
        bool IsMy(long id);
        bool IsOwner(long id);
    }
}