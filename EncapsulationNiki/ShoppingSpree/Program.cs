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
                    personsList.Add(person);
                }

                for (int j = 0; j < productsData.Length; j+=2)
                {
                    string name = productsData[j];
                    int cost = int.Parse(productsData[j + 1]);
                    Product product = new Product(name, cost);
                    productsList.Add(product);
                }
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = personsList.Find(p => p.Name == tokens[0]);
                Product product = productsList.Find(p => p.Name == tokens[1]);
                try
                {
                    if (product is not null && person is not null)
                    {
                        person.AddProduct(product);
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var person in personsList)
            {
                if (person.Bag.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag.Select(item => item.Name))}");
                }
            }
        }
    }
}