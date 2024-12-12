namespace Assignment6_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment6.3");
            Console.WriteLine("=============\n");

            Queue<Call> queue = new Queue<Call>();
            //queue.Enqueue(new Call { Id = 1, Number = "123-456-7890", Date = DateTime.Now });
            queue.Enqueue(new Call());
            queue.Dequeue();

        }
        public class Call
        {
            public int Id { get; set; }
            public string Number { get; set; }
            public DateTime Date { get; set; }
        }
    }
}
