#region Main method

using Observer;

internal class Program
{
    static void Main()
    {
        var publisher = new Publisher();

        var subA = new SubscriberA();
        publisher.AddSubscriber(subA);

        var subB = new SubscriberB();
        publisher.AddSubscriber(subB);

        var subC = new SubscriberC();
        publisher.AddSubscriber(subC);

        var subD = new SubscriberD();
        publisher.AddSubscriber(subD);

        publisher.UpdatePublisherState();
        publisher.UpdatePublisherState();

        publisher.RemoveSubscriber(subB);

        publisher.UpdatePublisherState();
        publisher.UpdatePublisherState();

        publisher.RemoveSubscriber(subA);

        publisher.UpdatePublisherState();
    }
}

#endregion