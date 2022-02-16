using System;

namespace TileCost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width;
            int height;
            int costPerUnit = 6;
            int area;
            string[] roomTypes = {"rectangle", "square", "triangle"};
            string roomType = "";
            int labourCosts;
            int labourSalary = 86;
            int squareFeetPerHour = 20;
            double totalCost;

            while (roomType == "")
            {
                Console.Write("Select the room shape (1 - rectangle, 2 - square, 3 - triangle): ");
                try
                {
                    roomType = roomTypes[Convert.ToInt32(Console.ReadLine()) - 1];
                }

                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Non-existent option. Please re-enter");
                }
            }
            Console.Write("Enter the width (in full metres): ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length (in full metres): ");
            height = Convert.ToInt32(Console.ReadLine());
            if (roomType == "triangle")
            {
                area = (width * height) / 2;
            }
            else
            {
                area = width * height;
            }
            labourCosts = labourSalary * (area / squareFeetPerHour);
            Console.WriteLine($"Salary costs: £{labourCosts}");
            totalCost = costPerUnit * area + labourCosts;
            Console.WriteLine($"Quote for carpet: £{totalCost}");
        }
    }
}
