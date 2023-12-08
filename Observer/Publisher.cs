namespace Observer
{
    public class Publisher : IPublisher
    {
        private List<ISubscriber> _subscibers { get; set; } = new();

        public int State { get; set; } = 0;

        public void AddSubscriber(ISubscriber subscriber)
        {
            _subscibers.Add(subscriber);
            Console.WriteLine("Successfully Subscribed!");
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            _subscibers.Remove(subscriber);
            Console.WriteLine("Successfully Unsubscribed!");
        }

        public void NotifySubscribers()
        {
            Console.WriteLine("Notifying Subscribers !!!");
            
            foreach (var s in _subscibers)
            {
                s.Update(this);
            }
        }

        public void UpdatePublisherState()
        {
            Console.WriteLine("\nPublisher: I'm doing something important.");
            State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Publisher: My state has just changed to: " + State);
            NotifySubscribers();
        }
    }
}
