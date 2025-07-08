namespace Assignment_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // EXERCISE 1

            // Calculate the area of a triangle
            void triangleArea()
            {
                Console.WriteLine();
                Console.WriteLine("Enter the triangle base length as a number: ");
                double triangleBase = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Enter the triangle height as a number: ");
                double triangleHeight = Convert.ToDouble(Console.ReadLine());


                //Triangle Area
                double triangleArea = 0.5 * triangleBase * triangleHeight;

                Console.WriteLine();
                Console.WriteLine("The area of the triangle is: " + triangleArea);

            }

            triangleArea();

            // Calculate the area of a square
            void squareArea()
            {
                Console.WriteLine();
                Console.WriteLine("Enter the length of one side of the square as a number: ");
                double squareLength = Convert.ToDouble(Console.ReadLine());

                // Square Area
                double squareArea = squareLength * squareLength;

                Console.WriteLine();
                Console.WriteLine("The area of the square is: " + squareArea);
            }

            squareArea();

            // Calculate the area of a rectangle

            void rectangleArea()
            {
                Console.WriteLine();
                Console.WriteLine("Enter the length of the rectangle as a number: ");
                double rectangleLength = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Enter the width of the rectangle as a number: ");
                double rectangleWidth = Convert.ToDouble(Console.ReadLine());

                // Square Area
                double rectangleArea = rectangleLength * rectangleWidth;

                Console.WriteLine();
                Console.WriteLine("The area of the rectangle is: " + rectangleArea);
            }

            rectangleArea();

         // EXERCISE 2

            // Methods of declaring and initializing arrays

            // Declaring a new array with a length of 2 and inputting the values
            int[] numberArray = new int[2] { 1, 2 };
            Console.WriteLine(numberArray.Length);

            // Declaring an array with a lenth of 3 elements without inputting values
            string[] stringArray = new string[3];
            Console.WriteLine(stringArray.Length);

            //
            char[] charArray = {'a','b','c','d'};
           
        }
    }
}
