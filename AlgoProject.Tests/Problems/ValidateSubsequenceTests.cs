using NUnit.Framework;
using AlgoProject.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoProject.Tests.Problems
{
    [TestFixture]
    public class ValidateSubsequenceTests
    {
        [Test]
        [TestCase(new int[] {1,4,6,4,5}, new int[] {4,4,5})]
        [TestCase(new int[] {3,-4,3,7,6,4}, new int[] {3,3,7,4})]
        public void IsValidSubsequence_IsASubsequence_ReturnsTrue(int[] list, int[] sub)
        {
            List<int> listArr = list.ToList();
            List<int> subArr = sub.ToList();

            bool answer = ValidateSubsequence.IsValidSubsequence(listArr, subArr);

            Assert.That(answer, Is.True);

        }

        [Test]
        [TestCase(new int[] {8,7,3,1,4}, new int[] {8,3,1,2})]
        public void IsValidSubsequence_NotASubsequence_ReturnsFalse(int[] list, int[] sub)
        {
            List<int> listArr = list.ToList();
            List<int> subArr = sub.ToList();

            bool answer = ValidateSubsequence.IsValidSubsequence(listArr, subArr);

            Assert.That(answer, Is.False);

        }
    }
}
