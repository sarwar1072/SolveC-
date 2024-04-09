using System.ComponentModel;
namespace Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            int count = 0;
            int count2 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]>='a' && str[i] <= 'z')
                {
                    count++;
                }
                else
                {
                    count2++;
                }
            }
            if (count > count2)
            {
                Console.WriteLine(str.ToLower());
            }
            else if (count == count2)
            {
                Console.WriteLine(str.ToLower());
            }
            else
            {
                Console.WriteLine(str.ToUpper());
            }

        }
    }
}