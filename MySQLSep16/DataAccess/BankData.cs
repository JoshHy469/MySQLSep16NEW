using MySQLSep16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLSep16.DataAccess
{
    internal class BankData
    {
        //CRUD: Create, Read, Update, Delete

        private readonly ISqlDataAccess _db = new SqlDataAccess();
        public List<BankModel> ReadAllTransactions()
        {
            string sql = "SELECT* FROM tx_history";
            List<BankModel> BankTransactions = _db.LoadData<BankModel, dynamic>(sql, new { });
  
            return BankTransactions;
        }

        public BankModel ReadTransactionByID(int id)
        {
            string sql = "SELECT * FROM tx_history WHERE txID = @txID";

            List<BankModel> transaction = _db.LoadData<BankModel, dynamic>(sql, new { txID = id });

            return transaction.FirstOrDefault(u => u.txID == id);
        }

        public void CreateTransaction(BankModel bT)
        {
            string sql = "INSERT INTO `tx_history` (`Amt`, `txDate`, `tx_type_typeID`) VALUES (@Amt, @txDate, @tx_type_typeID)";

            _db.SaveData(sql, bT);
        }

    }
}
