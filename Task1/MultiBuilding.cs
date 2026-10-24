namespace Task1
{
	public sealed class MultiBuilding : Building
	{
		public int Floor { get; set; }

		public MultiBuilding(string adres, double length, double width, double height, int floor)
			:base(adres, length, width, height)
		{
			Floor = floor;
		}

		public string Print()
		{
			string result = base.Print();
			result += $"\nЭтажность здания: {Floor}.";
			return result;
        }
	}
}