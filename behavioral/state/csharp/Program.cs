using System;
using StateMachineDemo.States;

namespace StateMachineDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TrafficLight light = new TrafficLight();
            light.Activate();

            Console.WriteLine("Press ESC to stop");
            do
            {
                while (!Console.KeyAvailable)
                {
                    while (light.Running)
                    {
                        light.Update();
                    }
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
 
            light.Deactivate();
 
            Console.ReadLine();
        }
    }
}
