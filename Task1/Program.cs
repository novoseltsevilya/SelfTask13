namespace Task1;

class Task1
{
    static void Main(string[] args)
    {
        MultiBuilding multiBuilding = new MultiBuilding(
            "г. Москва, ул. Ленина, д.2",
            1200,
            67,
            52,
            23);

        Console.WriteLine(multiBuilding.Print());
        Console.WriteLine("Для выхода нажмите любую клавишу:");
        Console.ReadKey();
    }
}