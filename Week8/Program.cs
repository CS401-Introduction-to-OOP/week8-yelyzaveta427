using Week8;

public class Program
{
    public static void Main()
    {
        var letterContainer = new CargoContainer<Letter>();
        var l1 = new Letter("123", 12);
        var l2 = new Letter("345", 30);
        letterContainer.AddItem(l1);
        letterContainer.AddItem(l2);
        
        l1.PrintInfo();
        
        var parcelContainer = new CargoContainer<Parcel>();
        var p1 = new Parcel("475", 24, "30*20*15");
        var p2 = new Parcel("876", 31, "10*25*15");
        parcelContainer.AddItem(p1);
        parcelContainer.AddItem(p2);
        
        p1.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(l1);
        myCargo.AddItem(l2);
        myCargo.AddItem(p1);
        myCargo.AddItem(p2);
        Console.WriteLine($"Total cost of items {myCargo.GetTotalCost()}");


    }
}