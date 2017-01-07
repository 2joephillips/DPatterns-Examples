namespace StateMachineDemo{
    public interface ITrafficLightState{
        void Change(TrafficLight light);
        void Wait();
        void ReportState();
    }
}