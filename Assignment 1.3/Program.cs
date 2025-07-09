// NOTE: All exercises for assignment 1.3 are written in this code.
// Each exercise operates independently from each
// For testing purposes you can comment out exercises if needed to help improve readability



namespace Assignment_1._3
{
    internal class Program
    {
      // EXERCISE 1 FUNCTIONS/METHODS:


        // Calculate the area of a triangle
        static void triangleArea()
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

        // Calculate the area of a square
        static void squareArea()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the length of one side of the square as a number: ");
            double squareLength = Convert.ToDouble(Console.ReadLine());

            // Square Area
            double squareArea = squareLength * squareLength;

            Console.WriteLine();
            Console.WriteLine("The area of the square is: " + squareArea);
        }

        // Calculate the area of a rectangle
        static void rectangleArea()
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


       // EXERCISE 3 FUNCTIONS/METHODS:


        // To loop through any passed int array
        static void printArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }

        // To display the array in reverse with a loop
        static void reverseArrayWithLoop(int[] array)
        {
            Console.WriteLine("Lets display your array in reverse using a loop\n");
            Console.WriteLine("Here is your current array: \n");
            printArray(array);

            Console.WriteLine("\nHere is your array displayed reversed: \n");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }

        // To reverse the array with .Reverse method
        static void reverseArrayWithMethod(int[] array)
        {
            Console.WriteLine("\nNow here is your array reversed with the \".Reverse\" method\n");
            Array.Reverse(array);
            printArray(array);
        }


      // MAIN CODE/METHOD


        static void Main(string[] args)
        {
          // EXERCISE 1:

            triangleArea();
            squareArea();
            rectangleArea();


          // EXERCISE 2:


            // Methods of declaring and initializing arrays
            // Declaring a new array
            bool[] boolArray;

            // Assigning values to the boolArray
            boolArray = new bool[] { true };

            // Declaring a new array with a length of 2 and inputting the values
            int[] numberArray = new int[2] { 1, 2 };
            Console.WriteLine(numberArray.Length);

            // Declaring an array with a length of 3 elements without inputting values
            string[] stringArray = new string[3];
            Console.WriteLine(stringArray.Length);

            // Declaring an array with input values but no set length
            char[] charArray = { 'a', 'b', 'c', 'd' };


          // EXERCISE 3:


            // I will first print the array in reverse without using array methods
            // I will also use array methods to reverse the list

            Console.WriteLine("Input a number to determine the length of an array");
            int[] userInputArray = new int[Convert.ToUInt32(Console.ReadLine())];

            Console.WriteLine("\nYou input a length of: " + userInputArray.Length + "\n");

            Console.WriteLine("Now Input numbers into each the array\n");

            for (int i = 0; i < userInputArray.Length; i++)
            {
                Console.WriteLine("Assign a number at element " + i +":");
                userInputArray[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nYou input number: " + userInputArray[i] + " at element: " + i + "\n");
            }

            
            reverseArrayWithLoop(userInputArray);
            reverseArrayWithMethod(userInputArray);
        }
    }
}
