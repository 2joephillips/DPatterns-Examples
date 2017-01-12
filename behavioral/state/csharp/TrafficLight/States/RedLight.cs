using System;
using System.Threading;

namespace StateMachineDemo.States
{
    public class RedLight : ITrafficLightState
    {
        public ITrafficLightState Change()
        {
            Console.WriteLine("Red Light - 30 second wait");
            Thread.Sleep(30000);
            return new GreenLight();
        }

    }
}