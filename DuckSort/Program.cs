namespace DuckSort
{
    internal class Program
    {
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
                Console.WriteLine($"{duck.Kind}, {duck.Size} cm");
        }

        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.krzyżówka, Size=43},
                new Duck() { Kind = KindOfDuck.piżmowa, Size=45 },
                new Duck() { Kind = KindOfDuck.nur, Size=35 },
                new Duck() { Kind = KindOfDuck.piżmowa, Size=27 },
                new Duck() { Kind = KindOfDuck.krzyżówka, Size=35 },
                new Duck() { Kind = KindOfDuck.nur, Size=33 },
            };

            DuckComparer comparer = new DuckComparer();

            Console.WriteLine("\nSortowanie według gatunku, potem według wielkości:\n");
            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            Console.WriteLine("\nSortowanie według wielkości, potem według gatunku:\n");
            comparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);
        }
    }
}
