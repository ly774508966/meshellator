namespace Meshellator.Importers.Obj.Objects.Parsers
{
	public abstract class LineParser
	{
		public string[] Words { get; set; }

		public virtual void Parse(string fileName)
		{
			Parse();
		}
		public abstract void Parse();

		public abstract void IncorporateResults(WavefrontObject wavefrontObject);
	}
}