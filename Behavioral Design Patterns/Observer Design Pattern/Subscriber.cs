namespace Gang_Of_Four_Eight_Design_Patterns.Behavioral_Design_Patterns.Observer_Design_Pattern
{
    public interface ISubscriber
    {
        void Observe(string channel, string eventName);
    }
    public class Subscriber : ISubscriber
    {
        private string _name;
        public Subscriber(){ }
        public Subscriber(string name)
        {
            _name = name;
        }
        public void Observe(string channel, string eventName)
        {
            Console.WriteLine("Subscriber " + _name + " received " + eventName + " from channel: " + channel);
        }
    }
}
