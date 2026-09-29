namespace OOP01Task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            // Q1: Overloading, Overriding, and Binding

            /*
             * a) What is the difference between Method Overloading and Method Overriding?
             * 
             * - Method Overloading:
             *   - Type: Static Polymorphism (Compile-time Polymorphism).
             *   - Definition: Allows a class to have multiple methods with the same name within the same class, 
             *                 but with different parameter lists 
             * 
             * - Method Overriding:
             *   - Type: Dynamic Polymorphism (Runtime Polymorphism).
             *   - Definition: Allows a derived (child) class to provide a specific implementation for a method 
             *                 that is already defined in its base (parent) class using virtual and override keywords.
             */

            /*
             * b) What is the difference between Static Binding and Dynamic Binding?
             * 
             * - Static Binding (Early Binding):
             *   - Timing: Occurs during Compile-Time.
             *   - Behavior: Method call is resolved based on the Reference Type at compile time.
             *   - Used With: Method Overloading and Method Hiding (using the 'new' keyword).
             * 
             * - Dynamic Binding (Late Binding):
             *   - Timing: Occurs during Runtime.
             *   - Behavior: Method call is resolved based on the actual Object Type in memory at runtime.
             *   - Used With: Method Overriding (using virtual/override) and Abstract Methods.
             */

            #endregion

            #region In Main
            // a. Create a Driver
            Driver driver = new Driver("Ahmed Mohamed");

            // b. Create a DeliveryCenter
            DeliveryCenter center = new DeliveryCenter("Cairo Main Center");

            // c. Assign the Driver to the DeliveryCenter
            center.AssignedDriver = driver;

            // d. Create one StandardShipment
            DeliveryAddress stdAddress = new DeliveryAddress("Cairo", "Tahrir St", 10);
            StandardShipment standardShipment = new StandardShipment("SH001", "Laptop", 3.0, 80, stdAddress);

            // e. Create one ExpressShipment
            DeliveryAddress expAddress = new DeliveryAddress("Giza", "Pyramids St", 5);
            ExpressShipment expressShipment = new ExpressShipment(20, "EX002", "Smart Phone", 1.5, 120, expAddress);

            // f. Create one InternationalShipment
            DeliveryAddress intAddress = new DeliveryAddress("Riyadh", "King Fahd Rd", 12);
            InternationalShipment internationalShipment = new InternationalShipment("Saudi Arabia", 50, "IN003", "Document File", 0.5, 200, intAddress);

            // g. Add all shipments to the DeliveryCenter
            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);

            //// h. Print all shipments using PrintAllShipments()
            center.PrintAllShipments();

            // i. Call DeliveryHelper.PrintShipmentDetails() for each shipment
            Console.WriteLine("\n--- Printing Using DeliveryHelper... ---");
            DeliveryHelper.PrintShipmentDetails(standardShipment);
            DeliveryHelper.PrintShipmentDetails(expressShipment);
            DeliveryHelper.PrintShipmentDetails(internationalShipment);

            // j. Demonstrate both versions of UpdateWeight()
            Console.WriteLine("Updating Weight...\n");
            Console.WriteLine($"Original Weight : {standardShipment.Weight} KG"); //3

            standardShipment.UpdateWeight(5.0);
            Console.WriteLine($"Updated Weight : {standardShipment.Weight} KG");

            standardShipment.UpdateWeight(5.0, 0.5);
            Console.WriteLine($"Updated Weight After Packing : {standardShipment.Weight} KG");

            Console.WriteLine("==============================================");

            // k. Build a Shipment[] holding mixed types and print all of them in a loop
            Console.WriteLine("Printing Using Shipment[]...\n");

            Shipment[] mixedShipments = new Shipment[]
            { standardShipment,  expressShipment,internationalShipment };
            foreach (Shipment shipment in mixedShipments)
            {
                if (shipment is StandardShipment)
                {
                    Console.WriteLine("Standard Shipment...\n");
                }
                else if (shipment is ExpressShipment)
                {
                    Console.WriteLine("Express Shipment...\n");
                }
                else if (shipment is InternationalShipment)
                {
                    Console.WriteLine("International Shipment...\n");
                }
            }
            Console.WriteLine("==============================================");
            #endregion
            Console.ReadLine();
        }
    }
}
