using car_rental;
namespace car_rental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Rental Journal");
            Journal journal = new Journal();

            journal.Add(new Journal(2, "audi", "az29752"));

            var items = journal.GetJournal();

            foreach (var item in items)
                Console.WriteLine(item.ToString());
        }
    }
}
