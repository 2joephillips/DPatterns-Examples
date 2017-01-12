using System;
using System.Threading;

namespace StateMachineDemo.States
{
    public class GreenLight : ITrafficLightState
    {
        public ITrafficLightState Change()
        {
            Console.WriteLine("Green Light - 30 second wait");
            Thread.Sleep(30000);
            return new YellowLight();
        }
    }
}