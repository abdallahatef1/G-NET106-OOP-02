namespace Assignmet_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region             // 1 & 2. Create the DeliveryCenter (name read from the user)
            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine();
            DeliveryCenter center = new DeliveryCenter(centerName);
            Console.WriteLine();


            #endregion

        }
    }
}
