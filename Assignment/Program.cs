namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 01 Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            //Passing by Value: When a value type parameter is passed by value, a copy of the variable is made and used within the function. Changes to this copy do not affect the original variable.

            //Passing by Reference: When a value type parameter is passed by reference, the reference to the actual variable is passed. Changes to the parameter affect the original variable.

            //Example:
            //static void Main()
            //{

            //    int a = 10;
            //    Console.WriteLine($"Initial value of a: {a}");
            //    PassByValue(a);
            //    Console.WriteLine($"Value of a after PassByValue: {a}");
            //    PassByReference(ref a);
            //    Console.WriteLine($"Value of a after PassByReference: {a}");

            //}
            //    static void PassByValue(int x)
            //    {
            //        x = 20;
            //    }

            //    static void PassByReference(ref int x)
            //    {
            //        x = 30;

            //    }
            #endregion

            #region 02 Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            //Passing by Value: When a reference type parameter is passed by value, the reference (pointer) to the object is copied. The function can modify the object, but not the reference itself.

            //Passing by Reference: When a reference type parameter is passed by reference, the reference to the reference(pointer to the pointer) is passed.The function can modify both the object and the reference.

            //Example:
            //static void Main()
            //{
            //    MyClass obj = new MyClass { Value = 10 };
            //    Console.WriteLine($"Initial value of obj.Value: {obj.Value}");
            //    PassByValue(obj);
            //    Console.WriteLine($"Value of obj.Value after PassByValue: {obj.Value}");
            //    PassByReference(ref obj);
            //    Console.WriteLine($"Value of obj.Value after PassByReference: {obj.Value}");
            //}

            //static void PassByValue(MyClass obj)
            //{
            //    obj.Value = 20;
            //}

            //static void PassByReference(ref MyClass obj)
            //{
            //    obj = new MyClass { Value = 30 };
            //}



            //class MyClass
            //{
            //public int Value { get; set; }
            //}
            #endregion

            #region 03 Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //static void Main()
            //{
            //    Console.Write("Enter first number: ");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.Write("Enter second number: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    (int sum, int difference) = Calculate(num1, num2);
            //    Console.WriteLine($"Sum: {sum}, Difference: {difference}");
            //}

            // static (int, int) Calculate(int a, int b)
            // {
            //    int sum = a + b;
            //    int difference = a - b;
            //    return (sum, difference);
            // }
            #endregion

            #region 04 Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //static void Main()
            //{
            //    Console.Write("Enter first number: ");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.Write("Enter second number: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    (int sum, int difference) = Calculate(num1, num2);
            //    Console.WriteLine($"Sum: {sum}, Difference: {difference}");
            //}

            //static (int, int) Calculate(int a, int b)
            //{
            //    int sum = a + b;
            //    int difference = a - b;
            //    return (sum, difference);
            //}


            #endregion

            #region 05 Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //static void Main()
            //{
            //    Console.Write("Enter a number: ");
            //    int number = int.Parse(Console.ReadLine());
            //    bool isPrime = IsPrime(number);
            //    Console.WriteLine($"{number} is prime: {isPrime}");
            //}

            //static bool IsPrime(int num)
            //{
            //    if (num <= 1) return false;
            //    for (int i = 2; i <= Math.Sqrt(num); i++)
            //    {
            //        if (num % i == 0) return false;
            //    }
            //    return true;
            //}
            #endregion

            #region 06 Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters


            //static void Main()
            //{
            //    int[] numbers = { 3, 5, 7, 2, 8 };
            //    MinMaxArray(numbers, out int min, out int max);
            //    Console.WriteLine($"Minimum: {min}, Maximum: {max}");
            //}

            //static void MinMaxArray(int[] array, out int min, out int max)
            //{
            //    min = array[0];
            //    max = array[0];
            //    foreach (int num in array)
            //    {
            //        if (num < min) min = num;
            //        if (num > max) max = num;
            //    }
            //}
            #endregion

            #region 07 Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //static void Main()
            //{
            //    Console.Write("Enter a number: ");
            //    int number = int.Parse(Console.ReadLine());
            //    int result = Factorial(number);
            //    Console.WriteLine($"Factorial of {number} is: {result}");
            //}

            //static int Factorial(int num)
            //{
            //    int result = 1;
            //    for (int i = 2; i <= num; i++)
            //    {
            //        result *= i;
            //    }
            //    return result;
            //}



            #endregion

            #region 08 Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            //static void Main()
            //{
            //    Console.Write("Enter a string: ");
            //    string str = Console.ReadLine();
            //    Console.Write("Enter the position to change (0-based): ");
            //    int position = int.Parse(Console.ReadLine());
            //    Console.Write("Enter the new character: ");
            //    char newChar = Console.ReadKey().KeyChar;

            //    string modifiedString = ChangeChar(str, position, newChar);
            //    Console.WriteLine($"\nModified string: {modifiedString}");
            //}

            //static string ChangeChar(string str, int position, char newChar)
            //{
            //    if (position < 0 || position >= str.Length)
            //    {
            //        throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range.");
            //    }

            //    char[] charArray = str.ToCharArray();
            //    charArray[position] = newChar;
            //    return new string(charArray);
            //}
            #endregion













        }
    }
}
