
namespace Ovning3_InkapslingOchPolymorfism.Animals
{
	internal class Horse : Animal
	{

		public bool IsTamed { get; }

		public Horse(string name, double weight, int age, int numberOfLegs, bool isTamed) : base(name, weight, age, numberOfLegs)
		{
			IsTamed = isTamed;
		}

		public override string DoSound()
		{
			return "neigh!";
		}

		public override string Stats()
		{
			return base.Stats() + $"\tIs tamed: {(IsTamed ? "Yes" : "No")}";
		}
	}
}
