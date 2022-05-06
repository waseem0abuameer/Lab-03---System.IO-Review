using System;
using Xunit;
using Review;

namespace TestSystem.IO
{
    public class UnitTest1
    {
       
            [Theory]
            [InlineData("6 7 8", 336)]
            [InlineData("6 7", 0)]
            [InlineData("6 7 8 9", 336)]
            [InlineData("-6 7 8", -336)]            
            public void TestChallenge1(string input, int expected)
            {
                int actual = Program.GetProduct(input);
                Assert.Equal(expected, actual);
            }
            [Theory]
            [InlineData(new int[] { 6, 7, 8 }, 7)]
            
            [InlineData(new int[] { 1, 2, 3, 4 ,6,6}, 3)]
            [InlineData(new int[] { 0, 0, 0, 0 }, 0)]
            public void testChallenge2(int[] arr, int expected)
            {


                int actual = Program.GetAverage(arr, arr.Length);


                Assert.Equal(expected, actual);
            }
            [Theory]
            [InlineData(new int[] { 5, 25, 99, 123, 78, 96, 55, 108, 4 }, 123)]
            [InlineData(new int[] { -5, -1, -3 }, -1)]
            [InlineData(new int[] { -8, -150, -7, 5 }, 5)]
            [InlineData(new int[] { 2, 2, 2, 2 }, 2)]
            public void testChallenge5(int[] arr, int expected)
            {

                int actual = Program.GetMaximum(arr);
                Assert.Equal(expected, actual);
            }
            [Theory]
            [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 }, 1)]
            [InlineData(new int[] { 1, 3, 3, 4, 4 }, 3)]
            [InlineData(new int[] { 6, 6, 6, 6 }, 6)]
            [InlineData(new int[] { 6, 7, 8, 9 }, 6)]
            public void getPopularElementTests(int[] arr, int expected)
            {
                int actual = Program.mostduplicates(arr);
                Assert.Equal(expected, actual);
            }
            [Theory]
            [InlineData("GitHub is where over 83million", new string[] { "\" GitHub : 6 \", ", "\" is : 2 \", ", "\" where : 5 \", ", "\" over : 4 \", ", "\" 83million : 9 \", " })]
            [InlineData("developers shape the future", new string[] { "\" developers : 10 \", ", "\" shape : 5 \", ", "\" the : 3 \", ", "\" future : 6 \", " })]

            public void testChallenge9(string input, string[] expected)
            {

                string[] actual = Program.getword(input);
                Assert.Equal(expected, actual);
            }
        }
    }

