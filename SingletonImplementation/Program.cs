namespace SingletonImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lunch Myorder = Lunch.getInstance();
            Myorder.setLunchOrder("Ham and cheese on bread");
            Lunch Myorder2 = Lunch.getInstance();
            Myorder2.setLunchOrder("Mayo on bread");
            Lunch Myorder3 = Lunch.getInstance();   
            Console.WriteLine(Myorder3.getLunchOrder());
        }
    }
}