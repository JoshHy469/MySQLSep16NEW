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

        public List<BankModel> ReadAllTransactionsWithType()
        {
            string sql = "SELECT tx_histor.txID, tx_history.Amt, tx_history.Date, tx_type.Type FROM tx_history INNER JOIN ty_type ON tx_history.tx_type_typeID=tx_type.typeID";
            List<BankModel> BankTransactions = _db.LoadData<BankModel, dynamic>(sql, new { });

            return BankTransactions;
        }
    }
}
