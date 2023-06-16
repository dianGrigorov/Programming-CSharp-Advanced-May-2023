using System;
using System.Collections.Generic;
using System.Linq;

namespace MealPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> meals = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Stack<int> calories = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Dictionary<string, int> mealsCalories = new Dictionary<string, int>()
            {
                { "salad", 350},
                { "soup", 490},
                { "pasta", 680},
                { "steak", 790}
            };
            int eatedMeals = 0;

            while (calories.Any() && meals.Any())
            {
                int dailyCalories = calories.Pop();
                string currMeal = meals.Peek();
                while (dailyCalories > 0 && meals.Any())
                {
                    meals.Dequeue();
                    eatedMeals++;
                    dailyCalories -= mealsCalories[currMeal];
                    if (meals.Any())
                    {
                        currMeal = meals.Peek();

                    }
                }
                if (dailyCalories <= 0)
                {
                    
                    if (calories.Any())
                    {
                        calories.Push(calories.Pop() + dailyCalories );
                    }
                }
                else if( dailyCalories > 0 && !meals.Any())
                {
                    calories.Push(dailyCalories);
                }


            }

            if (!meals.Any())
            {
                Console.WriteLine($"John had {eatedMeals} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calories)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {eatedMeals} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }
        }
    }
}
