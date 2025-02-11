﻿using System.Globalization;

namespace Assignment
{
 
    {
        #region Functions


        #region Passing Parameters

        #region Passing Value Type Parameters
        //int , Double , Char
        //int a = 10;
        //int b = 20;

        //Console.WriteLine($"A = {a}");
        //Console.WriteLine($"B = {b}");
        //SWAP(ref a,ref b); // By Ref
        //Console.WriteLine("Swap");
        //Console.WriteLine($"A = {a}");
        //Console.WriteLine($"B = {b}");








        #endregion

        #region Reference Type Parameters

        //int[] Numbers = null;
        //// Numbers --> Reference[Address Of Array]
        //int Result = SumArray(Numbers); // By Value
        //Console.WriteLine(Result); //105
        ////Console.WriteLine(Numbers[0]);

        #endregion



        #endregion
        #endregion

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


        #region Null Propagation Operator ?

        //int[] Numbers = default; // Null
        //Null Reference Exception

        // for (int i = 0;(Numbers != null) && ( i < Numbers.Length); i++)
        //for (int i = 0; i < Numbers?.Length; i++);

        //if (Numbers != null)
        //{
        //for (int i = 0; i < Numbers.Length; i++)
        //     Console.WriteLine(Numbers[i]);
        //}
        //  


        //Numbers !=null
        // i< Numbers.length


        //Numbers?.Length
        //Numbers = null -->> (Numbers.Length)=>null
        //Numbers != null -->> (Numbers?.Length)=>Length



        static void SWAP( ref int x , ref int y)
        {
          int Temp = x;
          x = y;
          y = Temp;

        }

        static int SumArray(int[] Arr) //Arr = Numbers
        {
            int Sum = 0;
            if(Arr is not null)
            {
                Arr[0] = 100;
                for (int i = 0; i < Arr.Length; i++)
                    Sum += Arr[i];
                
            }
            return Sum;

        }


        static void Main(string[] args)
        {
            #region Functions


              #region Passing Parameters

                #region Passing Value Type Parameters
            //int , Double , Char
            //int a = 10;
            //int b = 20;

            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");
            //SWAP(ref a,ref b); // By Ref
            //Console.WriteLine("Swap");
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");








            #endregion

                #region Reference Type Parameters

            //int[] Numbers = null;
            //// Numbers --> Reference[Address Of Array]
            //int Result = SumArray(Numbers); // By Value
            //Console.WriteLine(Result); //105
            ////Console.WriteLine(Numbers[0]);
            
            #endregion



              #endregion
            #endregion


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

            #region Null Propagation Operator ?

            //int[] Numbers = default; // Null
            //Null Reference Exception

            // for (int i = 0;(Numbers != null) && ( i < Numbers.Length); i++)
            //for (int i = 0; i < Numbers?.Length; i++);

            //if (Numbers != null)
            //{
            //for (int i = 0; i < Numbers.Length; i++)
            //     Console.WriteLine(Numbers[i]);
            //}
            //  


            //Numbers !=null
            // i< Numbers.length


            //Numbers?.Length
            //Numbers = null -->> (Numbers.Length)=>null
            //Numbers != null -->> (Numbers?.Length)=>Length



        #endregion

            #endregion







        }
}
}