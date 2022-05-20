
namespace Ovning3_InkapslingOchPolymorfism.Animals
{
	internal class Swan : Bird
	{
		public bool IsSwimming { get; set; }

		public Swan(string name, double weight, int age, int numberOfLegs, double wingSpan, bool isSwimming) : base(name, weight, age, numberOfLegs, wingSpan)
		{
			IsSwimming = isSwimming;
		}

		public override string Stats()
		{
			return base.Stats() + $"\tIs swimming: {(IsSwimming ? "Yes" : "No")}";
		}
	}
}
