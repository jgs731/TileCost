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
            double totalCost;
            string roomType;
            int labourCosts;
            int labourSalary = 86;
            int squareFeetPerHour = 20;

            Console.Write("What is the shape of the room? ");
            roomType = Console.ReadLine();
            Console.Write("Enter the width: ");
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
