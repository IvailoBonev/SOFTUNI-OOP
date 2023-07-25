namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        private Database database;

        [SetUp]
        public void SetUp()
        {
            database = new(1, 2);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5})]
        [TestCase(new int[] { 1, 10, 15, 201, 3 })]
        public void TestIfConstructorWorksProperly(int[] expectedArray)
        {
            Database db = new(expectedArray);

            int[] currentArray = db.Fetch();

            Assert.AreEqual(expectedArray, currentArray);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 22 })]
        public void CreatingDatabaseShouldThrowExceptionWhenCountIsMoreThan16(int[] data)
        {
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(()
                => database = new Database(data));

            Assert.AreEqual("Array's capacity must be exactly 16 integers!", ex.Message);
        }

        [Test]
        public void DatabaseCountShouldWorkCorrecly()
        {
            int expectedResult = 2;
            int actualResult = database.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(-8)]
        [TestCase(23)]
        public void DatabaseAddMethodShouldIncreaseCount(int number)
        {
            int expectedResult = 3;

            database.Add(number);

            Assert.AreEqual(expectedResult, database.Count);
        }

        [TestCase(new int[] { 30, 15, 25, 34, 15 })]
        [TestCase(new int[] { 5 , 14, -20, -34, 1 })]
        public void DatabaseAddMethodShouldAddElementsCorrectly(int[] data)
        {
            database = new Database();

            foreach (var number in data)
            {
                database.Add(number);
            }

            int[] actualResult = database.Fetch();


            Assert.AreEqual(data, actualResult);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void ArrayShouldThrowExceptionWhenElementsGet17Count(int[] arrayForException)
        {
            Database db = new(arrayForException);

            Assert.Throws<InvalidOperationException>(()
                => db.Add(17), "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void DatabaseRemoveMethodShouldDecreaseCount()
        {
            int expectedResult = 1;
            database.Remove();

            Assert.AreEqual(expectedResult, database.Count);
        }

        [Test]
        public void DatabaseRemoveMethodShouldRemoveElements()
        {
            int[] expectedArray = new[] { 1 };

            database.Remove();

            int[] actualArray = database.Fetch();

            Assert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void DatabaseRemoveMethodShouldThrowExceptionIfDatabaseIsEmpty()
        {
            Database database = new();

            Assert.Throws<InvalidOperationException>(()
                => database.Remove(), "The collection is empty!");
        }
    }
}
