using AlgoProject.Problems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProject.Tests.Problems
{
    [TestFixture]
    public class TwoNumberSumTests
    {
        [Test]
        [TestCase(new int[0], new int[0], 0)]
        [TestCase(new int[] { 1, 2 }, new int[] { 1, 2 }, 3)]
        [TestCase(new int[] { 1, 5, 7, 2 }, new int[] { 5, 2 }, 7)]
        [TestCase(new int[] { 7, 3, 2, 5, 6, 4 }, new int[] { 3, 4 }, 7)]
        [TestCase(new int[]{3, 5, -4, 8, 11, 1, -1, 6}, new int [] {11, -1}, 10)]
        public void TwoNumberSumWorker_EmptyArr_ReturnEmptyArray(int[] input, int[] answer, int targetSum)
        {
            var arr = TwoNumberSum.TwoNumberSumWorker(input, targetSum);

            Assert.That(arr, Is.EquivalentTo(answer));
        }

        [Test]
        [TestCase(new int[0], new int[0], 0)]
        [TestCase(new int[] { 1, 2 }, new int[] { 1, 2 }, 3)]
        [TestCase(new int[] { 1, 5, 7, 2 }, new int[] { 5, 2 }, 7)]
        [TestCase(new int[] { 7, 3, 2, 5, 6, 4 }, new int[] { 2,5 }, 7)]
        [TestCase(new int[] {3, 5, -4, 8, 11, 1, -1, 6}, new int[] {11, -1 }, 10)]
        public void TwoNumberSumWorker2_WhenCalled_ReturnEmptyArray(int[] input, int[] answer, int targetSum)
        {
            var arr = TwoNumberSum.TwoNumberSumWorker2(input, targetSum);

            Assert.That(arr, Is.EquivalentTo(answer));
        }
    }
}
