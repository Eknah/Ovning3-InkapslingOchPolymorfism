
namespace Ovning3_InkapslingOchPolymorfism.Animals
{
	internal class Worm : Animal
	{

		public bool IsPoisonous { get; set; }

		public Worm(string name, double weight, int age, int numberOfLegs, bool isPoisonous) : base(name, weight, age, numberOfLegs)
		{
			IsPoisonous = isPoisonous;
		}

		public override string DoSound()
		{
			return "(silence)";
		}

		public override string Stats()
		{
			return base.Stats() + $"\tIs poisonous: {(IsPoisonous ? "Yes" : "No")}";
		}
	}
}
