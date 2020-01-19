using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Get_Returns_1_For_1()
        {
            var fizzBuzz = new FizzBuzzClass();
            var result = fizzBuzz.Get(1);
            Assert.Equal("1", result);
        }

        [Fact]
        public void Get_Returns_2_For_2()
        {
            var fizzBuzz = new FizzBuzzClass();
            var result = fizzBuzz.Get(2);
            Assert.Equal("2", result);
        }

        [Fact]
        public void Get_Returns_3_For_3()
        {
            var fizzBuzz = new FizzBuzzClass();
            var result = fizzBuzz.Get(3);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Get_Returns_6_For_6()
        {
            var fizzBuzz = new FizzBuzzClass();
            var result = fizzBuzz.Get(6);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Get_Returns_5_For_5()
        {
            var fizzBuzz = new FizzBuzzClass();
            var result = fizzBuzz.Get(5);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Get_Returns_10_For_10()
        {
            var fizzBuzz = new FizzBuzzClass();
            var result = fizzBuzz.Get(10);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Get_Returns_15_For_15()
        {
            var fizzBuzz = new FizzBuzzClass();
            var result = fizzBuzz.Get(15);
            Assert.Equal("Fizzbuzz", result);
        }

        [Fact]
        public void Get_Returns_30_For_30()
        {
            var fizzBuzz = new FizzBuzzClass();
            var result = fizzBuzz.Get(30);
            Assert.Equal("Fizzbuzz", result);
        }
    }
}
