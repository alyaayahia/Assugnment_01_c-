using System;

namespace Assugnment_01_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Question 01
            //Console.WriteLine("Enter your Number:");
            //string Number = Console.ReadLine();
            //Console.WriteLine($"Hello, {Number}!");
            //#endregion
            /////////////////////////////////////////////////////////////////////////////
            //#region  Question 02
            //Console.WriteLine("Enter Your String");
            //string input=Console.ReadLine();

            // try
            //   {
            //    int Number = Convert.ToInt32(input);
            //    Console.WriteLine($"the Conversion is true and Number is {Number}");
            //}

            //catch (FormatException) 
            //{
            //    Console.WriteLine("Error: The string contains non-numeric characters and cannot be converted to an integer.");

            //}
            //#endregion
            /////////////////////////////////////////////////////////////////////////////
            //#region Question 03
            //float Num1 = 5.5f;
            //float Num2 = 3.3f;
            ////Addition
            //Console.WriteLine($"{Num1}  + {Num2} = {Num1 + Num2} ");
            ////substraction
            //Console.WriteLine($"{Num1}  - {Num2} = {Num1 - Num2} ");
            //// Multiplication
            //Console.WriteLine($"{Num1}  * {Num2} = {Num1 * Num2} ");
            ////division
            //Console.WriteLine($"{Num1}  / {Num2} = {Num1 / Num2} ");
            //#endregion
            /////////////////////////////////////////////////////////////////////////////
            //#region  Question 04
            //Console.WriteLine("Enter your string");
            //   string STR = Console.ReadLine();
            //Console.WriteLine("Enter starIndex");
            //int startIndex = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Length");
            //int Length = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(STR.Substring(startIndex, Length));
            //#endregion
            /////////////////////////////////////////////////////////////////////////////
            //#region  Question 05
            //int x = 5;
            //int y = x;
            //////Before Modify
            //Console.WriteLine($"y= {y} , code y ={y.GetHashCode()}");
            //Console.WriteLine($"x= {x} , code x ={x.GetHashCode()}");
            //x = 10;
            //////After Modify
            ///// Console.WriteLine($"y= {y} , code y ={y.GetHashCode()}");
            //Console.WriteLine($"y= {y} , code y ={y.GetHashCode()}");
            //Console.WriteLine($"x= {x} , code x ={x.GetHashCode()}");
            //#endregion
            /////////////////////////////////////////////////////////////////////////////
            //#region  Question 06
            //string Name1 = "Ali";
            //string Name2 = Name1;
            ////////Before Modify
            //Console.WriteLine("///////////////////////Before Modify///////////////////////");
            //Console.WriteLine($"Name1= {Name1} , code Name1 ={Name1.GetHashCode()}");
            //Console.WriteLine($"Name2= {Name2} , code Name2 ={Name2.GetHashCode()}");
            // Name1 = "Ahmed";
            //Console.WriteLine("///////////////////////After Modify///////////////////////");
            ////////After Modify
            //Console.WriteLine($"Name1= {Name1} , code Name1 ={Name1.GetHashCode()}");
            //Console.WriteLine($"Name2= {Name2} , code Name2 ={Name2.GetHashCode()}");
            //#endregion
            /////////////////////////////////////////////////////////////////////////////
            //#region  Question 07
            //Console.WriteLine("please enter str1 string");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("please enter str2 string");
            //string str2 = Console.ReadLine();
            //string combinedString = str1 +" "+ str2;
            //Console.WriteLine($"{combinedString}");
            //#endregion
            /////////////////////////////////////////////////////////////////////////////
            //#region  Question 08
            //Console.WriteLine("Enter your  principal");
            //double.TryParse(Console.ReadLine(), out double principal);
            //Console.WriteLine("Enter your  rate ");
            //double.TryParse(Console.ReadLine(), out double rate);
            //Console.WriteLine("Enter your  time ");
            //double.TryParse(Console.ReadLine(), out double time);
            //double Interest = (principal * rate * time) / 100;
            //Console.WriteLine($"The simple interest is: {Interest}");
            //#endregion

            /////////////////////////////////////////////////////////////////////////////
            //#region  Question 09
            /////BMI = (Weight)/(Height*Height)
            //Console.WriteLine("Enter Your Weight with (kilograms) : ");
            //string input1 = Console.ReadLine();
            //double.TryParse(input1, out double Weight);
            //Console.WriteLine("Enter Your height  with (meters) : ");
            //string input2 = Console.ReadLine();
            //double.TryParse(input2, out double height);
            //double BMI = (Weight) / (height * height);
            //Console.WriteLine($" BML = {BMI:F2} Kilogram/Meter");
            //#endregion
            /////////////////////////////////////////////////////////////////////////////
            //#region  Question 10
            //Console.WriteLine("Please enter the temperature in degrees:");
            //string input = Console.ReadLine();
            //int Temp = Convert.ToInt32(input);
            //Console.WriteLine(Temp >= 30 ? "Just Hot" : (Temp < 10 ? "just cold" : "just Good"));
            //#endregion
            /////////////////////////////////////////////////////////////////////////////
            //#region  Question 11
            //Console.WriteLine("enter your day");
            //int day = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter your Month");
            //int Month = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter your Year");
            //int Year = int.Parse(Console.ReadLine());
            //Console.WriteLine($" Today’s date : {Month} , {day} , {Year} ");
            //Console.WriteLine($" Today's date : {Month} / {day} / {Year} ");
            //Console.WriteLine($" Today's date : {Month} – {day} – {Year} ");
            //#endregion
            /////////////////////////////////////////////////////////////////////////////
            //    #region  Question 12
            //    //12 - What is the output of the following C# code?
            //    DateTime date = new DateTime(2024, 6, 14);
            //    Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            //    ///c)	 The event is on 06/14/2024
            //    #endregion
            /////////////////////////////////////////////////////////////////////////////
            //#region  Question 13
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);
            //Answer =1
            //#endregion

            /////////////////////////////////////////////////////////////////////////////
            //#region  Question 14
            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            //Answer d) 6 1
            //#endregion
            /////////////////////////////////////////////////////////////////////////////
            //#region  Question 15
            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);
            //Answer 7 7
            //#endregion
        }
    }
}
