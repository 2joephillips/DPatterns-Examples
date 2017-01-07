using System;
using System.Threading;

namespace StateMachineDemo.States
{
    public class GreenLight : ITrafficLightState
    {
        void ITrafficLightState.Change(TrafficLight light)
        {
            light.State = new RedLight();
        }
        void ITrafficLightState.Wait(){
                Thread.Sleep(30000);
        }
        void ITrafficLightState.ReportState()
        {
            Console.WriteLine("Green Light - 30 second wait");
        }

    }
}