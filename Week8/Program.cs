using Week8;

var ob1 = new Letter("aaa33", 10.2);
var ob2 = new Letter("bbb22", 2.3);
var ob3 = new Parcel("ccc44", 55.2, "22x30x30");
var ob4 = new Parcel("ddd55", 32.5, "10x10x10");

ob1.PrintInfo();
ob3.PrintInfo();

var container = new CargoContainer<DeliveryItem>();

container.AddItem(ob1);
container.AddItem(ob2);
container.AddItem(ob3);
container.AddItem(ob4);

Console.WriteLine(container.GetTotalCost());