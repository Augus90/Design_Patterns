using System;


internal class Program
{
    class Facade
    {
        Logger logger;
        Connection connection;
        public void logAndSave()
        {
            connection = new Connection();
            logger = new Logger();

            connection.makeConnection("root", "1234", "3607");
            // Date today = Date.Today;
            DateTime date1 = new DateTime(2024, 2, 4, 7, 47, 0);
            DateTime dateOnly = date1.Date;
            string onlyDate = dateOnly.ToString("g");


            // System.DateTime _Now = DateAndTime.Now;


            logger.getTrigger($"--- Log: {onlyDate}");

            connection.addToDatabase(logger.saveLog());
            connection.save();

        }
    }

    class Logger
    {
        public string log;
        public void getTrigger(string trigger)
        {
            this.log = trigger;
        }

        public string saveLog()
        {
            return this.log;
        }
    }

    class Database
    {
        string user;
        string password;
        string port;

        public List<string> dataList = new List<string>();
        public void connect(string user, string password, string port)
        {
            this.user = user;
            this.password = password;
            this.port = port;
        }

        public void add(string data)
        {
            dataList.Add(data);
        }

        public void save()
        {

            Console.WriteLine($"Database: ");

            this.dataList.ForEach(delegate (string item)
            {
                Console.WriteLine($"Item: {item}");
            });

        }

    }

    class Connection
    {
        public Database database;

        public void makeConnection(string user, string password, string port)
        {
            database = new Database();
            database.connect(user, password, port);
        }

        public void addToDatabase(string log)
        {
            // add to database
            database.add(log);
        }

        public void save()
        {
            // save to database
            database.save();
        }
    }


    private static void Main(string[] args)
    {
        var facade = new Facade();

        facade.logAndSave();
    }
}