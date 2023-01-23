using StreamingPlatform;

namespace StreamingPlatform_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Platform netflix = new Platform("Netflix");
            Movie thePaleBlueEye = new Movie("The pale blue eye", new DateTime(2023,01, 06), 120);
            Serie vikings = new Serie("Viking : Valhalla", new DateTime(2022, 07, 02), 52, 16);
            Movie perfectDays = new Movie("Tous nos jours parfaits", new DateTime(2020, 12, 20), 95);
            Movie eurovision = new Movie("Eurovision", new DateTime(2020, 04, 10), 97);
            Movie daFiveBloods = new Movie("Da 5 Bloods", new DateTime(2020, 06, 13), 155);
            netflix.AddProduction(thePaleBlueEye);
            netflix.AddProduction(vikings);
            netflix.AddProduction(perfectDays);
            netflix.AddProduction(eurovision);
            netflix.AddProduction(daFiveBloods);

            Console.WriteLine(netflix.DisplayCompleteDescription());

            Console.WriteLine("Y a-t-il la série \"Viking : Valhalla\" sur netflix?");
            try
            {
                Production prodNetflix = netflix.SearchProduction("Viking : Valhalla");
                Console.WriteLine("Oui, " + netflix.SearchProduction("Viking : Valhalla").DisplayDescription());
            }
            catch (ProductionNotFoundException pnfe)
            {
                Console.WriteLine("Non.");
            }
            
            Console.WriteLine();

            Platform myCanal = new Platform("MyCanal");
            Movie topGunMaverick = new Movie("Top Gun : Maverick", new DateTime(2022, 08, 15), 125);
            Movie elvis = new Movie("Elvis", new DateTime(2022, 07, 25), 155);
            Serie parisPolice = new Serie("Paris Police 1905", new DateTime(2022, 12, 12), 52, 6);
            myCanal.AddProduction(topGunMaverick);
            myCanal.AddProduction(elvis);
            myCanal.AddProduction(parisPolice);

            Console.WriteLine(myCanal.DisplayCompleteDescription());

            Console.WriteLine("Y a-t-il la série \"Viking : Valhalla\" sur MyCanal?");
            try
            {
                Production prodNetflix = myCanal.SearchProduction("Viking : Valhalla");
                Console.WriteLine("Oui, " + myCanal.SearchProduction("Viking : Valhalla").DisplayDescription());
            }
            catch (ProductionNotFoundException pnfe)
            {
                Console.WriteLine("Non. " + pnfe.Message);
            }
        }
    }
}