using System;
using System.Collections.Generic;
using Xunit;

namespace Gradebook.tests
{
    public class BookTests
    {
        [Fact] //atribute attach to Test1()
        public void BookCalculateStatistics()
        {
           
            var grades = new List<double>{11.1, 10.6, 33.5};

            var book = new Book("");
            var resultsToTest = new Statistics();
            var resultsToCompare = new Statistics(18.4, 33.5, 10.6);

            
            book.AddGrade(25.5);
            //act 
            resultsToTest = book.ComputeStatistics();
            
            //assert
            Assert.Equal(resultsToTest.average, resultsToCompare.average, 1);
            Assert.Equal(resultsToTest.highGrade, resultsToCompare.highGrade, 1);
            Assert.Equal(resultsToTest.lowGrade, resultsToCompare.lowGrade, 1);

        }
    }
}
