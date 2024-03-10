
class Person
{
    private int salary;

    public int Salary
    {
        get 
        { 
            return salary; 
        }
        set
        {
            if (value < 650) // the setter checks the forwarded value for the field salary and executes the logic to manipulate it if necessary
            {
                value = 650;
            }
            salary = value;
        }
    }
    public Person()
    {
    }

}
class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.Salary = 300;
        Console.WriteLine(person1.Salary);
    }
}