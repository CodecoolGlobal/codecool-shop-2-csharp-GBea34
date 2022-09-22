using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Models;

namespace Codecool.CodecoolShop.Services;

public class SecurityService
{
    UserDao userDao = new UserDao();
      
    public bool IsValid(User user) 
    {
        return userDao.IsUserByEmailAndPassword(user);
    }
}