using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace testing_lab_2.Tests {
    [TestClass]
    public class TestOfSorting {
        [TestMethod]
        public void TestOfEmptyArray() {
            List<int> array = new List<int>();
            List<int> expected = new List<int>();
            List<int> actual = Sort.SortByChoice(array);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestOfArrayFromOneEl() {
            List<int> array = new List<int>() { 1 };
            List<int> expected = new List<int>() { 1 };
            List<int> actual = Sort.SortByChoice(array);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestOfEvenArray() {
            List<int> array = new List<int>() { 7, 4, 1, 6, 8, 2 };
            List<int> expected = new List<int>() { 1, 2, 4, 6, 7, 8 };
            List<int> actual = Sort.SortByChoice(array);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestOfOddArray() {
            List<int> array = new List<int>() { 7, 4, 1, 6, 8, 2, 5 };
            List<int> expected = new List<int>() { 1, 2, 4, 5, 6, 7, 8 };
            List<int> actual = Sort.SortByChoice(array);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestOfSortedArray() {
            List<int> array = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5 };
            List<int> actual = Sort.SortByChoice(array);
            CollectionAssert.AreEqual(expected, actual);
        }


        //-------------------------------------------------------------------------------------
        //тестирование белого ящика 



       
        [TestMethod]
        //пустой массив
        public void TestofArea_1() {
            List<int> array = new List<int>();
            List<int> expected = new List<int>();
            List<int> actual = Sort.SortByChoice(array);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        //массив из 1 элемента
        public void TestofArea_2() {
            List<int> array = new List<int>() { 1 };
            List<int> expected = new List<int>() { 1 };
            List<int> actual = Sort.SortByChoice(array);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        // отсортированный массив
        public void TestofArea_3() {
            List<int> array = new List<int> { 1, 2, 3 };
            List<int> expected = new List<int> { 1, 2, 3 };
            List<int> actual = Sort.SortByChoice(array);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        // неотсортированный массив
        public void TestofArea_4() {
            List<int> array = new List<int>() { 7, 4, 1, 6, 8, 2, 5 };
            List<int> expected = new List<int>() { 1, 2, 4, 5, 6, 7, 8 };
            List<int> actual = Sort.SortByChoice(array);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

}
