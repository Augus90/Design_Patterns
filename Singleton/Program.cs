internal class Program
{
    public class Singleton
    {

        static Singleton instance;
        private int count { get; set; }

        private Singleton()
        { }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        public int getCount()
        {
            return this.count;
        }

        public void increaseCount(int times = 1)
        {
            this.count = this.count + times;
        }
        public void decreaseCount(int times = 1)
        {
            this.count = this.count - times;
        }
    }
    public static void exampleFunction()
    {
        var myObject = Singleton.getInstance();

        myObject.increaseCount();

        Console.WriteLine($"Count is {myObject.getCount()}");
    }

    private static void Main(string[] args)
    {

        exampleFunction();

        var myNewObject = Singleton.getInstance();

        myNewObject.increaseCount();

        Console.WriteLine($"My new object Count is {myNewObject.getCount()}");

    }
}