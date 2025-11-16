namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> zelda = new List<string>
            {
                "Ocarina of Time", "Majora's Mask", "Twilight Princess", "Phantom Hourglass", "Skyward Sword",
                "Breath of the Wild"
            };
            
            List<string> zeldaAscendLength = zelda.OrderBy(x => x.Length).ToList();
            zeldaAscendLength.ForEach(x => Console.WriteLine(x));
            
            List<string> zeldaDescendLength = zelda.OrderByDescending(x => x.Length).ToList();
            zeldaDescendLength.ForEach(x => Console.WriteLine(x));
            
            List<string> zeldaUppercase = zelda.Select(x => x.ToUpper()).ToList();
            zeldaUppercase.ForEach(x => Console.WriteLine(x));
        }
    }
}
