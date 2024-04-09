namespace Translation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1=Console.ReadLine(); 
            string str2=Console.ReadLine();

            char[] ch = str2.ToCharArray();
            Array.Reverse(ch); 
            string str3= new string(ch);

            //char[] ch1 = new char[ch.Length];
            //for (int i = 0; i < ch.Length; i++)
            //{
            //    ch1[i]= ch[i];  
            //}
            //Console.WriteLine(ch1);

            if (str1 == str3)
            {
                Console.WriteLine( "YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


        }
    }
}