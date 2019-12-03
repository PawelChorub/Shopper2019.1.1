using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopper2019.Logic.Processors
{
    public class SaveToStockProcessor : ISaveToStockProcessor
    {
        
            private static SqlConnection sqlConnection = new SqlConnection
                        ("Server=.\\SQLEXPR;User=sa;Password=12trzy;Database=Shopper2019Db");
            private static SqlCommand sqlCommand;
            private string sqlQuery = "";

        //public void SaveItemToSqlStock(string code, string name, string quantity, string netPrice, string vatTax, string grossPrice)
        public void SaveItemToSqlStock(IStockItem stockItem)
        {
            bool itemExistInTable = false;
            if (!itemExistInTable)
            {
                try
                {
                    string specifier = "F";
                    CultureInfo culture = CultureInfo.CreateSpecificCulture("en-CA");
                    string netPriceString = (stockItem.Net_Price.ToString(specifier, culture));
                    string quantityString = (stockItem.StockQuantity.ToString(specifier, culture));
                    string grossPriceString = (stockItem.Gross_Price.ToString(specifier, culture));
                    // Displays:    00.00

                    sqlConnection.Open();
                    sqlQuery = string.Format("INSERT INTO Shopper2019StockTable (code, name, quantity, unitOfMeasurement, netPrice, vatTax, grossPrice)" +
                        "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    stockItem.Code, stockItem.Name, quantityString, stockItem.UnitOfMeasurements, netPriceString, stockItem.VatValue, grossPriceString);
                    //stockItem.Code, stockItem.Name, stockItem.StockQuantity, stockItem.Net_Price, stockItem.VatValue, stockItem.Gross_Price);
                    sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("blad" + ex.ToString());
                }
               
            }
        }        
    }
}
