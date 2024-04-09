namespace PetyaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1= Console.ReadLine().ToLower();
            string str2 = Console.ReadLine().ToLower();

            if(str1 == str2) {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] == str2[i])
                    {
                        continue;
                    }
                    else if (str1[i] > str2[i])
                    {
                        Console.WriteLine("1");
                        break;
                    }
                    else if (str1[i] < str2[i])
                    {
                        Console.WriteLine("-1");
                        break;
                    }

                }
            }
        }
    }
}