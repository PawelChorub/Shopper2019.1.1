using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic.Processors.UpdateInMsSql
{
    public class UpdateStockItemProcessor : IUpdateStockItemProcessor
    {
        private static SqlConnection sqlConnection = new SqlConnection
          ("Server=.\\SQLEXPR;User=sa;Password=12trzy;Database=Shopper2019Db");
        private static SqlCommand sqlCommand;
        private string sqlQuery = "";

        public void DecreaseStockItemQuantity(string code, decimal quantity)
        {
            string specifier;
            CultureInfo culture;
            specifier = "F";
            culture = CultureInfo.CreateSpecificCulture("en-CA");

            string q = (quantity.ToString(specifier, culture));
            sqlQuery = string.Format("UPDATE Shopper2019StockTable set quantity -= {0} where code = '{1}'", q, code);
            sqlConnection.Open();
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        // brakuje: aktualizacja ceny zakupu, jeśli jest inna, ew. podział na partie dostaw.
        public void IncreaseStockItemQuantity(string code, decimal quantity)
        {
            string specifier;
            CultureInfo culture;
            specifier = "F";
            culture = CultureInfo.CreateSpecificCulture("en-CA");

            string q = (quantity.ToString(specifier, culture));
            sqlQuery = string.Format("UPDATE Shopper2019StockTable set quantity += '{0}' where code = '{1}'", q, code);
            sqlConnection.Open();
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void DecreaseSaleItemListToDatabase(List<ISaleItem> listName)
        {
            foreach (var item in listName)
            {
                DecreaseStockItemQuantity(item.Code, item.SaleQuantity);
            }
        }

    }
}
