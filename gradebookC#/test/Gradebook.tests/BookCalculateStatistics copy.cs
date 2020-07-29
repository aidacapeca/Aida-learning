using System;
using System.Collections.Generic;
using Xunit;

namespace Gradebook.tests
{
    public class TypeTests
    {
        [Fact] //atribute attach to Test1()
        public void Test1()
        {
            /*
            Un test se divide en 3 partes principales: 
            *   arrange section: test data setting , instancia y declaracion de todas las 
                variables. 
            *   act section: invoke the necesary methods to compute something and produce a result
            *   assert section: does the compare to execute the test. 
            */
            var grades = new List<double>{11.1, 10.6, 33.5};

            var book = new Book("");
            var resultsToTest = new Statistics();
            var resultsToCompare = new Statistics(18.4, 33.5, 10.6);
            /*  En este caso se genera un error porque no reconoce la clase Book, para corregir esto 
            *   debemos importar como un package la clase mediante el .NET cli (terminal) haciendo 
            *   dotnet add 1. add reference to package (como xunit) 2. add project reference
            *   dot net add reference path (src/Project/Project.csproj)  
            *   
            */
            

            //act 
            resultsToTest = book.ComputeStatistics(grades);
            
            //assert
            /*  Entre los metodos de Assert tenemos: 
            *   .Equal: evalua que los objetos comparados sean totalmente iguales en valor.
            *   .Same / .NotSame: evalua la direccion en memoria a la que estan apuntando los objetos 
            */
        
            Assert.Equal(resultsToTest.average, resultsToCompare.average, 1);
            Assert.Equal(resultsToTest.highGrade, resultsToCompare.highGrade, 1);
            Assert.Equal(resultsToTest.lowGrade, resultsToCompare.lowGrade, 1);

        }
    }
}
