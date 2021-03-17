using System;
using System.Collections.Generic;
using System.Text;
using AlgoProject.Problems;
using NUnit.Framework;

namespace AlgoProject.Tests.Problems
{
    [TestFixture]
    public class SortedSquaredArrayTests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 4, 9 })]
        [TestCase(new int[] {0}, new int[] {0})]
        [TestCase(new int[] {-5, -4, -3, -2, -1}, new int[] {1,4,9,16,25})]
        public void SquareArray_GivenSortedArrayBAD_AllElementsSquaredInNewArray(int[] arr, int[] expected)
        {
            var squaredArr = SortedSquaredArray.SquareArray(arr);

            Assert.That(squaredArr, Is.EquivalentTo(expected));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 4, 9 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { -5, -4, -3, -2, -1 }, new int[] { 1, 4, 9, 16, 25 })]
        public void SquareArray_GivenSortedArrayOptimal_AllElementsSquaredInNewArray(int[] arr, int[] expected)
        {
            var squaredArr = SortedSquaredArray.SquareArray2(arr);

            Assert.That(squaredArr, Is.EquivalentTo(expected));
        }
    }
}
