namespace Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
        Console.WriteLine($"Added: {item.TrackingNumber}.");
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var item in items)
        {
            totalCost += item.CalculateCost();
        }

        return totalCost;
    }
}