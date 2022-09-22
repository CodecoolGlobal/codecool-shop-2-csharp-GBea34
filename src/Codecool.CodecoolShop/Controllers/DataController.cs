using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Codecool.CodecoolShop.Controllers
{
    public class DataController : Controller
    {
        [HttpPost]
        public string registration( [FromBody]User user)
        {
                UserDao usersDAO = new UserDao();
                bool success = usersDAO.RegisterNewUser(user);
                string successed = Newtonsoft.Json.JsonConvert.SerializeObject(success);
                return successed;
        }
    }
}
