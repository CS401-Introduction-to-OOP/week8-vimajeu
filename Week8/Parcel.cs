namespace Week8;

public class Parcel : DeliveryItem
{
    public string Dimensions { get; }

    public Parcel(string trackingNumber, double weight, string dimensions) : base(trackingNumber, weight)
    {
        Dimensions = dimensions;
    }

    public override double CalculateCost()
    {
        return 50 + 25 * Weight;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimensions: {Dimensions}.");
    }
}