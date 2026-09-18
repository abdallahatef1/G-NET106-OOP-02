namespace Assignmet_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Part 01 : Theoretical Questions
            //1. class is a reference type, while struct is a value type. Classes support inheritance and polymorphism, while structs do not. Classes can have destructors, while structs cannot. Classes are allocated on the heap, while structs are allocated on the stack.

            //2. Inheritance and polymorphism. Large applications reuse code through class hierarchies, and structs can't inherit.
            //q2
            //a. shipment
            //b. ExpressShipment
            //C STRING TRACKING CODE
            // D HE MAKE CODE EASY TO WRITE AND READ 



            #endregion



            #region  1 & 2. Create the DeliveryCenter (name read from the user)
            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine();
            DeliveryCenter center = new DeliveryCenter(centerName);
            Console.WriteLine();


            #endregion

            #region 3 - 6. Create one shipment of each type + read its data
            Console.WriteLine("--- Standard Shipment ---");
            string code1 = ReadString("Tracking Code: ");
            string desc1 = ReadString("Description: ");
            decimal weight1 = ReadDecimal("Weight (KG): ");
            decimal fee1 = ReadDecimal("Delivery Fee (EGP): ");
            DeliveryAddress address1 = ReadAddress();
            StandardShipment standard = new StandardShipment(code1, desc1, weight1, fee1, address1);

            Console.WriteLine();
            Console.WriteLine("--- Express Shipment ---");
            string code2 = ReadString("Tracking Code: ");
            string desc2 = ReadString("Description: ");
            decimal weight2 = ReadDecimal("Weight (KG): ");
            decimal fee2 = ReadDecimal("Delivery Fee (EGP): ");
            DeliveryAddress address2 = ReadAddress();
            decimal extraFee = ReadDecimal("Extra Fee (EGP): ");
            ExpressShipment express = new ExpressShipment(code2, desc2, weight2, fee2, address2, extraFee);

            Console.WriteLine();
            Console.WriteLine("--- International Shipment ---");
            string code3 = ReadString("Tracking Code: ");
            string desc3 = ReadString("Description: ");
            decimal weight3 = ReadDecimal("Weight (KG): ");
            decimal fee3 = ReadDecimal("Delivery Fee (EGP): ");
            DeliveryAddress address3 = ReadAddress();
            string country = ReadString("Destination Country: ");
            decimal customsFee = ReadDecimal("Customs Fee (EGP): ");
            InternationalShipment international = new InternationalShipment(code3, desc3, weight3, fee3, address3, country, customsFee);


            #endregion

            #region  7. Add the shipments to the delivery center
            Console.WriteLine();
            Shipment[] all = { standard, express, international };
            foreach (Shipment s in all)
            {
                if (center.AddShipment(s))
                    Console.WriteLine("Shipment Added Successfully.");
                else
                    Console.WriteLine($"Could not add shipment {s.TrackingCode} (the center is full).");
            }

            #endregion

            #region  8. Print all shipments
            Console.WriteLine();
            center.PrintAllShipments();

            #endregion

            #region 9. Search using the tracking-code indexer
            Console.WriteLine();
            string searchCode = ReadString("Enter Tracking Code to Search: ");
            Shipment found = center[searchCode];
            Console.WriteLine();
            if (found == null)
                Console.WriteLine("Shipment not found.");
            else
                found.PrintShipment();
            #endregion

            #region  10. Remove one shipment by its tracking code
            Console.WriteLine();
            string removeCode = ReadString("Enter Tracking Code to Remove: ");
            Console.WriteLine();
            if (center.RemoveShipment(removeCode))
                Console.WriteLine("Shipment Removed Successfully.");
            else
                Console.WriteLine("Shipment not found.");
            #endregion

            #region 11. Print the remaining shipments
            Console.WriteLine();
            Console.WriteLine("Remaining Shipments");
            center.PrintAllShipments();
            #endregion

        }
        static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static decimal ReadDecimal(string prompt)
        {
            decimal value;
            Console.Write(prompt);
            while (!decimal.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid number, try again: ");
            }
            return value;
        }

        static int ReadInt(string prompt)
        {
            int value;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid number, try again: ");
            }
            return value;
        }

        static DeliveryAddress ReadAddress()
        {
            string street = ReadString("Destination Street: ");
            string city = ReadString("Destination City: ");
            int building = ReadInt("Building Number: ");
            return new DeliveryAddress(city, street, building);
        }


    }

}


