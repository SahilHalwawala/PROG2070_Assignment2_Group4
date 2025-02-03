using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
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
        //Created by : Sahil Halwawala(8909403)
        
        //I chose to do these test as it is one of the most important test to verify whether the user has input valid product ID

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
        //I chose this test as this test verify the that the product ID is in the given range and also follow Boundary Variable method 
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
        //This test is important as it checks that whether the user forget to input product id and gives a validation to enter the product ID
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
        //Created by : Sahil Halwawala (8909493)

        //Test 4 : Check if the Stock Amount is positive
        //I chose this test as this test will check whether the stock amount is positive and if positive it will be a Valid Stock Amount
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

        //I chose this test as this test will check whether the stock amount is negative and if negative it will be a Invalid Stock Amount
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

        //I chose this test as this test help to verify that the stock amount is in range and if in range it returns Valid Stock Amount also follows Boundary Variable Method
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

        //Test Case For Item Price
        //Created by : Nisarg Khyali(8910019)

        //I chose this test as it helps to check if the item price written is null or not, if it is so it will return "Invalid item price"
        //Test 7 : Check if the item price is null
        [Test]
        public void ItemPrice_InputNullItemPrice_ItemPriceIsNull()

        {
            //Act & Arrange
            int nullItemPrice = 0;
            Product product = new Product(8, "Test Product", 100, nullItemPrice);

            string expected = "Invalid item price";
            string actual = Product.ValiditemPrice(nullItemPrice);

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        //I chose this test case as it checks whether the item price is in range or not, if it comes out to be in range then it will return valid item price
        //Test 8 : Check if the item price is in range of 7 to 7000
        [Test]
        public void ItemPrice_InputRangeItemPrice_ItemPriceIsInRange()
        {
            int itemPrice = 100;
            //Act & Arrange
            Product product = new Product(8, "Test Product", itemPrice, 10);

            string expected = "Valid item price";
            string actual = Product.ValiditemPrice(itemPrice);

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        //I chose this as it will find if the item is in range or not 
        //Test 9 : Check if the item price is out of range
        [Test]
        public void ItemPrice_InputOutOfRangeItemPrice_ItemPriceIsInOutOfRange()
        {
            int itemPrice = 1;

            //Act & Arrange
            Product product = new Product(8, "Test Product", itemPrice, 0);

            string expected = "Invalid item price";
            string actual = Product.ValiditemPrice(itemPrice);

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        //Test Case For Product Name 
        //Created by : Nisarg Khyali (8910019)

        //This test case will validate the product name, whether it is valid or not 
        //Test 10 : Check if Product Name is valid 
        [Test]

        public void ProductName_InputProductName_ProductNameValid()
        {
            string ProdName = "XYZ Test";
            //Act & Arrange
            Product product = new Product(9, ProdName, 100, 100);

            string expected = "This is a valid Product Name";
            string actual = Product.ValidProdName(ProdName);

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        //Test 11 : Check if Product Name is  null
        [Test]
        public void ProductName_InputNullProductName_ProductNameIsNull()
        {
            string ProdName = "";
            //Act & Arrange
            Product product = new Product(9, ProdName, 100, 100);

            string expected = "Please Enter a Valid Name as the product name cannot be null";
            string actual = Product.ValidProdName(ProdName);
            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        //Test 12 : Check if Product Name is string
        [Test]
        public void ProductName_InputStringProductName_ProductNameIsString()
        {
            string ProdName = "String";
            //Act & Arrange
            Product product = new Product(9, ProdName, 100, 100);

            string expected = "This is a valid Product Name";
            string actual = Product.ValidProdName(ProdName);

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        //TestCase for IncreaseStockPrice and DecreaseStockPrice
        //Created by : Maranata Netserab (89228473)

        //Test 13 : Check if the Stock Amount is Increasing and returning the valid passed test case
        [Test]
        public void IncreaseStockAmount_InputIncreaseStockAmount_IncreaseStockAmount()
        {
            int amount = 10;
            int StockAmount = 100;
            int increaseStock = 110;
            //Act & Arrange

            Product product = new Product(9, "Test Product", 100, 110);

            string expected = "Valid Increase Stock Amount";
            string actual = Product.ValidateIncreaseStockAmount(amount, StockAmount);

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        //Test 14 : Check if the Stock Amount is Decreasing and returning the valid passed test case
        [Test]
        public void DecreaseStockAmount_InputDecreaseStockAmount_DecreaseStockAmount()
        {
            int amount = 10;
            int StockAmount = 100;
            //Act & Arrange
            Product product = new Product(9, "Test Product", 100, 10);
            string expected = "Valid Decrease Stock Amount";
            string actual = Product.ValidateDecreaseStockAmount(amount, StockAmount);
            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        //Test 15 : Check if the increased stock amount is in the range of 7 to 700000
        [Test]

        public void IncreaseStockAmount_InputIncreaseStockAmount_IncreaseStockAmountInRange()
        {
            int amount = 1000;
            int StockAmount = 10000;
            //Act & Arrange
            Product product = new Product(9, "Test Product", 100, 10000);
            string expected = "Valid Increase Stock Amount";
            string actual = Product.ValidateIncreaseStockAmount(amount, StockAmount);
            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        //Test 16 : Check if the decreased stock amount is in the range of 7 to 700000
        [Test]

        public void DecreaseStockAmount_InputDecreaseStockAmount_DecreaseStockAmountInRange()
        {
            int amount = 100;
            int StockAmount = 1000;
            //Act & Arrange
            Product product = new Product(9, "Test Product", 100, 900);
            string expected = "Valid Decrease Stock Amount";
            string actual = Product.ValidateDecreaseStockAmount(amount, StockAmount);
            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        //Test 17 : Check if the increased stock amount is less than 0

        [Test]
        public void IncreaseStockAmount_InputIncreaseStockAmount_IncreaseStockAmountLessThanZero()
        {
            int amount = -1000;
            int StockAmount = 100;
            int increaseStock = -900;
            //Act & Arrange
            Product product = new Product(9, "Test Product", 100, -900);
            string expected = "Invalid Increase Stock Amount";
            string actual = Product.ValidateIncreaseStockAmount(increaseStock, amount);
            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        //Test 18 : Check if the decreased stock amount is less than 0
        [Test]
        public void DecreaseStockAmount_InputDecreaseStockAmount_DecreaseStockAmountLessThanZero()
        {
            int amount = -300;
            int StockAmount = 100;
            int decreaseStock = -200;
            //Act & Arrange
            Product product = new Product(9, "Test Product", 100, -200);
            string expected = "Invalid Decrease Stock Amount";
            string actual = Product.ValidateDecreaseStockAmount(amount, decreaseStock);
            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
