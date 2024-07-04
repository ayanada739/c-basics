using System;

class program()
{

static void Main()
    {
        #region Casting [Boxing - UnBoxing]
        // Boxing => Casting From Value Type To Reference Type
        // Unboxing => Casting From Reference Type To Value Type

        #region EX01
        //object O1;
        //O1 = "Aya"; // Casting [Reference Type]
        //O1 = 1;       // Casting [Value Type -> Reference Type] Boxing
        //O1 = 'A';     // Casting [Value Type -> Reference Type] Boxing
        //O1 = new Employee(); // Casting
        #endregion

        #region EX02
        //int X = 10;
        //object obj = X; // Boxing [Safe Casting]

        // obj = new object(10); 
        // Parent => Child
        // Animal => Dog (Dog is an Animal)

        //object obj02 = 10;
        //int Y = (int)obj02; // Casting Unboxing [UnSafe Casting]
        //Invalid Cast Exception
        //New object (10) -> 10
        //Dog = (Dog) Animal (Animal Is A Dog)
        //Child = (Child) Parent

        //Console.WriteLine(Y);
        #endregion


        #endregion






    }




}