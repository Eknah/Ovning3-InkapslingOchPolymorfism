
namespace Ovning3_InkapslingOchPolymorfism
{
	internal class Person
	{
		private int age;
		private string? fName;
		private string? lName;
		private double height;
		private double weight;

		public int Age
		{
			get { return age; }
			set
			{
				if (value <= 0)
					throw new ArgumentOutOfRangeException("Age can only be set to a value higher than zero");
				else
					age = value;
			}
		}

		public string FName
		{
			get
			{
				return fName ?? String.Empty;
			}
			set
			{
				if (value.Length < 2 || value.Length > 10)
					throw new ArgumentOutOfRangeException("First name may be set to a value that is at least two characters long and no longer than ten characters.");
				else
					fName = value;
			}
		}

		public string LName
		{
			get
			{
				return lName ?? String.Empty;
			}
			set
			{
				if (value.Length < 3 || value.Length > 15)
					throw new ArgumentOutOfRangeException("First name may be set to a value that is at least three characters long and no longer than fifteen characters.");
				else
					lName = value;
			}
		}

		public double Height
		{
			get { return height; }
			set { height = value; }
		}

		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		public Person(int age, string fname, string lname, double height, double weight)
		{
			Age = age;
			FName = fname;
			LName = lname;
			Height = height;
			Weight = weight;
		}

		public void Rename(string fName, string lName)
		{
			FName = fName;
			LName = lName;
		}

		public void IncreaseAge()
		{
			Age++;
		}

		public override string ToString()
		{
			return $"{FName} {LName} is {Age} years old, is {Height} m long and weights {Weight} kg.";
		}
	}
}
