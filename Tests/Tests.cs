using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {
        public GroupTwoFunctions fn;
        public MiscLibTests(){
            fn = new GroupTwoFunctions();
        }
        // Write Unit Tests for all functions for your assigned group
        [Fact]
        public void CalcRectPerimeterTest(){
            Assert.Equal(0,fn.CalcRectPerimeter(0,0));
            Assert.Equal(2,fn.CalcRectPerimeter(1,0));
            Assert.Equal(2,fn.CalcRectPerimeter(0,1));
            Assert.Equal(4,fn.CalcRectPerimeter(1,1));
            Assert.Equal(5526,fn.CalcRectPerimeter(694,2069));
        }

        [Fact]
        public void IsTriangularNumTest(){
            Assert.Equal(true,fn.IsTriangularNum(0));
            Assert.Equal(true,fn.IsTriangularNum(1));
            Assert.Equal(false,fn.IsTriangularNum(2));
            Assert.Equal(true,fn.IsTriangularNum(10));
            Assert.Equal(false,fn.IsTriangularNum(11));
            Assert.Equal(true,fn.IsTriangularNum(15));
            Assert.Equal(false,fn.IsTriangularNum(16));
            Assert.Equal(false,fn.IsTriangularNum(20));
            Assert.Equal(true,fn.IsTriangularNum(21));
        }

        [Fact]
        public void FarenheitToCelciusTest(){
            Assert.Equal(-18,fn.FarenheitToCelcius(0));
            Assert.Equal(0,fn.FarenheitToCelcius(32));
            Assert.Equal(9,fn.FarenheitToCelcius(48));
            Assert.Equal(38,fn.FarenheitToCelcius(100));
            Assert.Equal(100,fn.FarenheitToCelcius(212));
        }

        [Fact]
        public void CheckWhiteSpaceTest(){
            Assert.Equal(true,fn.CheckWhiteSpace(" leading"));
            Assert.Equal(true,fn.CheckWhiteSpace("  leading"));
            Assert.Equal(true,fn.CheckWhiteSpace("trailing "));
            Assert.Equal(true,fn.CheckWhiteSpace("trailing    "));
            Assert.Equal(false,fn.CheckWhiteSpace("none"));
            // Assert.Equal(true,fn.CheckWhiteSpace("newline\n"));
            // Assert.Equal(true,fn.CheckWhiteSpace("\nnewline"));
        }

        [Fact]
        public void CamelStringTest(){
            Assert.Equal("CaMeLcAsE",fn.CamelString("camelcase"));
            Assert.Equal("CaMeLcAsE",fn.CamelString("CAMELCASE"));
            Assert.Equal("CaMeLcAsE",fn.CamelString("cAmElCaSe"));
            Assert.Equal(" cAmElCaSe",fn.CamelString(" camelcase"));
            Assert.Equal("CaMeL CaSe",fn.CamelString("camel case"));
        }

        [Fact]
        public void CountDigitsTest(){
            Assert.Equal(0,fn.CountDigits("string"));
            Assert.Equal(1,fn.CountDigits("1one"));
            Assert.Equal(2,fn.CountDigits("12two"));
            Assert.Equal(2,fn.CountDigits("1two2"));
            Assert.Equal(2,fn.CountDigits("12"));
            Assert.Equal(10,fn.CountDigits("1234567890"));
        }
    }
}
