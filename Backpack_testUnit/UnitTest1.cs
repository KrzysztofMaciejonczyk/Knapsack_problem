using LAB1;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Backpack_testUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodIfAtLeastOneElementCorrect()
        {
            int number = 10;
            int capacity = 5;
            List<int> seeds = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int seed in seeds)
            {
                Backpack backpack = new Backpack(number, seed);
                Result result = backpack.Solve(capacity);
                foreach (Item item in backpack._listOfItems)
                {
                    if (item.GetWeight() <= capacity)
                    {
                        Assert.AreNotEqual(result.GetNumberOfItems().Count, 0);
                        break;
                    }
                }
            }
        }
        [TestMethod]
        public void TestMethodIfNoElementCorrect()
        {
            int number = 10;
            int capacity = 0;
            List<int> seeds = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int seed in seeds)
            {
                Backpack backpack = new Backpack(number, seed);
                Result result = backpack.Solve(capacity);
                Assert.AreEqual(result.GetNumberOfItems().Count, 0);
            }
        }
        [TestMethod] // Better algorithm with also checking less weight even if proportion is the same
        public void TestMethodDifferentOrder()
        {
            int number = 10;
            int capacity = 25;
            List<int> seeds = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int seed in seeds)
            {
                Backpack backpack = new Backpack(number, seed);
                Backpack backpack2 = new Backpack(number, seed);
                Array.Reverse(backpack2._listOfItems);
                Result result1 = backpack.Solve(capacity);
                Result result2 = backpack2.Solve(capacity);
                Assert.AreEqual(result1.getTotalValue(), result2.getTotalValue());
                Assert.AreEqual(result1.getTotalWeight(), result2.getTotalWeight());
            }
        }
        [TestMethod]
        public void TestMethodSpecificExample()
        {
            int number = 10;
            int capacity = 15;
            Backpack backpack = new Backpack(number);
            List<int> weights = new List<int>() { 4, 8, 2, 8, 10, 7, 2, 1, 3, 9 };
            List<int> values = new List<int>() { 4, 2, 5, 5, 10, 1, 2, 9, 6, 10 };
            List<int> correctSetOfItems = new List<int>() { 7, 2, 8, 9 };
            int correctTotalWeight = 15;
            int correctTotalValue = 30;
            for (int i = 0; i < number; i++)
            {
                backpack._listOfItems[i] = new Item();
                backpack._listOfItems[i].SetWeight(weights[i]);
                backpack._listOfItems[i].SetValue(values[i]);
                backpack._listOfItems[i].SetIndex(i);
            }
            Result result = backpack.Solve(capacity);
            Assert.AreEqual(result.GetNumberOfItems().Count, correctSetOfItems.Count);
            for (int j = 0; j < correctSetOfItems.Count; j++)
            {
                Assert.AreEqual(result.GetNumberOfItems()[j], correctSetOfItems[j]);
            }
            Assert.AreEqual(result.getTotalWeight(), correctTotalWeight);
            Assert.AreEqual(result.getTotalValue(), correctTotalValue);
        }
        [TestMethod]
        public void TestMethodNoItemsPresented()
        {
            int number = 0;
            int capacity = 25;
            List<int> seeds = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int seed in seeds)
            {
                Backpack backpack = new Backpack(number, seed);
                Result result = backpack.Solve(capacity);
                Assert.AreEqual(result.getTotalValue(), 0);
            }
        }
        [TestMethod]
        public void TestMethodCapacityGreaterThanWeight()
        {
            int number = 10;
            int capacity = 150;
            Backpack backpack = new Backpack(number);
            List<int> weights = new List<int>() { 4, 8, 2, 8, 10, 7, 2, 1, 3, 9 };
            List<int> values = new List<int>() { 4, 2, 5, 5, 10, 1, 2, 9, 6, 10 };
            List<int> correctSetOfItems = new List<int>() { 7, 2, 8, 9, 6, 0, 4, 3, 1, 5 };
            for (int i = 0; i < number; i++)
            {
                backpack._listOfItems[i] = new Item();
                backpack._listOfItems[i].SetWeight(weights[i]);
                backpack._listOfItems[i].SetValue(values[i]);
                backpack._listOfItems[i].SetIndex(i);
            }
            Result result = backpack.Solve(capacity);
            backpack.DisplayList();
            string text = result.ToString();
            Console.WriteLine(text);
            for (int j = 0; j < correctSetOfItems.Count; j++)
            {
                Assert.AreEqual(result.GetNumberOfItems()[j], correctSetOfItems[j]);
            }
        }
        [TestMethod]
        public void TestMethodAllItemsFitCapacity()
        {
            int number = 10;
            int capacity = 150;
            Backpack backpack = new Backpack(number);
            List<int> weights = new List<int>() { 4, 8, 2, 8, 10, 5, 2, 1, 3, 9 };
            List<int> values = new List<int>() { 4, 2, 5, 5, 10, 1, 2, 9, 6, 10 };
            List<int> correctSetOfItems = new List<int>() { 7, 2, 8, 9, 6, 0, 4, 3, 1, 5 };
            for (int i = 0; i < number; i++)
            {
                backpack._listOfItems[i] = new Item();
                backpack._listOfItems[i].SetWeight(weights[i]);
                backpack._listOfItems[i].SetValue(values[i]);
                backpack._listOfItems[i].SetIndex(i);
            }
            Result result = backpack.Solve(capacity);
            backpack.DisplayList();
            string text = result.ToString();
            Console.WriteLine(text);
            for (int j = 0; j < correctSetOfItems.Count; j++)
            {
                Assert.AreEqual(result.GetNumberOfItems()[j], correctSetOfItems[j]);
            }
        }
        [TestMethod]
        public void TestMethodCapacityIsNegative()
        {
            int number = 10;
            int capacity = -20;
            Backpack backpack = new Backpack(number);
            List<int> weights = new List<int>() { 4, 8, 2, 8, 10, 5, 2, 1, 3, 9 };
            List<int> values = new List<int>() { 4, 2, 5, 5, 10, 1, 2, 9, 6, 10 };
            List<int> correctSetOfItems = new List<int>() { 7, 2, 8, 9, 6, 0, 4, 3, 1, 5 };
            for (int i = 0; i < number; i++)
            {
                backpack._listOfItems[i] = new Item();
                backpack._listOfItems[i].SetWeight(weights[i]);
                backpack._listOfItems[i].SetValue(values[i]);
                backpack._listOfItems[i].SetIndex(i);
            }
            Result result = new Result();
            try
            {
                result = backpack.Solve(capacity);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}