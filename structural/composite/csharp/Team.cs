using System;
using System.Collections.Generic;

namespace CompositeDemo
{
    public class Team : IEmployee
    {
        public int ID {get;set;}
        public string Name {get; set;}
        public Employee Supervisor {get;set;}
        public List<IEmployee> Workers {get;}

        public Team()
        {
            Name = Name;
            Supervisor = new Employee();
            Workers = new List<IEmployee>();
        }

        public void PerformaceSummary(){
            Console.WriteLine("Team: " + Name);
            Console.WriteLine("Supervisor: " + Supervisor.Name);
            Console.WriteLine("Members Reviews");
            foreach (var worker in Workers)
            {
                worker.PerformaceSummary();
            }
        }
    }
}