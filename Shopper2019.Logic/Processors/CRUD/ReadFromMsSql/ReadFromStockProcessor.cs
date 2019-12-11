using Autofac;
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
        IContainer container;
        ISaleItem item;
        public ReadFromStockProcessor()
        {
            container = DI_Container.Configure();
        }

        private static SqlConnection sqlConnection = new SqlConnection
                        ("Server=.\\SQLEXPR;User=sa;Password=12trzy;Database=Shopper2019Db");
        private static SqlCommand sqlCommand;
        private string sqlQuery = "";
        private static SqlDataReader reader;


        public ISaleItem FindItemInStock (string itemCode)
        {

            //ISaleItem item = Factory.CreateSaleItem();
            //item = Factory.CreateSaleItem();
            item = container.Resolve<ISaleItem>();


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
            if (searchCode == item.Code && item.SaleQuantity >= searchQuantity && searchQuantity > 0)
            {
                item.SaleQuantity = searchQuantity;
                return item;
            }
                
            else return null;
        }

    }
}
