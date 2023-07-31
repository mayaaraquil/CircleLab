
static void Main(string[] args)
{
    Console.WriteLine("Enter the radius of the circle (a number with decimals please!): ");
    double radius;
    while (!double.TryParse(Console.ReadLine(), out radius))
    {
        Console.WriteLine("oops, Invalid input. Please enter a valid radius:");
    }

    circle circle = new Circle(radius);

    Console.WriteLine("Diameter: " + circle.CalculateDiameter());
    Console.WriteLine("Circumference: " circle.CalculateCircumference());
    Console.WriteLine("Area: " + circle.CalculateArea());

    Console.WriteLine("Do you want the circle to grow? (yes/no)");
    string userInput = Console.ReadLine().ToLower();

    while (userInput == "yes")
    {
        circle.Grow();

        Console.WriteLine("Diameter: " + circle.CalculateDiameter());
        Console.WriteLine("Circumference: " + circle.CalculateCircumference());
        Console.WriteLine("Area: " + circle.CalculateArea());

        Console.WriteLine("Do you want the circle to grow? (yes/no)");
        userInput = Console.ReadLine().ToLower();
    }
    Console.WriteLine("okay! bye bye for now, The final radius of the circle is: " circle.Getradius());
}
