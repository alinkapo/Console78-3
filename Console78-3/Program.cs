internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Один из крупнейших городов России");

        string[] cities_array = new string[] { "Москва", "Санкт-Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казань" };
        Random rand = new Random();
        int index = rand.Next(0,10);

        Console.WriteLine(cities_array[index]);
    }
}