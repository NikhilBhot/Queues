namespace QueueImplemetation
{
    /*
     * Ability to create a Queue of 56->30->70
       - Use LinkedList to do the Queue Operations
       - Here enqueu will internally call append method on LinkedList.
       - So 56 will be added first then 30 and then 70 to make 56 on top of the Stack
     */

    /*Ability to dequeue from the beginning
      -Use LinkedList to do the Queue Operations
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            Console.WriteLine("Front element of the queue: " + queue.Peek());

            Console.WriteLine("Elements in the queue:");
            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}