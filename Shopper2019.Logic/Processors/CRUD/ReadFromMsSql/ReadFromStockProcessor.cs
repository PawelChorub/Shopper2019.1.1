using Shopper2019.Logic.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Logic.Processors
{
    public class ReadFromStockProcessor : IReadFromStockProcessor
    {
        // wyszukac ko i ilosc z saleitem
        // odczyt z table
        // porownanie stanu
        // wyslanie do saleitemlist
        private static SqlConnection sqlConnection = new SqlConnection
                        ("Server=.\\SQLEXPR;User=sa;Password=12trzy;Database=Shopper2019Db");
        private static SqlCommand sqlCommand;
        private string sqlQuery = "";
        private static SqlDataReader reader;

        ISaleItem item;

        public ISaleItem FindItemInStock (string itemCode)
        {

            //ISaleItem item = Factory.CreateSaleItem();
            item = Factory.CreateSaleItem();

            sqlConnection.Open();
            sqlQuery = string.Format("select * from Shopper2019StockTable WHERE code = '{0}'", itemCode);
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            reader = sqlCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    item.Code = (reader["code"].ToString());
                    item.Name = (reader["name"].ToString());
                    
                    item.SaleQuantity = (decimal)reader["quantity"];
                    item.UnitOfMeasurements = (reader["unitOfMeasurement"].ToString());
                    item.VatValue = (Int32.Parse(reader["vatTax"].ToString()));
                    item.Net_Price = (decimal)reader["netPrice"];
                    item.Gross_Price = (decimal)reader["grossPrice"];

                    //UnitOfMeasureGet = (reader["unitOfMeasure"].ToString());
                }
            }
            sqlConnection.Close();

            return item;
        }
        public ISaleItem CheckExistenceItemInStock(string searchCode, decimal searchQuantity)
        {
            // zwróć item jeśli ilość będzie się zgadzała!

            if (searchCode == item.Code && item.SaleQuantity >= searchQuantity && searchQuantity > 0)
            {
                item.SaleQuantity = searchQuantity; // przypisz ilość pożądaną i szukaną
                return item;
            }
                
            else return null;
            //double stockQuantityAvailable = 0;
            //ISaleItem item = Factory.CreateSaleItem();
            //ISaleItem outputItem = Factory.CreateSaleItem();

            //sqlConnection.Open();
            //sqlQuery = string.Format("select * from Shopper2019StockTable WHERE code = '{0}'", itemCode);
            //sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            //reader = sqlCommand.ExecuteReader();

            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        item.Code = (reader["code"].ToString());
            //        item.Name = (reader["name"].ToString());

            //        stockQuantityAvailable = (double)reader["quantity"];

            //        if (itemSearchQuantity <= stockQuantityAvailable)
            //        {
            //            item.SaleQuantity = itemSearchQuantity;
            //        }
            //        else
            //        {
            //            item.SaleQuantity = 0;
            //        }

            //        item.VatValue = (Int32.Parse(reader["vatTax"].ToString()));
            //        item.Gross_Price = (double)reader["grossPrice"];

            //        //UnitOfMeasureGet = (reader["unitOfMeasure"].ToString());
            //    }
            //}
            //sqlConnection.Close();

            ////zabezpieczenie znalezienia i ilości
            //if ((itemCode == item.Code) && (itemSearchQuantity == item.SaleQuantity))
            //    outputItem = item;

            //else outputItem = null;

            
        }

    }
}
