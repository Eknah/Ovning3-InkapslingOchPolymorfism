
namespace Ovning3_InkapslingOchPolymorfism.Animals
{
	internal class Dog : Animal
	{

		public double TailLength { get; }

		public Dog(string name, double weight, int age, int numberOfLegs, double tailLength) : base(name, weight, age, numberOfLegs)
		{
			TailLength = tailLength;
		}

		public override string DoSound()
		{
			return "Woff!";
		}

		public override string Stats()
		{
			return base.Stats() + $"\tTail length: {TailLength} m";
		}

		public string DogSpecificMethod()
		{
			return "From Dog";
		}
	}
}
