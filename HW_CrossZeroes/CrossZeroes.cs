using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CrossZeroes
{
    internal class CrossZeroes
    {
        string[,] array = new string[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        string signPerson;
        string signComputer;
        int xPossition;
        int yPossition;
        public CrossZeroes()
        {
            Console.Write("Enter your sign x or o: ");
            signPerson = Console.ReadLine();
            while (true)
            {
                if (signPerson == "x" || signPerson == "o")
                {
                    FreeSpace();
                    Console.Write("Enter your value X position: ");
                    try
                    {
                        xPossition = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Enter integer number in range: from 0 to 2: ");
                        xPossition = int.Parse(Console.ReadLine());
                    }
                    Console.Write("Enter your value Y position: ");
                    try
                    {
                        yPossition = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Enter integer number in range: from 0 to 2: ");
                        yPossition = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("-----------------");
                    if (xPossition >= 0 && xPossition < 3 && yPossition >= 0 && yPossition < 3)
                    {
                        if (array[xPossition, yPossition] == " ")
                        {
                            array[xPossition, yPossition] = signPerson;
                        }
                        DisplayArray();
                        Console.WriteLine("Computer turn");
                        ComputerTurn();
                        Console.WriteLine("--------------");
                        DisplayArray();
                        IsVictory();
                    }
                    else
                    {
                        Console.WriteLine("Enter free space coordinates");
                        if (array[xPossition, yPossition] == " ")
                        {
                            array[xPossition, yPossition] = signPerson;
                        }
                        DisplayArray();
                        IsVictory();
                    }
                }
                else
                {
                    Console.WriteLine("Just x or o signs are avaliavble");
                    Console.Write("Enter your sign x or o: ");
                    signPerson = Console.ReadLine();
                }
            }
        }
        public void FreeSpace()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == " ")
                    {
                        Console.WriteLine("Empty space is: " + i + " " + j);
                    }
                }
            }
        }
        public void DisplayArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void IsVictory()
        {
            if (array[0,0] == signPerson && array[1, 0] == signPerson && array[2, 0] == signPerson || array[0, 0] == signComputer && array[1, 0] == signComputer && array[2, 0] == signComputer)
            {
                if(array[0, 0] == signPerson && array[1, 0] == signPerson && array[2, 0] == signPerson)
                {
                    Console.WriteLine("Person won");
                    Environment.Exit(0);
                }else if(array[0, 0] == signComputer && array[1, 0] == signComputer && array[2, 0] == signComputer)
                {
                    Console.WriteLine("Computer won");
                    Environment.Exit(0);
                }
            }
            else if (array[0, 1] == signPerson && array[1, 1] == signPerson && array[2, 1] == signPerson || array[0, 1] == signComputer && array[1, 1] == signComputer && array[2, 1] == signComputer)
            {
                if (array[0, 1] == signPerson && array[1, 1] == signPerson && array[2, 1] == signPerson)
                {
                    Console.WriteLine("Person won");
                    Environment.Exit(0);
                }
                else if (array[0, 1] == signComputer && array[1, 1] == signComputer && array[2, 1] == signComputer)
                {
                    Console.WriteLine("Computer won");
                    Environment.Exit(0);
                }
            }
            else if (array[0, 2] == signPerson && array[1, 2] == signPerson && array[2, 2] == signPerson || array[0, 2] == signComputer && array[1, 2] == signComputer && array[2, 2] == signComputer)
            {
                if (array[0, 2] == signPerson && array[1, 2] == signPerson && array[2, 2] == signPerson)
                {
                    Console.WriteLine("Person won");
                    Environment.Exit(0);
                }
                else if (array[0, 2] == signComputer && array[1, 2] == signComputer && array[2, 2] == signComputer)
                {
                    Console.WriteLine("Computer won");
                    Environment.Exit(0);
                }
            }
            else if(array[0, 0] == signPerson && array[1, 1] == signPerson && array[2, 2] == signPerson || array[0, 0] == signComputer && array[1, 1] == signComputer && array[2, 2] == signComputer)
            {
                if (array[0, 0] == signPerson && array[1, 1] == signPerson && array[2, 2] == signPerson)
                {
                    Console.WriteLine("Person won");
                    Environment.Exit(0);
                }
                else if (array[0, 0] == signComputer && array[1, 1] == signComputer && array[2, 2] == signComputer)
                {
                    Console.WriteLine("Computer won");
                    Environment.Exit(0);
                }
            }
            else if (array[0, 2] == signPerson && array[1, 1] == signPerson && array[2, 0] == signPerson || array[0, 2] == signComputer && array[1, 1] == signComputer && array[2, 0] == signComputer)
            {
                if (array[0, 2] == signPerson && array[1, 1] == signPerson && array[2, 0] == signPerson)
                {
                    Console.WriteLine("Person won");
                    Environment.Exit(0);
                }
                else if (array[0, 2] == signComputer && array[1, 1] == signComputer && array[2, 0] == signComputer)
                {
                    Console.WriteLine("Computer won");
                    Environment.Exit(0);
                }
            }
            else if (array[0, 0] == signPerson && array[0, 1] == signPerson && array[0, 2] == signPerson || array[0, 0] == signComputer && array[0, 1] == signComputer && array[0, 2] == signComputer)
            {
                if (array[0, 0] == signPerson && array[0, 1] == signPerson && array[0, 2] == signPerson)
                {
                    Console.WriteLine("Person won");
                    Environment.Exit(0);
                }
                else if (array[0, 0] == signComputer && array[0, 1] == signComputer && array[0, 2] == signComputer)
                {
                    Console.WriteLine("Computer won");
                    Environment.Exit(0);
                }
            }
            else if (array[1, 0] == signPerson && array[1, 1] == signPerson && array[1, 2] == signPerson || array[1, 0] == signComputer && array[1, 1] == signComputer && array[1, 2] == signComputer)
            {
                if (array[1, 0] == signPerson && array[1, 1] == signPerson && array[1, 2] == signPerson)
                {
                    Console.WriteLine("Person won");
                    Environment.Exit(0);
                }
                else if (array[1, 0] == signComputer && array[1, 1] == signComputer && array[1, 2] == signComputer)
                {
                    Console.WriteLine("Computer won");
                    Environment.Exit(0);
                }
            }
            else if (array[2, 0] == signPerson && array[2, 1] == signPerson && array[2, 2] == signPerson || array[2, 0] == signComputer && array[2, 1] == signComputer && array[2, 2] == signComputer)
            {
                if (array[2, 0] == signPerson && array[2, 1] == signPerson && array[2, 2] == signPerson)
                {
                    Console.WriteLine("Person won");
                    Environment.Exit(0);
                }
                else if (array[2, 0] == signComputer && array[2, 1] == signComputer && array[2, 2] == signComputer)
                {
                    Console.WriteLine("Computer won");
                    Environment.Exit(0);
                }
            }
        }
        public void ComputerTurn()
        {
            if(signPerson == "x")
            {
                signComputer = "o";
                Random random = new Random();
                int xRandom = random.Next(0, 3);
                int yRandom = random.Next(0, 3);
                if (array[xRandom, yRandom] == " ")
                {
                    array[xRandom, yRandom] = signComputer;
                }else if (array[xRandom, yRandom] != " ")
                {
                    xRandom = random.Next(0, 3);
                    yRandom = random.Next(0, 3);
                    if (array[xRandom, yRandom] == " ")
                    {
                        array[xRandom, yRandom] = signComputer;
                    }
                }
                else
                {
                    xRandom = random.Next(0, 3);
                    yRandom = random.Next(0, 3);
                    if (array[xRandom, yRandom] == " ")
                    {
                        array[xRandom, yRandom] = signComputer;
                    }
                }
            }
            else if(signPerson == "o")
            {
                signComputer = "x";
                Random random = new Random();
                int xRandom = random.Next(0, 3);
                int yRandom = random.Next(0, 3);
                if (array[xRandom, yRandom] == " ")
                {
                    array[xRandom, yRandom] = signComputer;
                }
                else if (array[xRandom, yRandom] != " ")
                {
                    xRandom = random.Next(0, 3);
                    yRandom = random.Next(0, 3);
                    if (array[xRandom, yRandom] == " ")
                    {
                        array[xRandom, yRandom] = signComputer;
                    }
                }
                else
                {
                    xRandom = random.Next(0, 3);
                    yRandom = random.Next(0, 3);
                    if (array[xRandom, yRandom] == " ")
                    {
                        array[xRandom, yRandom] = signComputer;
                    }
                }
            }
        }
    }
}
