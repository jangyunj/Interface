using Interface;

//create objects of your classes


static void Main(string[] args)
{

    Car car = new Car();
    Truck truck = new Truck();

    var list = new List<IVehicle> { car, truck };

    //object initializer syntax
    var camry = new Car() { HasTrunk = true, IsConvertible = false, Wheels = 4, Windows = 4 };

    //dot notation
    var oiltanker = new Truck();
    oiltanker.Logo = "Shell";  
    oiltanker.Length = 60;
    oiltanker.Weight = 60000;

    camry.HonkNoise();
    oiltanker.HonkNoise();
    Console.WriteLine("---------------------");
    Console.WriteLine($"My camry:" +
        $"Trunk: {camry.HasTrunk}" +
        $"Convertible: {camry.IsConvertible}" +
        $"Wheels: {camry.Wheels}" +
        $"Windows: {camry.Windows}" +
        $"Headlights: {camry.Headlights}");


}
