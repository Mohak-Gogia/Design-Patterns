namespace Observer
{
    public class SubscriberD : ISubscriber
    {
        public void Update(IPublisher publisher)
        {
            Console.WriteLine("SubscriberD: Listened to the event.");
        }
    }
}
