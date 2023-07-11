namespace Gang_Of_Four_Eight_Design_Patterns.Behavioral_Design_Patterns.Observer_Design_Pattern
{
    public class Publisher
    {
        private string _name;
        public List<Subscriber> _subscribers;
        public Publisher(string name)
        {
            _name = name;
            _subscribers = new List<Subscriber>();
        }
        public void Subscribe(Subscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }
        public void Notify(string eventName)
        {
            foreach (Subscriber subscriber in _subscribers)
            {
                subscriber.Observe(_name, eventName);
            }
        }
    }
}
