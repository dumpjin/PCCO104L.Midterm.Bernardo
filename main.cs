using System;

class Program
{
    static void Main(string[] args)
    {
        int baseFanPower = 10;
        int fanSpeed = 0;
        char oscillateOption = '\0';

        while (true)
        {
            while (true)
            {
                Console.Write("Enter fan speed (1, 2, or 3): ");
                if (int.TryParse(Console.ReadLine(), out fanSpeed) && (fanSpeed >= 1 && fanSpeed <= 3))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter 1, 2, or 3.");
                }
            }
            while (true)
            {
                Console.Write("Oscillate fan? (Y/N): ");
                string input = Console.ReadLine()?.ToUpper();
                if (!string.IsNullOrEmpty(input) && (input == "Y" || input == "N"))
                {
                    oscillateOption = input[0];
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter Y or N.");
                }
            }
            int fanPowerOutput = baseFanPower * fanSpeed;
          
            if (oscillateOption == 'Y')
            {
                for(int i = 1; i < fanPowerOutput; i++)
                {
                    if (i % 2 != 0)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                          Console.Write("~");
                        }
                    }
                    Console.WriteLine(); 
                    }
                }
          
                for(int i = fanPowerOutput - 1; i >= 1; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write("~");
                    }
                    Console.WriteLine(); 
                    }
                }
            }
            else
            {
                  for (int i = 0; i < fanPowerOutput; i++)