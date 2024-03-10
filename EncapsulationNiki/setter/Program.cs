
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
    public Person(int salary)
    {
        this.Salary = salary; // the salary input is validated through the property and it's setter so if any changes to the validation logic were
        // to be made, only the setter in the property would be referred to
        // a way better alternative than this.salary = salary because accessing the field directly would bypass the setter logic 
        // and if we were to set up another validation in the constructor, later on, when a change would be necessary, the code would require 
        // multiple edits instead of only editing the setter in the property
    }

}
class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person(300);
        Console.WriteLine(person1.Salary);
    }
}