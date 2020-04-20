using System;

namespace Lab_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            do
            {
                Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");
                Console.WriteLine("Enter Length: ");
                string lengthString = Console.ReadLine();

                Console.WriteLine("Enter Width: ");
                string widthString = Console.ReadLine();

                float lengthFloat = float.Parse(lengthString);
                float widthFloat = float.Parse(widthString);

                float area = lengthFloat + widthFloat;
                float perimeter = (lengthFloat + widthFloat) * 2;

                Console.WriteLine("Area: " + area);
                Console.WriteLine("perimeter: " + perimeter);

                Console.WriteLine("Do you want to continue (y/n)?");
                Console.ReadLine();
            } while (answer == "y");
        }
    }
}
