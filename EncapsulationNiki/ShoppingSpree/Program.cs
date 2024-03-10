namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] delims = new[] { ';' , '=' }; 
            string[] peopleData = Console.ReadLine().Split(delims, StringSplitOptions.RemoveEmptyEntries);
            string[] productsData = Console.ReadLine().Split(delims, StringSplitOptions.RemoveEmptyEntries);
            List<Person> personsList = new List<Person>();
            List<Product> productsList = new List<Product>();

            try
            {
                for (int i = 0; i < peopleData.Length; i += 2)
                {
                    string name = peopleData[i];
                    int money = int.Parse(peopleData[i + 1]);
                    Person person = new Person(name, money);
                }
                for (int j = 0; j < productsData.Length; j++)
                {
                    string name = productsData[j];
                    int cost = int.Parse(productsData[j + 1]);
                    Person person = new Person(name, cost);
                }
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] parts = input.Split(" ");
                string name = parts[0];
                string product = parts[1];
            }
        }
    }
}