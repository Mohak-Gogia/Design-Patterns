namespace Observer
{
    public class SubscriberA : ISubscriber
    {
        public void Update(IPublisher publisher)
        {
            if (publisher is Publisher { State: > 1 and < 4 })
            {
                Console.WriteLine("SubscriberA: Listened to the event.");
            }
        }
    }
}
