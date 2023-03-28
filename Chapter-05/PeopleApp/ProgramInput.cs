using Packt.Shared;

partial class Program
{
    static void RunInputs()
    {
        Passenger[] passengers = {
            new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
            new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
            new BusinessClassPassenger { Name = "Janice" },
            new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave" },
            new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" }
        };

        foreach (Passenger passenger in passengers)
        {
            //C# 8
            //decimal flightCost = passenger switch
            //{
            //    FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
            //    FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
            //    FirstClassPassenger _ => 2000M,
            //    BusinessClassPassenger _ => 1000M,
            //    CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
            //    CoachClassPassenger _ => 650M,
            //    _ => 800M
            //};

            decimal flightCost = passenger switch
            {
                FirstClassPassenger p => p.AirMiles switch
                {
                    > 35000 => 1500M,
                    > 15000 => 1750M,
                    _ => 2000M
                },
                BusinessClassPassenger => 1000M,
                CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
                CoachClassPassenger => 650M,
                _ => 800M
            };


            WriteLine($"Flight costs {flightCost:C} for {passenger}");
        }
    }
}
