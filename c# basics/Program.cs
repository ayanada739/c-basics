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


        #region Nullable Type

        #region EX01


        // Null As a Value Is Valid Only With Reference Type

        // int X = null; // Invalid
        // int X => X Allow Only int Numbers

        // int? Y = null; // Valid
        // int? Y => Y Allow Int Values + Null

        // int? Y = null;
        //int X = 10;
        //int? Z = Y; //InValid
        //int? Z = X; //Valid

        //int? Number; //Nullable <int> Number;
        //Nullable --> Allow Null + Values

        //decimal Num01 = 1.1M;
        //decimal Num02 =Num01;

        //decimal? Num01 = null;
        //decimal? Num02 = null;


        //Console.WriteLine(X);
        //Console.WriteLine(Y);

        #endregion

        #region EX02

        //int x = 10;
        //int? y = /*int?*/ x; //Valid implicit casting
        //                     //safe casting

        //int? Number01 = null;
        //int Number02 = (int)Number01; //Explicit Casting
        //                              //UnSafe Casting
        //                              //InValid Operation Exception

        //Console.WriteLine(Number02);
        #endregion

        #region EX03

        // int? K = null;

        // int l;
        //l= (int)K; -->UnSafe
        //if (K != null)
        // {
        //   l = (int)K; //Casting

        //  }
        // else
        // {
        //     l = 0; 
        // }

        ////////////////////////////

        //if (K.HasValue)
        //{
        //    l = K.Value; //not Casting

        //}
        //else
        //{
        //  l = 0;

        //}
        ///////////////////////////

        //l = K.HasValue ? K.Value: 0;
        //l = K != null ? (int) K: 0;

        #endregion

        #region Reference Type

        //Null Is Default Value Of Reference Type

        #region EX01
        //string Messege = "Hi";
        //Message = null; //Valid With Warning
        //Message = null; //! --> Null Forgiveness Operator

        //string? Message02 = null; //Valid Without warning
        #endregion


        #endregion

        #endregion



    }




}