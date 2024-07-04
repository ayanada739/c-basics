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











    }
    }
}
