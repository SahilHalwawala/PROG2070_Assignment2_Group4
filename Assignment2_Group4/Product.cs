using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Assignment2_Group4
{
	public class Product
	{

		public int ProdID;
		public string ProdName;
		public double itemPrice;
		public int StockAmount;


		public int amount;


		public Product(int ProdID, string ProdName, double itemPrice, int StockAmount)
		{
			this.ProdID = ProdID;
			this.ProdName = ProdName;
			this.itemPrice = itemPrice;
			this.StockAmount = StockAmount;
		}

		public static string ValiditemPrice(double itemPrice)
		{
			if (itemPrice >= 7 && itemPrice <= 7000)
			{
				return "Valid item price";
			}
			else
			{
				return "Invalid item price";
			}

		}

		public static string ValidStockAmount(int StockAmount)
		{
			if (StockAmount >= 7 && StockAmount <= 700000)
			{
				return "Valid Stock Amount";
			}
			else
			{
				return "Invalid Stock Amount";
			}
		}

		public static string ValidProdID(int ProdID)
		{
			if (ProdID >= 7 && ProdID <= 70000)
			{
				return "This is a valid Product ID";
			}
			else
			{
				return "This is a Invalid Product ID";
			}
		}

		public static string ValidProdName(string ProdName)
		{
			if (string.IsNullOrEmpty(ProdName))
			{
				return "Please Enter a Valid Name as the product name cannot be null";
			}

			else
			{
				return "This is a valid Product Name";
			}
		}

        public void IncreaseStockPrice(int amount, int StockAmount)
        {
            StockAmount += amount;

        }

        public static string ValidateIncreaseStockAmount(int increaseStock, int amount)
        {
            if (increaseStock >= 7 && increaseStock <= 7000)
            {
                return "Valid Increase Stock Amount";
            }
            else
            {
                return "Invalid Increase Stock Amount";
            }
        }


        public void DecreaseStockAmount(int amount, int StockAmount)
        {
            StockAmount -= amount;
        }

        public static string ValidateDecreaseStockAmount(int amount, int decreaseStock)
        {
            if (decreaseStock >= 7 && decreaseStock <= 7000)
            {
                return "Valid Decrease Stock Amount";
            }
            else
            {
                return "Invalid Decrease Stock Amount";
            }
        }

    }
}