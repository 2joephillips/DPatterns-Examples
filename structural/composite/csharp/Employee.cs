
using System;

namespace CompositeDemo
{
    public class Employee : IEmployee
    {
        public int ID {get;set;}
        public string Name {get; set;}
        public int Rating{get;set;}
        public void PerformaceSummary(){
            Console.WriteLine("Performance summary of employee: {0} is {1} out 0f 5", Name, Rating);
        }
    }
}