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
        [Route ("/registration/{name}/{email}/{password}")]
        public string registration(string name, string email, string password)
        {
            User user = new User { Name = name,  Email = email, Password = password};
            UserDao usersDAO = new UserDao();
            bool success = usersDAO.RegisterNewUser(user);
            string serializeObject = Newtonsoft.Json.JsonConvert.SerializeObject(success);
            return serializeObject;
        }

        [HttpGet]
        [Route("/saveCart/")]
        public ActionResult SaveUserCart([FromQuery] string products)
        {
            DBConnection dbConnection = new DBConnection();
            string query = $"INSERT INTO conection_chart_user(user_id, chart) VALUES(1, {products.ToString()})";
            dbConnection.ExecuteQuery(query);

            return Ok(Json("Well Done"));
        }
    }

    public class DBConnection
    {
        public string ConnectionString => ConfigurationManager.AppSettings["connectionString"];

        public void ExecuteQuery(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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
