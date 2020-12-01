using System;
using NUnit.Framework;
using System.Linq;
using IdeasApp.Data;
using Microsoft.EntityFrameworkCore;



namespace NUnitTests
{
    public class Tests
    {
        public static DatabaseContext context = new DatabaseContext();

        [SetUp]
        public void Setup()
        {
            Test1();
        }

        [Test]
        public  void Test1()
        {

            //Arrange
            context.Database.EnsureCreated();


            //Act
            var query = context.Ideas.FirstOrDefault(s => s.UserID == "Random");

            //Assert
            Assert.AreEqual("Random", query);
        }
    }
}