namespace Lucky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string arr;

            for(int i = 0; i < n; i++) 
            {
                arr = Console.ReadLine();         
                if (arr[0] + arr[1] + arr[2] == arr[3] + arr[4] + arr[5])
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                
            }
        }
    }
}