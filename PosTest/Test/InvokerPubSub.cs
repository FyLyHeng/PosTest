using IGPOS.Data.PubSub;

namespace PosTest.Test
{
    public class InvokerPubSub
    {
        private readonly IPublisher<int> IntPublisher;
        private readonly Subscriber<int> IntSublisher1;


        public InvokerPubSub()
        {
            IntPublisher = new Publisher<int>();//create publisher of type integer  
            //IntPublisher.PublishData(10); // publisher publish message  




            //event method to listen publish data 
            IntSublisher1 = new Subscriber<int>(IntPublisher);
            IntSublisher1.Publisher.DataPublisher += (sender, e) =>
            {
                Console.WriteLine("Subscriber 1 : " + e.Message);
            };
        }
        
        
        public bool CanConstruct(string ransomNote , string magazine) {
            for (int i = 0; i < ransomNote.Length; i++ )
            {

                char r = ransomNote[i];
                int matchingIndex = magazine.IndexOf(r);
                if (matchingIndex == -1)
                {
                    return false;
                }
                
                Console.WriteLine($"{magazine}");
                
                Console.WriteLine($"{magazine.Substring(0,i)} :: {magazine.Substring(i+1)}");
                
                magazine = magazine.Substring(0, i) + magazine.Substring(i + 1);
                
                Console.WriteLine($"{magazine}");
                
                Console.WriteLine("---------------");
                
            }
            return true;
        }
    }
}
