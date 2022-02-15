using System;

namespace TileCost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width;
            int height;
            int cost_per_unit = 6;
            int area;
            double total_cost;
            string room_type;
            int labour_costs;
            int labour_salary = 86;
            int square_feet_per_hour = 20;

            Console.Write("What is the shape of the room? ");
            room_type = Console.ReadLine();
            Console.Write("Enter the width: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length: ");
            height = Convert.ToInt32(Console.ReadLine());
            if (room_type == "triangle")
            {
                area = (width * height) / 2;
            }
            else
            {
                area = width * height;
            }
            labour_costs = labour_salary * (area / square_feet_per_hour);
            Console.Write($"Salary costs: £{labour_costs}");
            total_cost = cost_per_unit * area + labour_costs;
            Console.WriteLine($"Quote for carpet: £{total_cost}");
        }
    }
}