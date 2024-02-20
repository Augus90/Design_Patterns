internal class Program
{
    public abstract class Task
    {
        protected string _title { get; set; }

        public void setTitle(string title)
        {
            this._title = title;
        }

        public string getTitle() { return this._title; }

        public abstract void print();
    }

    public class SimpleTask : Task
    {
        private string _body { set; get; }

        public SimpleTask(string title, string body)
        {
            this._title = title;
            this._body = body;
        }
        public void setBody(string body)
        {
            this._body = body;
        }
        public string getBody() { return this._body; }

        public override void print()
        {
            Console.Write($" .  ");
            Console.WriteLine($"Title: {this._title}, Body: {this._body}");
        }

    }

    public class TaskList : Task
    {
        private List<Task> _list = new List<Task>();

        public void addTask(Task task)
        {
            this._list.Add(task);
        }

        public bool removeTask(Task task)
        {
            return this._list.Remove(task);
        }

        public override void print()
        {
            Console.WriteLine($"--- List {this._title}");

            foreach (Task task in _list)
            {

                task.print();
            }

        }

    }

    private static void Main(string[] args)
    {
        Task task1 = new SimpleTask("Make my Lunch", "Make my lunch");
        Task task2 = new SimpleTask("Lunch", "Eat my lunch");
        Task task3 = new SimpleTask("Work", "Do some work");
        Task task4 = new SimpleTask("Pet", "Pet the Cat");

        TaskList list = new TaskList();
        list.setTitle("Lunch");
        list.addTask(task1);
        list.addTask(task2);

        Console.WriteLine($"- Task:");
        task3.print();
        Console.WriteLine($"- Task:");
        task4.print();
        list.print();
    }
}