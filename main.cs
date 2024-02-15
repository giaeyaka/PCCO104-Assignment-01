using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the denomination of the Philippine bank note (in pesos):");
        string DenominationEntered = Console.ReadLine();

        if (decimal.TryParse(DenominationEntered, out decimal denomination))
        {
            string personality = GetPersonalityFromDenomination(denomination);
            if (personality != null)
            {
                Console.WriteLine($"Personality found: {personality}");
            }
            else
            {
                Console.WriteLine("No person found on the bank note.");
            }
        }
        else
        {
            Console.WriteLine($"Invalid Denomination: {DenominationEntered}");
        }
    }

    static string GetPersonalityFromDenomination(decimal denomination)
    {
        switch (denomination)
        {
            case 1:
                return "Jose Rizal";
            case 5:
                return "Emilio Aguinaldo";
            case 10:
                return "Andres Bonifacio, Apolinario Mabini";
            case 20:
                return "Manuel L. Quezon";
            case 50:
                return "Sergio Osmena";
            case 100:
                return "Manuel Roxas";
            case 200:
                return "Diosdado Macapagal";
            case 500:
                return "Benigno Sr. and Corazon Aquino";
            case 1000:
                return "Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda";
            default:
                return null;
        }
    }
}

