using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

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

        [HttpGet]
        [Route("/saveCart/")]
        public ActionResult SaveUserCart([FromQuery] string products, decimal price)
        {
            var saveCartDao = new SaveCartDao();
            var success = saveCartDao.SaveCart(products, price);

            return Ok(Json(success));
        }
    }
}
