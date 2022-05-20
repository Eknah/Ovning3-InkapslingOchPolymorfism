
namespace Ovning3_InkapslingOchPolymorfism.Animals
{
	internal class Bird : Animal
	{
		public double WingSpan { get; }

		public Bird(string name, double weight, int age, int numberOfLegs, double wingSpan) : base(name, weight, age, numberOfLegs)
		{
			WingSpan = wingSpan;
		}

		public override string DoSound()
		{
			return "Kvi kvi";
		}

		public override string Stats()
		{
			return base.Stats() + $"\tWing span: {WingSpan} m";
		}
	}
}
