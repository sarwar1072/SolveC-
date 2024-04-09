namespace BoysAndGirls
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            string str = Console.ReadLine();
            int number=str.Distinct().Count();  
            if(number % 2 == 0) 
            {
                Console.WriteLine("CHAT WITH HER!");

            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }           
        }
    }
}