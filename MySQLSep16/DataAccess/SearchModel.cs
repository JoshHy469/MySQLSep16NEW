using MySQLSep16.DataAccess;
using MySQLSep16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev_CAR.DataAccess
{
    internal class SearchModel
    {
        private readonly ISqlDataAccess _db = new SqlDataAccess();

        public List<SearchModel> GetSearchesByUID(int id)
        {
            string sql = "SELECT * FROM searches WHERE UserID = @UserID";
            List<SearchModel> SMS = _db.LoadData<SearchModel, dynamic>(sql, new { UserID = id });
            return SMS;
        }

        public List<SearchModel> GetSearchesByCarID(int id)
        {
            string sql = "SELECT * FROM searches WHERE CarID = @CarID";
            List<SearchModel> SMS = _db.LoadData<SearchModel, dynamic>(sql, new { CarID = id });
            return SMS;
        }

        public List<SearchModel> GetSearchesBySearchID(int id)
        {
            string sql = "SELECT * FROM searches WHERE SearchID = @SearchID";
            List<SearchModel> SMS = _db.LoadData<SearchModel, dynamic>(sql, new { SearchID = id });
            return SMS;
        }

        public List<SearchModel> GetCarBySearch(int id)
        { 
            string sql = "SELECT * FROM searches WHERE SearchID = @SearchID";
            List<SearchModel> Car = _db.LoadData<SearchModel, dynamic>(sql, new { CarID = id });
            return Car; 
        }


        public void CreateSearch(SearchModel s)
        {
            string sql = "INSERT INTO searches (`UserID`, `CarID`) VALUES (@UserID, @CarID)";

            _db.SaveData(sql, s);
        }

        public void DeleteSearch(SearchModel s)
        {
            string sql = "DELETE FROM searches WHERE `searches`.`SearchID` = @SearchID";

            _db.SaveData(sql, s);
        }
    }
}