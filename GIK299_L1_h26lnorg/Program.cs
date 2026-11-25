namespace GIK299_L1_h26lnorg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Deklarera de variabler du behöver för beräkningen.
            //       Se Del 1 och Tekniska krav i instruktionen.

            // ----------------------------------------------------------------
            // DEL 3 – MENY OCH LOOP
            // TODO: Håll programmet igång med en while-loop som har en bool
            //       som villkor.
            // TODO: Skriv ut menyn och läs in användarens val.
            // TODO: Hantera valet med en switch-sats. Ogiltigt val ska ge ett
            //       felmeddelande och en ny chans.
            // TIPS: Bygg del 1 nedan först. Lägg den sedan under rätt menyval.
            //
            // PUFF: Menyvalet du läser in med ReadLine() är en string, så du
            //       kan jämföra direkt mot text i dina case. Ta bort // på raderna
            //       nedan och bygg vidare med de delar som saknas.
            //
            // switch (choice)
            // {
            //     case "1":
            //         // Här ska din beräkning från del 1 (och del 4) köras
            //         break;
            //
            //     // Vilket case behövs för att avsluta? Vad ska hända med
            //     // din bool då?
            //
            //     default:
            //         // Vad ska användaren få veta här?
            //         break;
            // }
            // ----------------------------------------------------------------

            // ----------------------------------------------------------------
            // DEL 1 – GRUNDLÄGGANDE BERÄKNING
            // TODO: Be användaren ange temperaturen och läs in den.
            //       Kom ihåg: ReadLine() ger en sträng som måste parsas.
            // TODO: Fråga om vinden anges i km/h eller m/s, och läs in den.
            // TODO: Om vinden är i m/s: räkna om till km/h (m/s · 3,6).
            // TODO: Ogiltig inmatning ska ge ett felmeddelande och en ny chans.

            //deklarera variabler
            double temperature = 0;
            double windSpeed = 0;
            double windChillTemperature = 0;
            int windSpeedSuffix;

            //input - hämta värde från användaren
            Console.WriteLine("Skriv in temperatur i °C:");
            temperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Vindhastighet i km/h (1) eller m/s (2)?");
            windSpeedSuffix = Convert.ToInt32(Console.ReadLine());

            //om användaren skriver siffran 1
            if (windSpeedSuffix == 1)
            {
                Console.WriteLine("Skriv in vindhastighet i km/h:");
                windSpeed = Convert.ToDouble(Console.ReadLine());
            }

            //om användaren skriver siffran 2
            else if (windSpeedSuffix == 2)
            {
                Console.WriteLine("Skriv in vindhastighet i m/s:");
                windSpeed = Convert.ToDouble(Console.ReadLine()) * 3.6; //räknar om m/s till km/h
            }

            //om användaren skriver en annan siffra än 1 och 2
            else 
            {
                Console.WriteLine("Du har skrivit in fel siffra, prova igen.");
            }

            //deklarerar en variabel och beräknar vindhastighet upphöjt till 0,16
            double windSpeedPow = Math.Pow(windSpeed, 0.16);

            //uträkning wind chill temperature
            windChillTemperature = 13.12 + 0.6215 * temperature - 11.37 * windSpeedPow + 0.3965 * temperature * windSpeedPow;

            //skriver ut wind chill-faktorn med en decimal
            Console.WriteLine("Wind chill-faktorn är " + windChillTemperature.ToString("F1"));

            // ----------------------------------------------------------------

            // DEBUG (del 2): <fyll i efter att du stegat genom koden>
            // Breakpoint satt på raden nedan (där WCT beräknas).
            // Testvärden: T = ..., V = ... (enhet: ...)
            // Locals/Watch: <variabel> = ..., <variabel> = ..., ...
            // Reflektion: <vad det hjälpte dig att se eller hitta>
            // TODO: Beräkna WCT enligt formeln i instruktionen.

            // TODO: Skriv ut WCT i en begriplig mening med en decimal.

            // ----------------------------------------------------------------
            // DEL 4 – KLASSIFICERING
            // TODO: Skriv ut var på skalan WCT hamnar med en if-else-kedja:
            //       Kallt / Mycket kallt / Risk för frostskada /
            //       Stor risk för frostskada. Tänk på ordningen!
            // ----------------------------------------------------------------
        }
    }
}
