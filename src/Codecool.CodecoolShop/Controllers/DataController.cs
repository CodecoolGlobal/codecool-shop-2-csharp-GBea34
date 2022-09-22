using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Models;
using Codecool.CodecoolShop.Services;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Codecool.CodecoolShop.Controllers
{
    public class DataController : Controller
    {
        [HttpPost]
        public string Registration([FromBody] User user)
        {
            UserDao usersDao = new UserDao();
            bool success = usersDao.RegisterNewUser(user);
            string succeed = Newtonsoft.Json.JsonConvert.SerializeObject(success);
            return succeed;
        }

        [HttpGet]
        [Route("/saveCart/")]
        public ActionResult SaveUserCart([FromQuery] string products)
        {
            DBConnection dbConnection = new DBConnection();
            string query = $"INSERT INTO chart(creation_time, total_price, products) VALUES(CURDATE(), 1 , {products.ToString()})";
            dbConnection.ExecuteQuery(query);

            return Ok(Json("Well Done"));
        }

        public string Login([FromBody]User user)
        {
            
            SecurityService security = new SecurityService();
            UserDao userDao = new UserDao();
            if (security.IsValid(user))
            {
                string succeed = Newtonsoft.Json.JsonConvert.SerializeObject(true);
                return succeed;
            }
            else 
            {
                string succeed = Newtonsoft.Json.JsonConvert.SerializeObject(false);
                return succeed;
            }
        }

        public class DBConnection
        {
            public string ConnectionString => ConfigurationManager.AppSettings["connectionString"];

            public void ExecuteQuery(string query)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
            }

            public bool TestConnection()
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                }
            }
        }
    }
}