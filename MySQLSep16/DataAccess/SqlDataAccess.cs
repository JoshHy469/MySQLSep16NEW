using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MySQLSep16.DataAccess
{
    internal class SqlDataAccess : ISqlDataAccess
    {
        private string connectionString = "server=localhost;port=3306;uid=appDev;pwd=AppDev;database=db_garage;";

        public List<T> LoadData<T, U>(string sql, U parameters)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var data = connection.Query<T>(sql, parameters);
                return data.ToList();
            }
        }

        //save is equal to chaning/add/deleting
        public void SaveData<T>(string sql, T parameters)
        {
            using(IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Execute(sql, parameters);

            }
        }

        private string BconnectionString = "server=localhost;port=3306;uid=appDev;pwd=AppDev;database=db_garage;";

        public List<T> BankLoadData<T, U>(string sql, U parameters)
        {
            using (IDbConnection connection = new MySqlConnection(BconnectionString))
            {
                var data = connection.Query<T>(sql, parameters);
                return data.ToList();
            }
        }

        //save is equal to chaning/add/deleting
        public void BankSaveData<T>(string sql, T parameters)
        {
            using (IDbConnection connection = new MySqlConnection(BconnectionString))
            {
                connection.Execute(sql, parameters);

            }
        }
    }   

}

