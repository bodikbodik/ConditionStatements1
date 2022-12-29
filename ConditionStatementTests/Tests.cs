using NUnit.Framework;
using ConditionStatements1;

namespace ConditionStatementTests
{
    public class Tests
    {
        [TestCase(5, 6)]
        [TestCase(2, 3)]
        [TestCase(-8, -8)]
        [TestCase(-5,-5)]
        public void Task1_ReturnsCorrectNumber(int a, int expected)
        {
            var actual = Tasks.Task1(a);

            Assert.AreEqual(expected, actual, "Task1 returns incorrect value.");
        }
        
        [TestCase(5, 6)]
        [TestCase(2, 3)]
        [TestCase(-8, -10)]
        [TestCase(-5,-7)]
        public void Task2_ReturnsCorrectNumber(int a, int expected)
        {
            var actual = Tasks.Task2(a);

            Assert.AreEqual(expected, actual, "Task2 returns incorrect value.");
        }
        
        [TestCase(5, 6)]
        [TestCase(-1, -3)]
        [TestCase(0, 3)]
        [TestCase(-5,-7)]
        public void Task3_ReturnsCorrectNumber(int a, int expected)
        {
            var actual = Tasks.Task3(a);

            Assert.AreEqual(expected, actual, "Task3 returns incorrect value.");
        }
    }
}

