namespace ProblemSolveC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                int len = str.Length;

                if (len <= 10)
                {
                    Console.WriteLine(str);
                }
                else
                {
                    Console.WriteLine($"{str[0]}{len - 2}{str[len - 1]}");
                }
            }
           
        }
    }
}