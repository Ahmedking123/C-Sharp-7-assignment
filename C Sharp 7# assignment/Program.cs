namespace C_Sharp_7__assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Question

            //Q1/ Method ovverloading allows to have multiple methods with the same name but different parameters 
            //   while method overriding allows the derived class to provide specific implementation of a mathod that is already defined in the base class

            //Q2/ static binding is determined at compile time and is associated with the reference type
            //    while dynamic binding is determined at runtime and is associated with the object type

            #endregion
            #region Second Questiob


            //Q1/ It prevents the class from being inherited
            //Q2/ Sealed class is a class that cannot be inherited, while a sealed method is a method that cannot be overridden in derived classes
            //Q3/ Because of the sealed keyword, which prevents the method from being overridden in derived classes
            #endregion
            #region Practical part

            Driver driver = new Driver("Ahmed Mohamed");
            DeliveryCenter deliveryCenter = new DeliveryCenter();
            deliveryCenter.driver = driver;

            for (int i = 1; i <= 3; i++)
            {
                string TrackingCode = Console.ReadLine()!;
                string Description = Console.ReadLine()!;
                decimal Weight = decimal.Parse(Console.ReadLine()!);
                decimal DeliveryFee = decimal.Parse(Console.ReadLine()!);
                string City = Console.ReadLine()!;
                string street = Console.ReadLine()!;
                int buildingNumber = int.Parse(Console.ReadLine()!);
                DeliveryAddress deliveryAddress = new DeliveryAddress(City, street, buildingNumber);

                if (i == 1)
                {
                    StandardShipment standardShipment = new StandardShipment(TrackingCode, Description, Weight, DeliveryFee, deliveryAddress);
                    deliveryCenter.AddShipment(standardShipment);
                }
                else if (i == 2)
                {
                    decimal ExtraFee = decimal.Parse(Console.ReadLine()!);
                    ExpressShipment expressShipment = new ExpressShipment(TrackingCode, Description, Weight, DeliveryFee, deliveryAddress, ExtraFee);
                    deliveryCenter.AddShipment(expressShipment);
                }
                else
                {
                    string DestinationCountry = Console.ReadLine()!;
                    decimal CustomFee = decimal.Parse(Console.ReadLine()!);
                    InternationalShipment internationalShipment = new InternationalShipment(TrackingCode, Description, Weight, DeliveryFee, deliveryAddress, DestinationCountry, CustomFee);
                    deliveryCenter.AddShipment(internationalShipment);
                }
                Console.WriteLine("Shipment added successfully.");
            }

            deliveryCenter.PrintAllShipments();

            DeliveryHelper.PrintShipmentDetails(deliveryCenter[0]);
            DeliveryHelper.PrintShipmentDetails(deliveryCenter[1]);
            DeliveryHelper.PrintShipmentDetails(deliveryCenter[2]);

            Shipment shipment = new Shipment("SH-101");
            shipment.UpdateWeight(10);
            shipment.UpdateWeight(10, 2);

            Shipment[] shipments = new Shipment[3];
            shipments[0] = new StandardShipment("ST-001", "Standard Shipment 1", 5.0m, 10.0m, new DeliveryAddress("City A", "Street A", 1));
            shipments[1] = new ExpressShipment("EX-001", "Express Shipment 1", 3.0m, 15.0m, new DeliveryAddress("City B", "Street B", 2), 5.0m);
            shipments[2] = new InternationalShipment("IN-001", "International Shipment 1", 8.0m, 20.0m, new DeliveryAddress("City C", "Street C", 3), "Country X", 10.0m);
            
            foreach (var Shipment in shipments)
            {
                DeliveryHelper.PrintShipmentDetails(Shipment);
            }
            #endregion

        }
    }
}
