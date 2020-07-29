using System;
using System.Collections.Generic;

namespace Gradebook
{
    public class Statistics
    {
        public double average;
        public double highGrade;
        public double lowGrade;

        public Statistics(){
            this.average = 0.0;
            this.highGrade = double.MinValue;
            this.lowGrade = double.MaxValue;
        }
        public Statistics(double average, double high, double low){
            this.average = average;
            this.highGrade = high;
            this.lowGrade = low;
        }

        public double ComputeAverage(List<double> grades){
            var averageResult = 0.0;
            foreach (double grade in grades){
                averageResult += grade;
            }
             averageResult /= grades.Count;
             return averageResult;
        }
         public double GetHighestGrade(List<double> grades){
            var highest = double.MinValue;
            foreach (double grade in grades){
                if (grade > highest){
                    highest = grade;
                }
            }
            return highest;
         }
         public double GetLowestGrade(List<double> grades){
            var lowest = double.MaxValue;
         foreach(double grade in grades){
               lowest = Math.Min(grade, lowest);
            }
            return lowest;
         }
    }
}