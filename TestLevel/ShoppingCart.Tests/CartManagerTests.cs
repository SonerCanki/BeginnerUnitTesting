using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartManagerTests
    {
        private CartManager _cartManager;
        private CartItem _cartItem;
        [TestInitialize]
        public void TestInitialize()
        {
             _cartManager = new CartManager();
             _cartItem = new CartItem
            {
                Product = new Product
                {
                    Id = 1,
                    ProductName = "Laptop",
                    UnitPrice = 5000
                },
                Quantity = 1
            };

            _cartManager.Add(_cartItem);
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            _cartManager.Clear();
        }

        [TestMethod]
        public void Adding_Item_Into_Cart()
        {
            //Arrange
            const int expected = 1;
            //Act

            var totalItems = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(expected, totalItems);
        }
        [TestMethod]
        public void Removing_Item_From_Cart()
        {
            //Arrange
            var totalItems = _cartManager.TotalItems;
            //Act

            _cartManager.Remove(1);

            var afterRemoving = _cartManager.TotalItems;
            //Assert
            Assert.AreEqual(totalItems - 1, afterRemoving);
        }
        [TestMethod]
        public void Clearing_Cart()
        {
            //Arrange

            //Act
            _cartManager.Clear();

            //Assert
            Assert.AreEqual(0, _cartManager.TotalItems);
        }
    }
}
