using System;
using System.Collections.Generic;

namespace Gradebook{

    public class Book{
       
        List<double> grades; // field no puedo usar implicit type , en C# prederminado sera private 
        private string name;
        
        
        public Book(string name){
            this.grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade){
            if (grade<=100 && grade>0){
                grades.Add(grade);
            }else{
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
            
        }
        
        public void AddMultipleGrades(List<double> gradesList){
            foreach(double grade in gradesList){
                this.AddGrade(grade);
            }
        }

       /* public List<double> GetGradesList(){
            return grades;
        }*/

        
        public void ShowGradesList(){
            System.Console.WriteLine("Grades registered: ");
            foreach(double grade in this.grades){
                System.Console.WriteLine($"* {grade}");
            }
        }

        public Statistics ComputeStatistics(){
            var results = new Statistics();
            results.average = results.ComputeAverage(this.grades);
            results.highGrade = results.GetHighestGrade(this.grades);
            results.lowGrade = results.GetLowestGrade(this.grades);
            return results;
        }

        public void FinalStatistics(){
            var results = new Statistics();
            results = ComputeStatistics();
            System.Console.WriteLine($"The final average is: {results.average:N1} "); //FORMATEO
            System.Console.WriteLine($"The highest grade registered is: {results.highGrade:N1}");
            System.Console.WriteLine($"The lowest grade registered is: {results.lowGrade:N1}");
        }

    }
}