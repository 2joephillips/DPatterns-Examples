using System;
using System.Threading;

namespace StateMachineDemo.States
{
    public class YellowLight : ITrafficLightState
    {
        void ITrafficLightState.Change(TrafficLight light)
        {
            light.State = new GreenLight();
        }
        void ITrafficLightState.Wait(){
            Thread.Sleep(10000);
        }
        void ITrafficLightState.ReportState()
        {
            Console.WriteLine("Yellow Light - 10 second wait");
        }

    }
}