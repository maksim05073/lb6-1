namespace lb6
{
    class Program
    {
        static void Main(string[] args)
        {
            Ware[] wares = new Ware[3];
            wares[0] = new Ware
            {
                NameWare = "Ноутбук",
                NamePlace = "Склад A",
                Price = 15000
            };
            wares[1] = new Toy
            {
                NameWare = "Машинка",
                NamePlace = "Магазин D",
                Price = 300,
                Old = 5,
                MadeIn = "Китай"
            };
            wares[2] = new Toy
            {
                NameWare = "М'яч",
                NamePlace = "Магазин D",
                Price = 150,
                Old = 6,
                MadeIn = "Україна"
            };
            foreach (var ware in wares)
            {
                Console.WriteLine(ware.ToString());
                Console.WriteLine("HashCode: " + ware.GetHashCode());
                Console.WriteLine();
            }
            Console.WriteLine("Перевірка Equals:");
            Console.WriteLine(wares[1].Equals(wares[2]));  // false
            Console.WriteLine(wares[1].Equals(wares[1])); // true
            Console.ReadKey();
        }
    }
}