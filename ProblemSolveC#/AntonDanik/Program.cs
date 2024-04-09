namespace AntonDanik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            string str = Console.ReadLine().ToUpper();

            int count = 0;
            int count2 = 0;

            for (int i = 0; i < num; i++) 
            {
                if (str[i] == 'A')
                {
                    count++;
                }
                else if (str[i] == 'D')
                {
                    count2++;
                }

            }
            if (count > count2)
            {
                Console.WriteLine("Anton");
            }
            else if(count2> count)
            {
                Console.WriteLine("Danik");
            }
            else
            {
                Console.WriteLine("Friendship");
            }

        }
    }
}