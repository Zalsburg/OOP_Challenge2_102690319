using System;
using ClassLibrary;
using System.Linq;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            string choice = "";

            while (choice.ToLower() != "f") {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("What would you like to create?");
                Console.WriteLine("a. Square");
                Console.WriteLine("b. Rectangle");
                Console.WriteLine("c. Right Angle Triangle");
                Console.WriteLine("d. Equilateral Triangle");
                Console.WriteLine("e. Circle");
                Console.WriteLine("f. Exit");
                Console.WriteLine();
                Console.Write("Selection: ");

                choice = Console.ReadLine();
                try {
                    Console.WriteLine();
                    if (choice.ToLower() == "a") {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Create Square:");
                        Console.Write("Input Colour: ");
                        string colour = Console.ReadLine();
                        Console.Write("Input Side Length: ");
                        string sideinput = Console.ReadLine();
                        if (sideinput.Contains(".")) {
                            throw new DecimalException("Please input whole number");
                        }
                        int side = int.Parse(sideinput);

                        Square newSquare = new Square(side);
                        newSquare.Colour = colour;

                        Console.WriteLine();
                        Console.WriteLine("Shape Created");
                    }
                    else if (choice.ToLower() == "b") {
                        Console.WriteLine("Create Rectangle:");
                        Console.Write("Input Colour: ");
                        string colour = Console.ReadLine();
                        Console.Write("Input Side Length 1: ");
                        string side1input = Console.ReadLine();
                        if (side1input.Contains(".")) {
                            throw new DecimalException("Please input whole number");
                        }
                        int side1 = int.Parse(side1input);
                        Console.Write("Input Side Length 2: ");
                        string side2input = Console.ReadLine();
                        if (side2input.Contains(".")) {
                            throw new DecimalException("Please input whole number");
                        }
                        int side2 = int.Parse(side2input);

                        Rectangle newRectangle = new Rectangle(side1, side2);
                        newRectangle.Colour = colour;

                        Console.WriteLine();
                        Console.WriteLine("Shape Created");
                    }
                    else if(choice.ToLower() == "c") {
                        Console.WriteLine("Create Right Angle Triangle:");
                        Console.Write("Input Colour: ");
                        string colour = Console.ReadLine();
                        Console.Write("Input Side Length 1: ");
                        string side1input = Console.ReadLine();
                        if (side1input.Contains(".")) {
                            throw new DecimalException("Please input whole number");
                        }
                        int side1 = int.Parse(side1input);
                        Console.Write("Input Side Length 2: ");
                        string side2input = Console.ReadLine();
                        if (side2input.Contains(".")) {
                            throw new DecimalException("Please input whole number");
                        }
                        int side2 = int.Parse(side2input);

                        RightAngle newRightAngle = new RightAngle(side1, side2);
                        newRightAngle.SetHypotenuse();
                        newRightAngle.Colour = colour;

                        Console.WriteLine();
                        Console.WriteLine("Shape Created");
                    }
                    else if (choice.ToLower() == "d") {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Create Equilateral Triangle:");
                        Console.Write("Input Colour: ");
                        string colour = Console.ReadLine();
                        Console.Write("Input Side Length: ");
                        string sideinput = Console.ReadLine();
                        if (sideinput.Contains(".")) {
                            throw new DecimalException("Please input whole number");
                        }
                        int side = int.Parse(sideinput);
                        Equilateral newEquilateral = new Equilateral(side);
                        newEquilateral.Colour = colour;

                        Console.WriteLine();
                        Console.WriteLine("Shape Created");
                    }
                    else if (choice.ToLower() == "e") {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Create Circle:");
                        Console.Write("Input Colour: ");
                        string colour = Console.ReadLine();
                        Console.Write("Input Radius: ");
                        string radiusinput = Console.ReadLine();
                        if (radiusinput.Contains(".")) {
                            throw new DecimalException("Please input whole number");
                        }
                        int radius = int.Parse(radiusinput);
                        Circle newCircle = new Circle();
                        newCircle.Radius = radius;
                        newCircle.Colour = colour;

                        Console.WriteLine();
                        Console.WriteLine("Shape Created");
                    }
                    else {
                        throw new InvalidInputException("Please choose a valid option");
                    }
                }
                catch (FormatException e) {
                    Console.WriteLine("Error: " + e.Message);
                }
                catch (DecimalException e) {
                    Console.WriteLine("Error: " + e.Message);
                }
                catch (InvalidInputException e) {
                    Console.WriteLine("Error: " + e.Message);
                }
                finally {
                    Console.WriteLine();
                }
            }
        }
    }
}
