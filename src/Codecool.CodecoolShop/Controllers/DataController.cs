using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Codecool.CodecoolShop.Controllers
{
    public class DataController : Controller
    {
        [HttpPost]
        public string Registration( [FromBody]User user)
        {
                UserDao usersDao = new UserDao();
                bool success = usersDao.RegisterNewUser(user);
                string succeed = Newtonsoft.Json.JsonConvert.SerializeObject(success);
                return succeed;
        }
    }
}
