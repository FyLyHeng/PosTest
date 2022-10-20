using IGPOS.Data.PubSub;

namespace PosTest.Test
{
    public class EventSubscriber
    {

        public EventSubscriber()
        {
            var thrower = new EventThrower();
            thrower.ThrowEvent += (sender, args) => { Subscriber(); };
        }

        private void Subscriber()
        {
            Console.WriteLine("// Handle event .....");
        }
    }
    
    
    public class Subscriber<T>  
    {  
        public IPublisher<T> Publisher { get; private set; }  
        public Subscriber(IPublisher<T> publisher)  
        {  
            Publisher = publisher;  
            Console.WriteLine("this sub is invoke by Pub "+publisher);
        }  
    } 
    
    
}
