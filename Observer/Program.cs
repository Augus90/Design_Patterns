internal class Program
{

     public interface IObserver
    {
        void notification();
    }

    public interface ISubject
    {
        void subscribe(IObserver subscriber);
        void unsubscribe(IObserver subscriber);
        void update();
    }

    public class Subscriber : IObserver
    {
        private string _name {get;set;}

        public Subscriber(string name){
            this._name = name;
        }

        public void notification(){
            Console.WriteLine($"{this._name} is subscriber");
            
        }

    }

    public class Twitch : ISubject
    {
        private List<IObserver> subscribers = new List<IObserver>();
        public void subscribe(IObserver subscriber){
            this.subscribers.Add(subscriber);
        }
        public void unsubscribe(IObserver subscriber){
            this.subscribers.Remove(subscriber);
        }
        public void update(){
            foreach (Subscriber subscriber in subscribers){
                subscriber.notification();
            }
        }
    }

    private static void Main(string[] args)
    {
        Twitch twitch = new Twitch();

        Subscriber subscriber1 = new Subscriber("Alice");
        Subscriber subscriber2 = new Subscriber("Bob");

        twitch.subscribe(subscriber1);
        twitch.subscribe(subscriber2);

        twitch.update();

        twitch.unsubscribe(subscriber2);

        twitch.update();


    }
}