using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Codecool.CodecoolShop.Controllers
{
    public class DataController : Controller
    {
        [HttpPost]
        public string registration(string name, string email, string passwordOne, string passwordTwo)
        {
            if (passwordOne == passwordTwo)
            {
                string password = passwordOne;
                User user = new User { Name = name,  Email = email, Password = password};
                UserDao usersDAO = new UserDao();
                bool success = usersDAO.RegisterNewUser(user);
                string successed = Newtonsoft.Json.JsonConvert.SerializeObject(success);
                return successed;
            }
            return "";
        }
    }
}
