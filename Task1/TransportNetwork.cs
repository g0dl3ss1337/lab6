namespace Task1;

public class TransportNetwork
{
    public List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void CalculateOptimalRoute(Vehicle vehicle, Route route)
    {
        if (vehicle is Car)
        {
            Console.WriteLine($"Розрахунок оптимального шляху для автомобілю від {route.Start} до {route.End}...");
        }
        else if (vehicle is Bus)
        {
            Console.WriteLine($"Розрахунок оптимального шляху для автобусу від {route.Start} до {route.End}...");
        }
        else if (vehicle is Train)
        {
            Console.WriteLine($"Розрахунок оптимального шляху для потягу від {route.Start} від {route.End}...");
        }
        else
        {
            Console.WriteLine("Непідтримуваний тип автомобіля.");
        }
    }

    public void EmbarkPassengers(Vehicle vehicle, int numPassengers)
    {
        Console.WriteLine($"Посадка {numPassengers} пасажирів у {vehicle.GetType().Name}.");
    }

    public void DisembarkPassengers(Vehicle vehicle, int numPassengers)
    {
        Console.WriteLine($"Висадка {numPassengers} пасажирів з {vehicle.GetType().Name}.");
    }
}

