namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kerpic sayini daxil edin");
            int N=int.Parse(Console.ReadLine());
            int matches = 20 * N - 8;
            Console.WriteLine("Lazim olan en az kibrit miqdari:"+matches);
        }
    }
}