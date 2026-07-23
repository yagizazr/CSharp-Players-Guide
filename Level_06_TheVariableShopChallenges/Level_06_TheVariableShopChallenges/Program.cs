using System;

namespace Level_06_TheVariableShopChallenges
{

    class Program
{
        static void Main(string[] args)
        {
            // Declaring and initializing 
            sbyte mySByte = 100;
            short myShort = 32_767;
            int myInt = 2_147_483_647;
            long myLong = 9_223_372_036_854_775_807;
            byte aByte = 255;
            ushort myUShort = 65_535;
            uint myUInt = 4_294_967_295
            ulong myULong = 18_446_744_073_709_551
            float myFloat = 3.402823E+38f
            double myDouble = 1.798623157E+308
            decimal myDecimal = 79228337593543950335m
            char myChar = 'O';
            string myString = "ILOB";
            bool myBool = true;



            //Updating values
            mySByte = -100;
            myShort = -2;
            myInt = 0103;
            myLong = -9_223_372_036_854_775_807;
            aByte = 0;
            myUShort = 1;
            myUInt = 0; 
            myULong = 0;
            myFloat = 0;
            myDouble = 0;
            myDecimal = 0;
            myChar = 'B';
            myString = "ILOBSM";
            bool myBool = false;



            // Display
            Console.WriteLine(mySByte);
            Console.WriteLine(myShort);
            Console.WriteLine(myInt);
            Console.WriteLine(myLong);
            Console.WriteLine(aByte);
            Console.WriteLine(myUShort);
            Console.WriteLine(myUInt);
            Console.WriteLine(myULong);
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myDecimal);
            Console.WriteLine(myChar);
            Console.WriteLine(myString);
            Console.WriteLine(myBool);


            Console.ReadKey();

        }
    }

}