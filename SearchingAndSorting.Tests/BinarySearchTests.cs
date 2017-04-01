using System;
using Xunit;
using SearchingAndSorting;
using System.Collections.Generic;

namespace SearchingAndSorting.Tests
{
    public class BinarySearchTests
    {
        private BinarySearch sut;
        public BinarySearchTests()
        {
            sut = new BinarySearch();
        }

        [Fact]
        public void Should_Return_False_EmptyArray()
        {
            int[] arr = new int[0];
            Assert.False(sut.Search(arr, 5));
        }

        [Fact]
        public void Should_Return_False_NullArray()
        {
            Assert.False(sut.Search(null, 5));
        }


        [Fact]
        public void Should_Return_True_SmallArray_15()
        {
            int[] arr = new int[10] { -10, -2, 0 , 4, 5, 6, 8, 9, 10, 15 };
            Assert.True(sut.Search(arr, 15));
        }

        [Fact]
        public void Should_Return_False_SmallArray_15()
        {
            int[] arr = new int[10] { -10, -2, 0, 4, 5, 6, 8, 9, 10, 18 };
            Assert.False(sut.Search(arr, 15));
        }

        [Fact]
        public void Should_Return_False_SmallArray_21()
        {
            int[] arr = new int[10] { -10, -2, 0, 4, 5, 6, 8, 9, 10, 18 };
            Assert.False(sut.Search(arr, 21));
        }

        [Fact]
        public void Should_Return_True_SmallArray_BigNumber()
        {
            int[] arr = new int[10] { -10, -2, 0, 4, 5, 6, 8, 10, 3000, 12000 };
            Assert.True(sut.Search(arr, 3000));
        }

        [Fact]
        public void Should_Return_True_SmallArray_MinusNumber()
        {
            int[] arr = new int[10] { -10, -2, 0, 4, 5, 6, 8, 10, 3000, 12000 };
            Assert.True(sut.Search(arr, -2));
        }

        [Fact]
        public void Should_Return_True_SmallArray_FirstNumber()
        {
            int[] arr = new int[10] { -10, -2, 0, 4, 5, 6, 8, 10, 3000, 12000 };
            Assert.True(sut.Search(arr, -10));
        }

        [Fact]
        public void Should_Return_True_SmallArray_LastNumber()
        {
            int[] arr = new int[10] { -10, -2, 0, 4, 5, 6, 8, 10, 3000, 5000 };
            Assert.True(sut.Search(arr, 5000));
        }

        [Fact]
        public void Should_Return_True_OneArray()
        {
            int[] arr = new int[1] { -10 };
            Assert.True(sut.Search(arr, -10));
        }

        [Fact]
        public void Should_Return_False_OneArray()
        {
            int[] arr = new int[1] { -10 };
            Assert.False(sut.Search(arr, -15));
        }

        [Fact]
        public void Should_Return_False_BigArrayList()
        {
            var arr = new List<int>();
            for (int i = -100; i <= 10000; i++)
            {
                arr.Add(i);
            }
            Assert.False(sut.Search(arr.ToArray(), -101));
        }

        [Fact]
        public void Should_Return_True_BigArrayList_5000()
        {
            var arr = new List<int>();
            for (int i = -100; i <= 10000; i++)
            {
                arr.Add(i);
            }
            Assert.True(sut.Search(arr.ToArray(), 5000));
        }

        [Fact]
        public void Should_Return_True_BigArrayList_9000()
        {
            var arr = new List<int>();
            for (int i = -100; i <= 10000; i++)
            {
                arr.Add(i);
            }
            Assert.True(sut.Search(arr.ToArray(), 9000));
        }

        [Fact]
        public void Should_Return_False_BigArrayList_100001()
        {
            var arr = new List<int>();
            for (int i = -100; i <= 10000; i++)
            {
                arr.Add(i);
            }
            Assert.False(sut.Search(arr.ToArray(), 100001));
        }
    }
}
