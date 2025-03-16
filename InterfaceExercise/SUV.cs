namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    //In each of your Car, Truck, and SUV classes

    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    public int Row { get; set; }
    public int CargoSpace { get; set; }
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int WheelCount { get; set; }
    public string Logo { get; set; }
    public string Headquarters { get; set; }
}