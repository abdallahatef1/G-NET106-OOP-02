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


        }
    }
}

