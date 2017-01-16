using System;

namespace CompositeDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Build Employees 
            Employee jason = new Employee { ID = 1, Name = "Jason Lee Scott", Rating = 3 };
            Employee trini = new Employee { ID = 2, Name = "Trini Kwan", Rating = 4 };
            Employee zach = new Employee { ID = 3, Name = "Zach Taylor", Rating = 5 };
            Employee kimberly = new Employee { ID = 4, Name = "Kimberly Ann Hart", Rating = 3 };
            Employee billy = new Employee { ID = 5, Name = "Billy Cranston", Rating = 4 };
            Employee rose = new Employee { ID = 6, Name = "Tommy Oliver", Rating = 5 };
            
            Employee alpha = new Employee { ID = 7, Name="Alpha 5", Rating = 4};
            Employee zordon = new Employee {ID = 8, Name="Zordon", Rating = 5};
            Team team1 = new Team { Name= "Team 1", Supervisor = alpha, Workers = {jason, trini, zach, kimberly, billy, rose}};

            Team powerTeam = new Team { Name="PowerTeam", Supervisor = zordon, Workers = {alpha, team1}};

            powerTeam.PerformaceSummary();
        }
    }
}
