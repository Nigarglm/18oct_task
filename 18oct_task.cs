namespace task_18oct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt listInt = new ListInt(6);
            listInt[5] = 30;
            Console.WriteLine(listInt[5]);

            listInt.Add(5);
            listInt.AddRange(5,10,15);
            Console.WriteLine(listInt);
            Console.WriteLine(listInt.ToString());
            Console.WriteLine(listInt.Sum());
            Console.WriteLine(listInt.Contains(10));
            listInt.Remove(5);
            Console.WriteLine(listInt.ToString());
            listInt.RemoveRange(5,10);
            Console.WriteLine(listInt.ToString() );
        }
    }
}