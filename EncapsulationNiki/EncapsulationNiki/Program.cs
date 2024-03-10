class Person
{
	private string firstName;

	public string FirstName
	{
		get { return firstName; } // the get method is used to retreive the firstName value outside the class
		private set { firstName = value; } // the set value is used to forward the input value from the property to the private field
	}
	public Person(string firstName)
	{
		this.firstName = firstName;
	}

}
class Program
{
    static void Main(string[] args)
    {
		Person person1 = new Person("Niki");
		person1.FirstName = "Kolio";
    }
}