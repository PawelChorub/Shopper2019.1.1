using Autofac;
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
    public class ReadFromStockProcessor : IReadFromStockProcessor
    {
        IContainer container;
        ISaleItem saleItem;

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
            saleItem = container.Resolve<ISaleItem>();

            try
            {
                sqlConnection.Open();
                sqlQuery = string.Format("select * from Shopper2019StockTable WHERE code = '{0}'", itemCode);
                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        saleItem.Code = (reader["code"].ToString());
                        saleItem.Name = (reader["name"].ToString());

                        saleItem.SaleQuantity = (decimal)reader["quantity"];
                        saleItem.UnitOfMeasurements = (reader["unitOfMeasurement"].ToString());
                        saleItem.VatValue = (Int32.Parse(reader["vatTax"].ToString()));
                        saleItem.Net_Price = (decimal)reader["netPrice"];
                        saleItem.Gross_Price = (decimal)reader["grossPrice"];

                        //UnitOfMeasureGet = (reader["unitOfMeasure"].ToString());
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nieoczekiwany błąd, szczegóły : " + ex.ToString());
            }

            return saleItem;
        }

        public ISaleItem CheckExistenceItemInStock(string searchCode, decimal searchQuantity)
        {
            if (searchCode == saleItem.Code && saleItem.SaleQuantity >= searchQuantity && searchQuantity > 0)
            {
                saleItem.SaleQuantity = searchQuantity;
                return saleItem;
            }               
            else return null;
        }

    }
}
