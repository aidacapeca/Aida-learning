using System;
using System.Collections.Generic;

namespace Gradebook
{

    //al invocar () metodo , no() property
    class Program
    {
        // Metodo
        static void Main(string[] args)
        {
            var book = new Book(args[0] + "'s gradebook");
            var quit = false;
            var selection = false;
            do
            {
                System.Console.WriteLine("Enter F to save the grades and statistics into a file.txt");
                System.Console.WriteLine("Enter C to only have the grades in the console or enter Q to Quit");
                var inputOption = Console.ReadLine();
                switch (inputOption)
                {
                    case "F":
                        System.Console.WriteLine("File");
                        selection = true;
                        break;
                    case "C":
                        System.Console.WriteLine("Memory");
                        selection = true;
                        break;
                    case "Q":
                        quit = true;
                        break;
                    default:
                        System.Console.WriteLine("Not an available option");
                        break;
                }
            } while (!quit && !selection);

            quit = false;
            do
            {
                System.Console.WriteLine("Enter a grade or enter q to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    quit = true;
                    break;
                }
                try
                {
                    var grade = double.Parse(input);

                    //book.AddGrade(grade);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    throw; // Me ayuda a 1. terminar el programa 2. obligar a alguien mas a atrapar la excepcion y hacer algo
                }
            } while (!quit);
            /*   
       //ComputeAverageGrade(grades); 
       book.ShowGradesList();
           //book.ComputeStatistics(grades);
           book.FinalStatistics();
*/

        }
    }
}
