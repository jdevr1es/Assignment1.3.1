namespace Assignment13._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            string readResult = "";
            do
            {
                Console.WriteLine("Please enter your choice from the menu");
                Console.WriteLine("Enter T for Triangle");
                Console.WriteLine("Enter S for Square");
                Console.WriteLine("Enter R for Rectangle");
                Console.WriteLine();
                Console.WriteLine("Enter X to Exit program");

                readResult = Console.ReadLine();


                switch (readResult)
                {
                    case "T":
                    case "t":
                        Console.WriteLine("Enter length of base of triangle");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter height of triangle");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Area of the Triangle is " + AreaOfTriangle(width, height));
                        Console.WriteLine();
                        break;
                    case "S":
                    case "s":
                        Console.WriteLine("Enter length of side of square");
                        double side = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Area of the Square is " + AreaOfSquare(side));
                        Console.WriteLine();
                        break;
                    case "R":
                    case "r":
                        Console.WriteLine("You want to Multiply");
                        break;
                    case "X":
                    case "x":
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            }
            while (readResult != "X" && readResult != "x");
        }

        static double AreaOfTriangle(double width, double height)
        {
            return (width * height) / 2;
        }

        static double AreaOfSquare(double side)
        {
            return side * side;
        }

    }
}
