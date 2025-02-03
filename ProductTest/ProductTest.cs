using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_Assignment2_Group4;
using NUnit.Framework;

namespace ProductTest
{
	[TestFixture]
	public class ProductTest
    {
		//Test Case For	Product ID
		//Created by : Sahil Halwawala

		//Test 1 : Check if the Product ID is valid
		[Test]
		public void ProductID_InputProductID_ValidProductID()
		{
			//Act & Arrange
			int validProdID = 100;
			Product product = new Product(validProdID, "Test Product", 100, 100);

			string expected = "This is a valid Product ID";
			string actual = Product.ValidProdID(validProdID);

			//Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		//Test 2 : Check if the Product ID is in range of 7 to 70000
		[Test]
		public void ProductIDRange_InputProductID_ProductIDInRange() //In range 
		{
			//Act & Arrange
			int productId = 8;
			Product product = new Product(productId, "Test Product", 100, 700);

			string expected = "This is a valid Product ID";
			string actual = Product.ValidProdID(productId);

			//Assert
			Assert.That(expected, Is.EqualTo(actual));

		}

		//Test 3 : Check if the Product ID is null
		[Test]
		public void ProductID_InputNullProductID_ProductIDIsNull()
		{
			//Act & Arrange
			int nullProdID = 0;
			Product product = new Product(nullProdID, "Test Product", 100, 100);

			string expected = "This is a Invalid Product ID";
			string actual = Product.ValidProdID(nullProdID);
			//Assert
			Assert.That(expected, Is.EqualTo(actual));
		}



		//Test Case For Product Name 
		//Created by : Sahil Halwawala

		//Test 4 : Check if the Stock Amount is positive
		[Test]
		public void StockAmount_InputPositiveStockAmount_StockAmountIsPositive()

		{
			//Act & Arrange
			int stockAmount = 10;
			Product product = new Product(1, "Test Product", 100, stockAmount);

			string expected = "Valid Stock Amount";
			string actual = Product.ValidStockAmount(stockAmount);

			//Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		//Test 5 : Check if the Stock Amount is Negative
		[Test]
		public void StockAmount_InputNegativeStockAmount_StockAmountIsNegative()

		{
			int stockAmount = -10;

			//Act & Arrange
			Product product = new Product(10, "Test Product", 100, stockAmount);


			string expected = "Invalid Stock Amount";
			string actual = Product.ValidStockAmount(stockAmount);

			//Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		//Test 6 : Check if the Stock Amount is in range of 7 to 70000
		[Test]
		public void StockAmount_InputRangeStockAmount_StockAmountIsInRange()
		{

			int stockAmount = 10;

			//Act & Arrange
			Product product = new Product(8, "Test Product", 100, stockAmount);
			//Assert

			string expected = "Valid Stock Amount";
			string actual = Product.ValidStockAmount(stockAmount);

			Assert.That(expected, Is.EqualTo(actual));
		}

	}
}
