using System;

namespace TileCost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width;
            double height;
            double costPerUnit = 5.99;
            double area;
            string[] roomTypes = {"rectangle", "triangle"};
            string roomType = "";
            double labourCosts;
            double labourSalary = 86.00;
            double squareFeetPerHour = 20;
            double totalCost;

            while (roomType == "")
            {
                Console.Write("Select the room shape (1 - rectangle, 2 - triangle): ");
                try
                {
                    roomType = roomTypes[Convert.ToInt32(Console.ReadLine()) - 1];
                }

                catch(Exception e)
                {
                    Console.WriteLine(e.Message, "Non-existent option. Please re-enter");
                }
            }
            Console.Write("Enter the width (in metres): ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the length (in metres): ");
            height = Convert.ToDouble(Console.ReadLine());
            if (roomType == "triangle")
            {
                area = (width * height) / 2;
            }
            else
            {
                area = width * height;
            }
            labourCosts = labourSalary * (area / squareFeetPerHour);
            Console.WriteLine($"Salary costs: £{labourCosts:0.00}");
            totalCost = (costPerUnit * area + labourCosts);
            Console.WriteLine($"Quote for carpet: £{totalCost:0.00}");
        }
    }
}
