namespace WordCapitalization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = "of mice and men By CNN";
            //string[] words = input.Split(' ');
            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine(words.Length);
            //for (int i = 0; i < words.Length; i++)
            //{
            //    string word = words[i];
            //    if (word.Length > 0)
            //    {
            //        words[i] = char.ToUpper(word[0]) + word.Substring(1).ToLower();
            //    }
            //}
            //string output = string.Join(" ", words);
            //Console.WriteLine(output);

            String str = Console.ReadLine();

            if (str[0] >= 'a' && str[0] <= 'z')
            {
                str = str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1);
            }
            Console.WriteLine(str);
        }
    }
}