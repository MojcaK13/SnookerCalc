namespace SnookerCalc
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe czerwonych bil na stole:");
            string redString = Console.ReadLine();
            int reds;
            if (!int.TryParse(redString, out reds))
            {
                Console.WriteLine("{0} nie jest liczbą", redString);
                goto koniec;
            }
            TablePoints tablePoints = new TablePoints(reds);
            tablePoints.wyswietlBile();
            tablePoints.wyswietlMozliwePunkty();
        koniec:
            Console.WriteLine("koniec programu.");
        }
    }
}