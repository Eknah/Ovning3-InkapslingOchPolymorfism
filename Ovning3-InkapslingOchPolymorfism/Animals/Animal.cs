
namespace Ovning3_InkapslingOchPolymorfism
{
	internal abstract class Animal
	{
		public string? Name { get;}
		public double Weight { get;}
		public int Age { get;}
		public int NrOfLegs { get;}

		public abstract string DoSound();

		public Animal(string name, double weight, int age, int numberOfLegs)
		{
			Name = name;
			Weight = weight;
			Age = age;
			NrOfLegs = numberOfLegs;
		}

		public virtual string Stats()
		{
			return $"Namn: {Name}\tWeight: {Weight} kg\tAge: {Age} years\tNumber of Legs: {NrOfLegs}";
		}
	}
}
