namespace OOP05_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical
            #region Question01
            //a)  What is Abstraction in Object-Oriented Programming?
            //hide implementation datails and only show new and important features

            //b)  Why is abstraction considered one of the four pillars of OOP?
            // makes programs simpler, easier to understand, and easier to maintain.
            #endregion
            #region Question02
            //a)  What is the difference between an Abstract Class and an Interface?
            // 1-Abstract                                      2-Interface
            //1.can inhert from one abstract class             can inhert from multible Interface
            //2.exist constructor and feild                    no exist
            //3.have abstract and concrete methods             have only abstract methode but after C# 8.0 can have default methodes

            //b)  When would you choose an Interface instead of an Abstract Class?
            //to define a contract without forcing the class to inherit from a specific base class.


            //c)  Can a class inherit from multiple abstract classes?
            //  Noooooo
            //Can it implement multiple interfaces?
            //   Yesssss

            #endregion
            #endregion
            #region practical

            string deliveryCenter = "Cairo";
            Console.WriteLine("\n=========================================");
            Console.WriteLine($"Delivery Center: {deliveryCenter} ");
            Console.WriteLine("======================================");

            //    string driverName = "Osama Ahmed";
            DeliveryCenter center = new DeliveryCenter();
            //    center.Driver = driverName;


            //    Console.WriteLine($"\nDriver : {driverName}");


            //    Console.WriteLine("\n------------------------------------------");

            #region Standard


            Console.WriteLine("\nEnter Standard Shipment Data");

            Console.Write("Tracking Code: ");
            string trackingCode01 = Console.ReadLine()!;

            Console.Write("Description: ");
            string description01 = Console.ReadLine()!;

            Console.Write("Weight: ");
            double weight01 = double.Parse(Console.ReadLine()!);

            Console.Write("Delivery Fee: ");
            decimal deliveryFee01 = decimal.Parse(Console.ReadLine()!);

            Console.Write("City: ");
            string city01 = Console.ReadLine()!;

            Console.Write("Street: ");
            string street01 = Console.ReadLine()!;

            Console.Write("Building Number: ");
            int buildingNumber01 = int.Parse(Console.ReadLine()!);

            DeliveryAddress address01 = new DeliveryAddress(city01, street01, buildingNumber01);

            StandardShipment standard = new StandardShipment(
                trackingCode01,
                description01,
                weight01,
                deliveryFee01,
                address01);

            if (center.AddShipment(standard))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }
            else
            {
                Console.WriteLine("Delivery Center is Full.");
            }


            #endregion
            #region Express 
            Console.WriteLine("\nEnter Express Shipment Data");

            Console.Write("Tracking Code: ");
            string trackingCode02 = Console.ReadLine()!;

            Console.Write("Description: ");
            string description02 = Console.ReadLine()!;

            Console.Write("Weight: ");
            double weight02 = double.Parse(Console.ReadLine()!);

            Console.Write("Delivery Fee: ");
            decimal deliveryFee02 = decimal.Parse(Console.ReadLine()!);

            Console.Write("City: ");
            string city02 = Console.ReadLine()!;

            Console.Write("Street: ");
            string street02 = Console.ReadLine()!;

            Console.Write("Building Number: ");
            int buildingNumber02 = int.Parse(Console.ReadLine()!);

            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine()!);

            DeliveryAddress address02 = new DeliveryAddress(city02, street02, buildingNumber02);

            ExpressShipment express = new ExpressShipment(trackingCode02, description02, weight02, deliveryFee02,
                address02, extraFee);

            if (center.AddShipment(express))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }
            else
            {
                Console.WriteLine("Delivery Center is Full.");
            }
            #endregion
            #region International
            Console.WriteLine("\nEnter International Shipment Data");

            Console.Write("Tracking Code: ");
            string trackingCode03 = Console.ReadLine()!;

            Console.Write("Description: ");
            string description03 = Console.ReadLine()!;

            Console.Write("Weight: ");
            double weight03 = double.Parse(Console.ReadLine()!);

            Console.Write("Delivery Fee: ");
            decimal deliveryFee03 = decimal.Parse(Console.ReadLine()!);

            Console.Write("City: ");
            string city03 = Console.ReadLine()!;

            Console.Write("Street: ");
            string street03 = Console.ReadLine()!;

            Console.Write("Building Number: ");
            int buildingNumber03 = int.Parse(Console.ReadLine()!);

            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine()!);

            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine()!;

            DeliveryAddress address03 = new DeliveryAddress(city02, street02, buildingNumber02);

            InternationalShipment International = new InternationalShipment(trackingCode03, description03, weight03, deliveryFee03,
                address03, customsFee, destinationCountry);

            if (center.AddShipment(International))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }
            else
            {
                Console.WriteLine("Delivery Center is Full.");
            }
            #endregion


            center.PrintAllShipments();


            ITrackable[] Items =
            {
                     new StandardShipment( trackingCode01,description01,weight01,deliveryFee01,address01),
                         new ExpressShipment(trackingCode02, description02, weight02, deliveryFee02,address02, extraFee),
                          new InternationalShipment(trackingCode03, description03, weight03, deliveryFee03,
                        address03, customsFee, destinationCountry)
            };


            Console.WriteLine("\n======================================");
            Console.WriteLine("Tracking Status\n");
            center.PrintTrackingStatuses(Items);


            Console.WriteLine("\n======================================");
            Console.WriteLine("Insurance\n");
            center.printIInsurableCosts(Items);

            Console.WriteLine("\n======================================\n");

            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");


            //    Console.WriteLine("\n======================================");
            //    Console.Write("\n\nPrinting Using DeliveryHelper...\n\n");

            //    Shipment[] shipments = new Shipment[]
            //    {
            //            new StandardShipment( trackingCode01,description01,weight01,deliveryFee01,address01),
            //             new ExpressShipment(trackingCode02, description02, weight02, deliveryFee02,address02, extraFee),
            //              new InternationalShipment(trackingCode03, description03, weight03, deliveryFee03,
            //            address03, customsFee, destinationCountry)
            //};
            //    foreach (Shipment shipment in shipments)
            //    {
            //        DeliveryHelper.PrintShipmentDetails(shipment);
            //        Console.WriteLine($"\n{shipment.Name} Printed Successfully.");
            //    }

            //    Console.WriteLine("\n======================================");
            //    Console.Write("\n\nUpdating Weight...\n\n");

            //    Shipment sh = new Shipment("Sh102");
            //    double OriginalWeight = 3;
            //    Console.WriteLine($"Original Weight : {OriginalWeight} KG\n");

            //    sh.weightUpdate(5);

            //    Console.WriteLine($"Updated Weight : {sh.Weight} KG\n");

            //    sh.weightUpdate(sh.Weight, 0.5);

            //    Console.WriteLine($"Updated Weight After Packing : {sh.Weight} KG\n");




            //    Console.WriteLine("\n======================================");
            //    Console.Write("\n\nPrinting Using Shipment[]...\n\n");


            //    foreach (Shipment shipment in shipments)
            //    {
            //       shipment.PrintShipment();
            //    }
            //    Console.WriteLine("\n======================================");
            #endregion


        }
    }
}
