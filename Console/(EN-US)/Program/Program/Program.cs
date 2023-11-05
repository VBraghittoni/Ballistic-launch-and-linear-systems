using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLinearELancamentoBalistico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 1 to solve linear systems or 2 for ballistic projectile calculations.");
            string choice = Console.ReadLine();

            // Electrical:
            if (choice == "1")
            {
                Console.WriteLine("Solving systems of linear equations for electrical circuits");

                Console.Write("How many equations do you want to input? ");
                int numEquations = int.Parse(Console.ReadLine());

                Console.WriteLine("Note: The coefficient of the form A[k][k] (row = column) must be different from 0. \nSo, the nth equation should not have its nth coefficient as zero.\n Enter your equations in an order that satisfies this requirement.");

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

                // Solving the system of equations using Gaussian elimination
                for (int i = 0; i < numEquations; i++)
                {
                    double pivot = system[i, i];
                    if (pivot == 0)
                    {
                        Console.WriteLine("The pivot cannot be zero.\n One of two situations occurred: \n1- Some coefficient in the form A[k][k] was set to 0 \n2- Your equations had redundant information \nThe program will exit.");
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
                    Console.WriteLine("Enter the value of the horizontal distance to the target (X) in meters: ");
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
                    Console.WriteLine("Enter the value of the vertical distance to the target (H) in meters: ");
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
                Console.WriteLine($"Based on the given distances, we know that the angle value must be \nless than (π/2) radians = 90° \ngreater than: {minRadians} OR radians = {minDegrees}°.");

                Console.WriteLine("Enter 1 to input the angle in radians and 2 to input the angle in degrees: ");
                string choice2 = Console.ReadLine();

                while (true)
                {
                    if (choice2 == "1")
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

                double time = Math.Sqrt(((x * Math.Sin(angleRadians) / Math.Cos(angleRadians)) - h) / (g / 2));
                double initialVelocity = x / (Math.Cos(angleRadians) * time);

                Console.WriteLine("The required initial velocity is {0} m/s, and the time for it to occur is {1} s\n\nThe equation representing this motion is y = x*({2}) + x^2*({3})", time, initialVelocity, (Math.Sin(angleRadians) / Math.Cos(angleRadians)), (-g / (2 * initialVelocity * initialVelocity * Math.Cos(angleRadians) * Math.Cos(angleRadians))));

                double initialVerticalVelocity = initialVelocity * Math.Sin(angleRadians);

                if ((initialVerticalVelocity - g * time) > 0)
                {
                    Console.WriteLine("Considering such velocity, the projectile will be rising when it hits the target.");
                }
                if ((initialVerticalVelocity - g * time) == 0)
                {
                    Console.WriteLine("Considering such velocity, the projectile will be at its peak when it hits the target.");
                }
                if ((initialVerticalVelocity - g * time) < 0)
                {
                    Console.WriteLine("Considering such velocity, the projectile will be falling when it hits the target.");
                }
            }

            Console.ReadKey();
        }
    }
}

