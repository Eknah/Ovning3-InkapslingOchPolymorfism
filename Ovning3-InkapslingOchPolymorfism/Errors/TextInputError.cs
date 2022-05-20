
namespace Ovning3_InkapslingOchPolymorfism
{
	internal class TextInputError : UserError
	{
		public override string UEMessage()
		{
			return "tried to use a text input in a numeric only field. This fired an error!";
		}
	}
}
