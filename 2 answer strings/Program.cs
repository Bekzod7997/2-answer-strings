namespace _2_answer_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            string initials = "";
            for (int i = 0; i < words.Length - 1; i++)
            {
                initials += words[i][0] + ". ";
            }
            initials += words[words.Length - 1];

            Console.WriteLine(initials);

            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            string longestWord = "";

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine("Longest word: " + longestWord);

        }
    }
}