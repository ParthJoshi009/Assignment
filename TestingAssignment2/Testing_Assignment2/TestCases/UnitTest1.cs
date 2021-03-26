using System;
using Xunit;
using Operations;

namespace TestCases
{
    public class UnitTest1
    {
        [Fact]
        public void Test_ConvertLowerCasePass()
        {
            // Arrange
            string str = "HELLO";
            string exp = "hello";
            // Act
            var res = str.ConvertLowerCase();
            // Assert
            Assert.Equal(exp,res);
        }
        [Fact]
        public void Test_ConvertLowerCaseFail()
        {
            // Arrange
            string str = "HELLO";
            string exp = "HELLO";
            // Act
            var res = str.ConvertLowerCase();
            // Assert
            Assert.NotEqual(exp, res);
        }

        [Fact]
        public void Test_ConvertUpperCasePass()
        {
            // Arrange
            string str = "hello";
            string exp = "HELLO";
            // Act
            var res = str.ConvertUpperCase();
            // Assert
            Assert.Equal(exp, res);
        }
        [Fact]
        public void Test_ConvertUpperCaseFail()
        {
            // Arrange
            string str = "hello";
            string exp = "hell0";
            // Act
            var res = str.ConvertUpperCase();
            // Assert
            Assert.NotEqual(exp, res);
        }
        [Fact]
        public void Test_ConvertTitleCasePass()
        {
            // Arrange
            string str = "Hello How Are You";
            string exp = "Hello How Are You";
            // Act
            var res = str.ConvertTitleCase();
            // Assert
            Assert.Equal(exp, res);
        }
        [Fact]
        public void Test_ConvertTitleCaseFail()
        {
            // Arrange
            var str = "Hello How Are You";
            var exp = "hello how are you";
            // Act
            var res = str.ConvertTitleCase();
            // Assert
            Assert.NotEqual(exp, res);
        }
        [Fact]
        public void Test_AllCharLowerCasePass()
        {
            // Arrange
            string str = "hello";
            //string exp = "hello";
            //var operation = ();
            var exp = str.AllCharLowerCase();
            // Act
            var res = str.AllCharLowerCase();
            // Assert
            Assert.True(res);
        }
        [Fact]
        public void Test_AllCharLowerCaseFail()
        {
            // Arrange
            //string str = "hello";
            //string exp = "hello";
             var exp = "HELLO";
            // Act
            var res = exp.AllCharLowerCase();
            // Assert
            Assert.False(res);
        }

        [Fact]
        public void Test_ConvertCharFirstUpperCasePass()
        {
            // Arrange
            string str = "Hello";
            string exp = "Hello";
            // Act
            var res = StringOperation.ConvertCharFirstUpperCase(exp);
            // Assert
            Assert.Equal(str,res);
        }
        [Fact]
        public void Test_ConvertCharFirstUpperCaseFail()
        {
            // Arrange
            string str = "HELLO";
            string exp = "hello";
            // Act
            var res = StringOperation.ConvertCharFirstUpperCase(exp);
            // Assert
            Assert.NotEqual(str,res);
        }
        [Fact]
        public void Test_AllCharUpperCasePass()
        {
            // Arrange
            var exp = "HELLO";
            // Act
            var res = exp.AllCharUpperCase();
            // Assert
            Assert.True(res);
        }
        [Fact]
        public void Test_AllCharUpperCaseFail()
        {
            // Arrange
            var exp = "hello";
            // Act
            var res = exp.AllCharUpperCase();
            // Assert
            Assert.False(res);
        }
        [Fact]
        public void Test_ValidNumValuePass()
        {
            // Arrange
            var exp = "12345";
            // Act
            var res = exp.ValidNumValue();
            // Assert
            Assert.True(res);
        }
        [Fact]
        public void Test_ValidNumValueFail()
        {
            // Arrange
            var exp = "Hello";
            // Act
            var res = exp.ValidNumValue();
            // Assert
            Assert.False(res);
        }
        [Fact]
        public void Test_RemoveLastCharPass()
        {
            // Arrange
            var str = "Hello";
            var exp = "Hell";
            // Act
            var res = str.RemoveLastChar();
            // Assert
            Assert.Equal(exp,res);
        }
        [Fact]
        public void Test_RemoveLastCharFail()
        {
            // Arrange
            var str = "Hello";
            var exp = "Hello";
            // Act
            var res = str.RemoveLastChar();
            // Assert
            Assert.NotEqual(exp, res);
        }
        [Fact]
        public void Test_WordCountPass()
        {
            // Arrange
            var str = "Hello How";
            var exp = 2;
            // Act
            var res = str.WordCount();
            // Assert
            Assert.Equal(exp, res);
        }
        [Fact]
        public void Test_WordCountFail()
        {
            // Arrange
            var str = "Hello How are";
            var exp = 13;
            // Act
            var res = str.WordCount();
            // Assert
            Assert.NotEqual(exp, res);
        }
        [Fact]
        public void Test_ConvaertStrToIntPass()
        {
            // Arrange
            var str = "1";
            var exp = 1;
            // Act
            var res = str.ConvaertStrToInt();
            // Assert
            Assert.Equal(exp, res);
        }
        [Fact]
        public void Test_ConvaertStrToIntFail()
        {
            // Arrange
            var str = "54";
            var exp = 45;
            // Act
            var res = str.ConvaertStrToInt();
            // Assert
            Assert.NotEqual(exp, res);
        }
    }
}
