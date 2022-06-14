using System;
using Xunit;
using DiceRoll3;
using System.Linq;

namespace DiceRoll3Tests
{
    public class UnitTest1
    {
         [Theory]
        [InlineData(new int[]{2, 7, 3, 11, 2, 2}, 4.50)]
        [InlineData(new int[]{ 18, 4, 6, 12, 19 }, 11.80)]
        [InlineData(new int[]{ 5 }, 5)]
        [InlineData(new int[]{ 0 }, 0)]
        public void TestAverage( int[] nums, double expected )
        {
            var DuhNewGame = new ClGame();

            DuhNewGame.Results = nums.ToList();

            
            double r = DuhNewGame.GetAverage();

            // assert 

            Assert.Equal(expected, r );



            

        }

        [Theory]
        [InlineData(new int[]{2, 7, 3, 11, 2, 2}, 27)]
        [InlineData(new int[]{ 18, 4, 6, 12, 19 }, 59)]
        [InlineData(new int[]{ 5 }, 5)]
        [InlineData(new int[]{ 0 }, 0)]
        public void TestTotal( int[] nums, int expected)
        {
            var DuhNewGame = new ClGame();
            DuhNewGame.Results = nums.ToList();

            int total = DuhNewGame.GetTotal();

            Assert.Equal(expected, total );


        }


    }
}
