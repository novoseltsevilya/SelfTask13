namespace Task1
{
	public class Building
	{
		public string Adres { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Building(string adres, double length, double width, double height)
		{
			Adres = adres;
			Length = length;
			Width = width;
			Height = height;
		}

		public string Print()
		{
			return $"Адрес здания: {Adres}.\n" +
				$"Длина здания: {Length}м.\n" +
				$"Ширина здания: {Width}м.\n" +
				$"Высота здания: {Height}м.";
		}
    }
}