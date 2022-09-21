using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Codecool.CodecoolShop.Controllers
{
    public class DataController : Controller
    {
        [Route ("/registration/{name}/{email}/{password}")]
        public string registration(string name, string email, string password)
        {
            User user = new User { Name = name,  Email = email, Password = password};
            UserDao usersDAO = new UserDao();
            bool success = usersDAO.RegisterNewUser(user);
            string serializeObject = Newtonsoft.Json.JsonConvert.SerializeObject(success);
            return serializeObject;
        }
    }
}
