
namespace Ovning3_InkapslingOchPolymorfism.Animals
{
	internal class Flamingo : Bird
	{
		public double NeckLength { get; }

		public Flamingo(string name, double weight, int age, int numberOfLegs, double wingSpan, double neckLength) : base(name, weight, age, numberOfLegs, wingSpan)
		{
			NeckLength = neckLength;
		}

		public override string Stats()
		{
			return base.Stats() + $"\tNeck length: {NeckLength} m";
		}
	}
}
