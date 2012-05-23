using MvcApplication5.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace MvcApplication5.Tests
{
    
    
    /// <summary>
    ///This is a test class for CalculatorTest and is intended
    ///to contain all CalculatorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CalculatorTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            Console.WriteLine("Class cleanup run");
        }
        
        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            Console.WriteLine("My TestInitialize");
        }
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AddNumbers
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void AddNumbersTest()
        {
            
            //Assign
            Calculator target = new Calculator();
            int a = 2; 
            int b = 2; 
            int expected = 4;
            int actual;
            
            //Act
            //setup of shared methods or variables
            actual = target.AddNumbers(a, b);
            
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(true);

        }


        [TestMethod()]
        public void MultiplicationNumberTest()
        {

            //Assign
            Calculator target = new Calculator();
            int a = 2;
            int b = 3;
            int expected = 6;
            int actual;

            //Act
            //setup of shared methods or variables
            actual = target.MultiplyNumbers(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(true);

        }


        [TestMethod()]
        public void GetNotesTest()
        {

            //Assign
            Calculator target = new Calculator();
            int param1 = 0;
            //Act
            //setup of shared methods or variables
            var result = target.GetNotes(param1);

            //Assert
            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result[0].Name == "test1");

        }







    }
}
