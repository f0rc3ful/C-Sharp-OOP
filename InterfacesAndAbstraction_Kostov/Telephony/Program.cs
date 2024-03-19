namespace PersonInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] websites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> qNumbers = new Queue<string>(phoneNumbers);

            while (qNumbers.Count > 0)
            {
                string number = qNumbers.Dequeue();
                foreach (char c in number)
                {
                    if (!char.IsDigit(c))
                    {
                        Console.WriteLine("Invalid number!");
                        continue;
                    }
                }
                if (number.Length == 10)
                {
                    Console.WriteLine($"Calling... {number}");
                }
                else if (number.Length == 7)
                {
                    Console.WriteLine($"Dialing... {number}");
                }
            }

            Queue<string> qWebsites = new Queue<string>(websites);

            while (qWebsites.Count > 0)
            {
                string website = qWebsites.Dequeue();
                bool valid = true;
                foreach (char c in website)
                {
                    if (char.IsDigit(c))
                    {
                        Console.WriteLine("Invalid URL!");
                        valid = false;
                        break;
                    }
                }
                if (valid) 
                {
                    Console.WriteLine($"Browsing: {website}!");
                }

            }
        }
    }
}