using System.Text;

namespace Task1;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Car car1 = new Car(120, 5, "Бензин");
        Bus bus1 = new Bus(80, 40, 33);
        Train train1 = new Train(140, 200, "Електричний");

        Human human1 = new Human(5);

        Route route1 = new Route("Київ", "Львів");

        TransportNetwork network = new TransportNetwork();
        network.AddVehicle(car1);
        network.AddVehicle(bus1);
        network.AddVehicle(train1);

        foreach (var vehicle in network.vehicles)
        {
            network.CalculateOptimalRoute(vehicle, route1);
            human1.Move();
            network.EmbarkPassengers(vehicle, 5);
            vehicle.Move();
            network.DisembarkPassengers(vehicle, 5);
        }
    }
}
