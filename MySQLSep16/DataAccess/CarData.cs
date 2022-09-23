﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySQLSep16.Models;

namespace MySQLSep16.DataAccess
{
    internal class CarData
    {
        private string connectionString = "server=localhost;port=3306;uid=appDev;pwd=AppDev;database=db_garage;";

        private readonly ISqlDataAccess _db = new SqlDataAccess();


        public List<CarModel> SearchYear()
        {
            string sql = "SELECT * FROM `car_basic` WHERE `Year` = 2022";
            List<CarModel> cars = _db.LoadData<CarModel, dynamic>(sql, new { });

            return cars; 
        }
        public List<string> GetMake()
        {
            string sql = "SELECT DISTINCT `Make` FROM `car_basic`";

            List<string> cars = _db.LoadData<string, dynamic>(sql, new { });

            return cars;

        }
        public List<int> GetYears()
        {
            string sql = "SELECT DISTINCT `Year` FROM `car_basic`";

            List<int> cars = _db.LoadData<int, dynamic>(sql, new { });

            return cars; 

        }
        public List<CarModel> GetAllCars()
        {
            string sql = "SELECT* FROM car_basic";
            List<CarModel> cars = _db.LoadData<CarModel, dynamic>(sql, new { });

            return cars; 
        }
        public void CreateCar(CarModel c)
        {
            string sql = "INSERT INTO `car_basic` (`Year`, `Make`, `Model`) VALUES (@Year, @Make, @Model)";

            _db.SaveData(sql, c);
        }
        /*
        public List<CarModel> GetAllCars()
        {
            List<CarModel> cars = new List<CarModel>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `car_basic`", connection); 

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    CarModel car = new CarModel
                    {
                        CarID = reader.GetInt32(0),
                        Year = reader.GetInt32(1),
                        Make = reader.GetString(2),
                        Model = reader.GetString(3)
                    };
                    cars.Add(car);

                }
            }
            return cars; 
        }
        */
    }
}
