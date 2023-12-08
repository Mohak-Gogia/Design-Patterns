namespace Observer
{
    public class SubscriberB : ISubscriber
    {
        public void Update(IPublisher publisher)
        {
            if (publisher is Publisher { State: > 4 and < 7 })
            {
                Console.WriteLine("SubscriberB: Listened to the event.");
            }
        }
    }
}
