
namespace Ovning3_InkapslingOchPolymorfism
{
	internal class PersonHandler
	{
		public Person CreatePerson(int age, string fname, string lname, double height, double weight)
		{
			Person pers = new Person(age, fname, lname, weight, height);
			return pers;
		}
	}
}
