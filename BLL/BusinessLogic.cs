using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    //class BusinessLogic
    //{
    //    DataAccess dal = new DataAccess();

    //    public DataTable GetAllUsers()
    //    {
    //        string query = "SELECT * FROM Users";
    //        return dal.GetData(query);
    //    }

    //}
    public class DatabaseManager
    {
        private DataAccess dbConnection = new DataAccess();

        public bool CheckConnection()
        {
            return dbConnection.TestConnection();
        }
        public bool Login(string username, string password)
        {
            return dbConnection.CheckLogin(username, password);
        }
    }
}
