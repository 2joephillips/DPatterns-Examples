using System;
using System.Threading;

namespace StateMachineDemo.States
{
    public class RedLight : ITrafficLightState
    {
        void ITrafficLightState.Change(TrafficLight light)
        {
            light.State = new YellowLight();
        }
        void ITrafficLightState.Wait(){
            Thread.Sleep(30000);
        }
        void ITrafficLightState.ReportState()
        {
            Console.WriteLine("Red Light - 30 second wait");
        }

    }
}