using System;
using Xunit;
using XUnitIntroPractice;

namespace XUnitIntroPractice_Tests
{
    
    public class Program_Tests
    {
        /*
         * an XUnit test method to test the trimming of whitespace (both spaces and tabs) before and after the text.
        */
        [Theory]
        [InlineData(" Y ", true)]
        [InlineData("    Y ", true)]
        [InlineData("    Yes     ", true)]
        [InlineData("N     ", true)]        
        [InlineData("               N         ", true)]
        [InlineData("                N", true)]
        [InlineData("N  O    ", false)]
        [InlineData("YE           S     ", false)]
        [InlineData("     Y    E    S    ", false)]
        public void TestTrimmingWhitespaces( string input, bool expected )
        {
            bool output;
            output = Program.IsYesOrNo(input);

            Assert.Equal(expected, output);
        }

        // an XUnit test method that will test the conversion to uppercase
        [Theory]
        [InlineData("y", true)]
        [InlineData("No", true)]
        [InlineData("YeS", true)]
        public void TestConversionToUppercase( string input, bool expected )
        {
            bool output;
            output = Program.IsYesOrNo(input);
            Assert.Equal(output, expected);
        }

        //an XUnit test method for all accepted values
        [Theory]
        [InlineData("y", true)]
        [InlineData("   No ", true)]
        [InlineData(" YeS               ", true)]
        [InlineData("   yeS         ", true)]
        public void TestAllAcceptedValues(string input, bool expected)
        {
            bool output;
            output = Program.IsYesOrNo(input);
            Assert.Equal(output, expected);
        }

        //an XUnit test method for invalid values. Include at least one single character invalid value, one multiple character one, and an empty string.
        [Theory]
        [InlineData("r", false)]
        [InlineData(" row  ", false)]
        [InlineData("", false)]
        [InlineData("           ", false)]
        [InlineData("y E S", false)]
        [InlineData("   N0 ", false)]
        [InlineData(" Y Es               ", false)]
        [InlineData("   In         ", false)]
        public void TestInvalidValues(string input, bool expected)
        {
            bool output;
            output = Program.IsYesOrNo(input);
            Assert.Equal(output, expected);
        }

        [Fact]
        public void FormatException_Test()
        {
            // Arrange - N/A

            // Act - N/A

            // Assert
            Assert.Throws<FormatException>(() => {
                // This code block should throw an Exception of the type in the angle brackets.
                Program.ThrowsFormatException();
            });
        }


        [Fact]
        public void IndexOutOfRangeException_Test()
        {
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => {
                // This code block should throw an Exception of the type in the angle brackets.
                Program.ThrowsIndexOutOfRangeException();
            });
        }

        [Fact]
        public void NullReferenceException_Test()
        {
            // Assert
            Assert.Throws<NullReferenceException>(() => {
                // This code block should throw an Exception of the type in the angle brackets.
                Program.ThrowsNullReferenceException();
            });
        }

        [Fact]
        public void DivideByZeroException_Test()
        {
            // Assert
            Assert.Throws<DivideByZeroException>(() => {
                // This code block should throw an Exception of the type in the angle brackets.
                Program.ThrowsDivideByZeroException();
            });
        }

        [Fact]
        public void StackOverflowException_Test()
        {
            // Assert
            Assert.Throws<StackOverflowException>(() => {
                // This code block should throw an Exception of the type in the angle brackets.
                Program.ThrowsStackOverflowException();
            });
        }
    }
}
