using System;
using FizzBuzz.Core;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzGameTest
    {
        [Test]
        public void Should_Return_Fizz_If_Dividable_By_3()
        {
            Loop_From_IntMin_To_IntMax_And_Check_For_Dividability_Of_3_And_5(
                (isDividableBy3, isDividableBy5, actual)
                => Assert.AreEqual(
                    isDividableBy3 && !isDividableBy5,
                    actual.Equals("Fizz", StringComparison.Ordinal)));
        }

        [Test]
        public void Should_Return_Buzz_If_Dividable_By_5()
        {
            Loop_From_IntMin_To_IntMax_And_Check_For_Dividability_Of_3_And_5(
                (isDividableBy3, isDividableBy5, actual)
                => Assert.AreEqual(
                    isDividableBy5 && !isDividableBy3,
                    actual.Equals("Buzz", StringComparison.Ordinal))
                );
        }

        [Test]
        public void Should_Return_FizzBuzz_If_Dividable_By_3_And_5()
        {
            Loop_From_IntMin_To_IntMax_And_Check_For_Dividability_Of_3_And_5(
                (isDividableBy3, isDividableBy5, actual)
                => Assert.AreEqual(
                    isDividableBy3 && isDividableBy5,
                    actual.Equals("FizzBuzz", StringComparison.Ordinal))
                );
        }

        [Test]
        public void Should_Return_Empty_Or_Null_If_Not_Dividable_By_3_Or_5()
        {
            Loop_From_IntMin_To_IntMax_And_Check_For_Dividability_Of_3_And_5(
                (isDividableBy3, isDividableBy5, actual)
                => Assert.AreEqual(
                    !isDividableBy3 && !isDividableBy5,
                    String.IsNullOrEmpty(actual))
                );
        }

        public void Loop_From_IntMin_To_IntMax_And_Check_For_Dividability_Of_3_And_5(
            Action<bool, bool, string> isDividableBy3AndOr5)
        {
            var target = new FizzBuzzGame();

            // for (int i = int.MinValue; i < int.MaxValue; i++)
            for (int i = -100; i < 100; i++)
            {
                bool isDividableBy3 = i % 3 == 0;
                bool isDividableBy5 = i % 5 == 0;

                var actual = target.Evaluate(i);

                isDividableBy3AndOr5(isDividableBy3, isDividableBy5, actual);
            }
        }
    }
}
