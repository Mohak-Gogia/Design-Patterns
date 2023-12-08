namespace Observer
{
    public class SubscriberC : ISubscriber
    {
        public void Update(IPublisher publisher)
        {
            if (publisher is Publisher { State: > 7 and < 10 })
            {
                Console.WriteLine("SubscriberC: Listened to the event.");
            }
        }
    }
}
