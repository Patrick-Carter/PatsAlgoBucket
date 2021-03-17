using NUnit.Framework;
using AlgoProject.Problems;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProject.Tests.Problems
{
    [TestFixture]
    public class NonConstructibleChangeTests
    {
        [Test]
        [TestCase(new int[] {7}, 1)]
        [TestCase(new int[] { 2,5,6 }, 1)]
        [TestCase(new int[] { 7,2,3 }, 1)]
        public void FindNonConstructibleChange_StartingAmountGreaterThanOne_WillReturnOne(int[] coins, int expexted)
        {
            var change = NonConstructibleChange.FindNonConstructibleChange(coins);

            Assert.That(change, Is.EqualTo(expexted));
        }

        [Test]
        [TestCase(new int[] { 5, 7, 1, 1, 2, 3, 22 }, 20)]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 6)]
        [TestCase(new int[] { 5, 6, 1, 1, 2, 3, 43 }, 19)]
        public void FindNonConstructableChange_StartingAtOne_WillReturnMinimumChange(int[] coins, int expexted)
        {
            var change = NonConstructibleChange.FindNonConstructibleChange(coins);

            Assert.That(change, Is.EqualTo(expexted));
        }
    }
}
