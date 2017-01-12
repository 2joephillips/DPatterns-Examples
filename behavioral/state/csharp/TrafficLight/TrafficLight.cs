using StateMachineDemo.States;

namespace StateMachineDemo
{
    public class TrafficLight :ITrafficLight
    {   
         private ITrafficLightState _state;
        public bool Running { get; private set; }
 
        public TrafficLight()
        {
            _state = new RedLight();
        }
 
        public void Activate()
        {
            Running = true;
        }
 
        public void Deactivate()
        {
            Running = false;
        }
 
        public void Update()
        {
            _state = _state.Change();
        }
    }
}
