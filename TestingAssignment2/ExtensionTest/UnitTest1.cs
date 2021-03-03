using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ExtensionTest;


namespace ExtensionTest
{
    [TestClass]
    public class UnitTest1
    {
        [Fact]
        public void Test_ConvertLowerCasePass()
        {
            //Arrange
            string str = "Hello";
            //Act
            string result = str.ConvertLowerCase();
            //Assert
            Assert.Equal("Success", result);
        }

        [Fact]
        public void Test_ConvertLowerCaseFail()
        {
            //Arrange
            string str = "hello";
            //Act
            string result = str.ConvertLowerCase();
            //Assert
            Assert.NotEqual("Not Success", result);
        }

      
        [Fact]
        public void Test_ConvertLowerCasePass()
        {
            //Arrange
            string str = "HELLo";
            //Act
            string result = str.ConvertLowerCase();
            //Assert
            Assert.Equal("hello", result);
        }

        //Return a string of Uppercase to Lowercase TEST FAIL.
        [Fact]
        public void Test_ConvertLowerCaseFail()
        {
            //Arrange
            string str = "HELLo";
            //Act
            string result = str.ConvertToLowerCase();
            //Assert
            Assert.NotEqual("Hello", result);
        }

        [Fact]
        public void Test_ConvertTitleCasePass()
        {
            //Arrange
            string str = "hello";
            //Act
            string result = str.ConvertTitleCase();
            //Assert
            Assert.Equal("Hello", result);
        }

        [Fact]
        public void Test_ConvertTitleCaseFail()
        {
            //Arrange
            string str = "HELLO";
            //Act
            string result = str.ConvertTitleCase();
            //Assert
            Assert.NotEqual("hellO", result);
        }

        [Fact]
        public void Test_AllCharLowerCasePass()
        {
            //Arrange
            string str = "hello";
            //Act
            bool result = str.AllCharLowerCase();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Test_AllCharLowerCaseFail()
        {
            //Arrange
            string str = "Hello";
            //Act
            bool result = str.AllCharLowerCase();
            //Assert
            Assert.False(result);
        }

    }
}
