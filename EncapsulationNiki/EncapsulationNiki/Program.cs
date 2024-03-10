class Person
{
	private string firstName;

	public string FirstName
	{
		get { return firstName; }
		private set { firstName = value; }
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