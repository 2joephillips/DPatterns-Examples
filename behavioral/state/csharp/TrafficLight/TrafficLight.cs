namespace StateMachineDemo
{
    public class TrafficLight
    {   
        public ITrafficLightState State {get;set;}
        public void Change(){
            State.Change(this);
        }

        public void Wait(){
            State.Wait();
        }
        public void ReportState(){
            State.ReportState();
        }
    }
}
