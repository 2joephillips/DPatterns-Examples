using System;
using StateMachineDemo.States;

namespace StateMachineDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TrafficLight light = new TrafficLight();
            light.State = new RedLight();

            for(int count = 0; count < 9; count++){
                
                light.ReportState();
                light.Wait();
                light.Change();
            }

            Console.ReadLine();
        }
    }
}
