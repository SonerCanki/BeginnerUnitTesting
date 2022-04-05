using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void Removing_WhiteSpaces_AtBeginning_And_AtTheAnd()
        {
            //Arrange

            var expression = "     Soner Canki    ";
            var expected = "Soner Canki";

            //Act

            var result = StringHelper.RemoveExtraSpaces(expression);

            //Assert

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void Removing_WhiteSpaces_InInside()
        {
            //Arrange

            var expression = "Soner   Zeynep    Özlem     Tuncay   Alihan";
            var expected = "Soner Zeynep Özlem Tuncay Alihan";

            //Act

            var result = StringHelper.RemoveExtraSpaces(expression);

            //Assert

            Assert.AreEqual(expected, result);
        }
    }
}
