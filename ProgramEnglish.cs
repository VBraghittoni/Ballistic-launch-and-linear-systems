using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSystemAndBallisticLaunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alert: Keep your units to yourself. We will find results in the units you input.\n\n");
            Console.WriteLine("Enter 1 to solve linear systems or 2 for ballistic launch.");
            string option1 = Console.ReadLine();

            // Electrical:
            if (option1 == "1")
            {
                Console.WriteLine("Solving linear equation systems for electrical multiloops");

                Console.Write("How many equations do you want to enter? ");
                int numEquations = int.Parse(Console.ReadLine());

                Console.WriteLine("Note: The coefficient in the form A[kk] (row = column) must not be zero.\nTherefore, the nth equation should not have its nth coefficient as zero.\nEnter your equations in an order that satisfies this requirement.");

                Console.WriteLine("Place your equations in the format:\n A11.x + A12.y = A13\n A21.x + A22.y = A23");

                double[,] system = new double[numEquations, numEquations + 1];

                for (int i = 0; i < numEquations; i++)
                {
                    for (int j = 0; j < numEquations + 1; j++)
                    {
                        Console.Write($"Enter the value of coefficient A[{i + 1}{j + 1}]: ");
                        system[i, j] = double.Parse(Console.ReadLine());
                    }
                }

                // Solving the equation system using Gaussian elimination
                for (int i = 0; i < numEquations; i++)
                {
                    double pivot = system[i, i];
                    if (pivot == 0)
                    {
                        Console.WriteLine("The pivot cannot be zero.\nOne of two situations occurred:\n1- Some coefficient in the form A[kk] was set to 0\n2- Your equations had redundant information\nThe program will terminate.");
                        Console.ReadKey();
                        return;
                    }

                    for (int j = i; j < numEquations + 1; j++)
                    {
                        system[i, j] /= pivot;
                    }

                    for (int k = 0; k < numEquations; k++)
                    {
                        if (k != i)
                        {
                            double factor = system[k, i];
                            for (int j = i; j < numEquations + 1; j++)
                            {
                                system[k, j] -= factor * system[i, j];
                            }
                        }
                    }
                }

                // Display the solutions
                Console.WriteLine("\nSolution:");
                for (int i = 0; i < numEquations; i++)
                {
                    Console.WriteLine($"A[{i + 1}] = {system[i, numEquations]:F4}");
                }
            }

            // Physics:
            else
            {
                double x = 0;
                double h = 0;
                double g = 9.8;

                while (true)
                {
                    Console.WriteLine("Enter the horizontal distance to the target (X): ");
                    try
                    {
                        x = Convert.ToSingle(Console.ReadLine());
                        if (x > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The value must be greater than 0. Please try again.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("The value is not a number. Please try again.");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter the vertical distance to the target (H): ");
                    try
                    {
                        h = Convert.ToSingle(Console.ReadLine());
                        if (h > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The value must be greater than 0. Please try again.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("The value is not a number. Please try again.");
                    }
                }

                double minRadians = Math.Atan(h / x);
                double minDegrees = (minRadians * 180) / Math.PI;
                double angleRadians;
                Console.WriteLine($"Based on the provided distances, we know that the angle value should be\nless than (π/2) radians = 90° and greater than: {minRadians} radians = {minDegrees}°.");

                Console.WriteLine("Enter 1 to input the angle in radians and 2 to input the angle in degrees: ");
                string option2 = Console.ReadLine();

                while (true)
                {
                    if (option2 == "1")
                    {
                        Console.WriteLine("Enter the angle in radians: ");
                        double attempt = Convert.ToSingle(Console.ReadLine());
                        if (minRadians < attempt && attempt < (Math.PI / 2))
                        {
                            angleRadians = attempt;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid angle. Please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter the angle in degrees: ");
                        double attempt = Convert.ToSingle(Console.ReadLine());
                        if (minDegrees < attempt && attempt < 180)
                        {
                            angleRadians = Math.PI * attempt / 180;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid angle. Please try again.");
                        }
                    }
                }

                double t = Math.Sqrt(((x * Math.Sin(angleRadians) / Math.Cos(angleRadians)) - h) / (g / 2));
                double v0 = x / (Math.Cos(angleRadians) * t);

                Console.WriteLine("The required initial velocity is {0}, and the time it takes to reach the target is {1}\n\nThe equation representing this motion is y = x*({2}) + x^2*({3})", t, v0, (Math.Sin(angleRadians) / Math.Cos(angleRadians)), (-g / (2 * v0 * v0 * Math.Cos(angleRadians) * Math.Cos(angleRadians))));

                double v0y = v0 * Math.Sin(angleRadians);

                if ((v0y - g * t) > 0)
                {
                    Console.WriteLine("Considering this velocity, the projectile will be rising when it hits the target");
                }
                if ((v0y - g * t) == 0)
                {
                    Console.WriteLine("Considering this velocity, the projectile will be at its peak when it hits the target");
                }
                if ((v0y - g * t) < 0)
                {
                    Console.WriteLine("Considering this velocity, the projectile will be falling when it hits the target");
                }
            }

            Console.ReadKey();
        }
    }
}
