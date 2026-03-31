using System.Data;
using NUnit.Framework;

namespace BinarySearch.UnitTests;

public class BinarySearchTests
{
    int[] sortedNumbers;
    int numberToFind;

    BinarySearch sorted;


    [SetUp]
    public void Setup()
    {
        //Arrange common
        sortedNumbers = new int[] { 2, 5, 8, 15, 54, 55, 67 };
        numberToFind = 54;

        sorted = new BinarySearch();
    }


    [Test]
    public void Search_NumberFoundInArray_ReturnTrue()
    {
        //Act
        bool result = sorted.Search(sortedNumbers, numberToFind);

        //Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Search_NumberNotFoundInArray_ReturnTrue()
    {
        //Arrange differences
        numberToFind = 17;

        //Act
        bool result = sorted.Search(sortedNumbers, numberToFind);

        //Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Search_SingleElementArrayNumberFound_ReturnTrue()
    {
        //Arrange differences
        sortedNumbers = new int[] { 5 };
        numberToFind = 5;

        //Act
        bool result = sorted.Search(sortedNumbers, numberToFind);

        //Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Search_SingleElementArrayNumberNotFound_ReturnFalse()
    {
        //Arrange differences
        sortedNumbers = new int[] { 98 };
        numberToFind = 25;

        //Act
        bool result = sorted.Search(sortedNumbers, numberToFind); ;

        //Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Search_EmptyArray_ReturnFalse()
    {
        //Arrange differences
        sortedNumbers = new int[] { };
        numberToFind = 8;

        //Act
        bool result = sorted.Search(sortedNumbers, numberToFind);

        //Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Search_EndArrayInt_ReturnTrue()
    {
        //Arrange differences
        numberToFind = 67;

        //Act
        bool result = sorted.Search(sortedNumbers, numberToFind);

        //Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Search_BeginningArrayInt_ReturnTrue()
    {
        //Arrange differences
        numberToFind = 2;

        //Act
        bool result = sorted.Search(sortedNumbers, numberToFind);

        //Assert
        Assert.IsTrue(result);
    }
}