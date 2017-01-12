using System;
using System.Threading;

namespace StateMachineDemo.States
{
    public class YellowLight : ITrafficLightState
    {
        public ITrafficLightState Change()
        {
            Console.WriteLine("Yellow Light - 10 second wait");
            Thread.Sleep(10000);
            return new RedLight();
        }
    }
}