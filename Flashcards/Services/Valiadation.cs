﻿using System.Linq;

public class Valiadation()
{
    public int GetValidInt(int min, int max)
    {
        bool IsValidInt = false;
        int result = 0;
        const int resultOffset = 1;

        while (!IsValidInt)
        {
            var input = Console.ReadLine();
            if (!int.TryParse(input, out result) || result < min || result > max) Console.WriteLine($"Invalid value. Please enter a number value between {min} and {max}");
            else IsValidInt = true;
        }

        return result-resultOffset;
    }

    public Stack GetValidStack(List<Stack> stacks)
    {
        string? input = null;
        Stack? validStack = null;

        while (validStack is null)
        {
            input = Console.ReadLine()?.ToLower();
            validStack = stacks.FirstOrDefault(x => x.Name.ToLower() == input);

            if (validStack is null)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That stack does not exist. Please try again.");
                Console.ResetColor();
            }
        }

        return validStack;
    }

    public Stack CreateStack(List<Stack> stacks)
    {
        string? input = null;
        Stack? validStack = null;

        while (validStack is null)
        {
            input = Console.ReadLine();

            if (stacks.FirstOrDefault(x => x.Name.ToLower() == input.ToLower()) != null)
            {
                Console.WriteLine("That stack name already exists.");
            }
            else if (input.Count(char.IsLetter) < 3)
            {
                Console.WriteLine("Your stack must contain at least 3 characters.");
            }
            else
            {
                validStack = new Stack();
                validStack.Name = input;
            }
        }

        return validStack;
    }
}