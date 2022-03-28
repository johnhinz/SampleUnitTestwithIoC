using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProgramTest;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //[ExpectedException(typeof(ArgumentNullException))]
        public void Test_With_Name()
        {
            // Arrange
            Mock<ISave> save = new Mock<ISave>();
            Person person = new Person(save.Object);
            person.Name = "Joe Smith";

            // Act
            try
            {
                person.Save();
                //Assert
                Assert.IsTrue(true);
            }
            catch (ArgumentNullException ex)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Test_Without_Name()
        {
            // Arrange
            Mock<ISave> save = new Mock<ISave>();
            Person person = new Person(save.Object);
            
            // Act
            try
            {
                person.Save();
                //Assert
                Assert.Fail();
            }
            catch (ArgumentNullException ex)
            {
                Assert.IsTrue(true);
            }
        }
    }
}