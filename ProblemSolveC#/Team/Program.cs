namespace Team
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arr=new string[n];
            int final = 0, count = 0;

            for (int i = 0; i < n; i++) 
            {
                arr[i] = Console.ReadLine().Replace(" ", "");
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i][j] == '1')
                    {
                        count++;
                    }

                }
                if (count > 1)
                {
                    final++;
                }
                count = 0;
            }
            Console.WriteLine(final);
        }
    }
}