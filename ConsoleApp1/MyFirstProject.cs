// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace HelloWorld
// {

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello, World!");
//         }
//     }
// }


// namespace DataTypes
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // int x = 10;
//             // int y = 20;
//             // int z = 30;

//             // int x = 10;
//             //     y = 20;
//             //     z = 30;


//             int age = -23;
//             Console.WriteLine(age);
//             Console.WriteLine(int.MaxValue);
//             Console.WriteLine(int.MinValue);

//             long bigNum = -900000000L;
//             Console.WriteLine(bigNum);
//             Console.WriteLine(long.MaxValue);
//             Console.WriteLine(long.MinValue);

//             double negative = -55.2D;
//             Console.WriteLine(negative);
//             Console.WriteLine(double.MaxValue);
//             Console.WriteLine(double.MinValue);

//             float precision = 5.000001F;
//             Console.WriteLine(precision);
//             Console.WriteLine(float.MaxValue);
//             Console.WriteLine(float.MinValue);

//             decimal money = 14.99M;
//             Console.WriteLine(money);
//             Console.WriteLine(decimal.MaxValue);
//             Console.WriteLine(decimal.MinValue);

//             age = 50;
//             Console.WriteLine(age);
//         }
//     }
// }


// namespace String_Chars
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string name = "Lilla";
//             char letter = 'g';

//             Console.Write("Your name is ");
//             Console.Write(name);
            
//             Console.WriteLine();
//             Console.WriteLine(letter);
//         }
//     }
// }

// Convert strings to numbers, integers

// namespace DataTypes
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string textAge = "-23";
//             int age = Convert.ToInt32(textAge);
//             Console.WriteLine(age);

//             string textBigNumber = "-900000000";
//             long bigNum = Convert.ToInt64(textBigNumber);
//             Console.WriteLine(bigNum);

//             string textNegative = "-55.2";
//             double negative = Convert.ToDouble(textNegative);
//             Console.WriteLine(negative);

//             string textPrecision = "5.000001";
//             float precision = Convert.ToSingle(textPrecision);
//             Console.WriteLine(precision);

//             string textMoney = "14.99";
//             decimal money = Convert.ToDecimal(textMoney);
//             Console.WriteLine(money);
//         }
//     }
// }


// namespace Bool
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             bool value = true;
            
//             bool isMale = true;
//             Console.WriteLine(isMale);

//             isMale = false;
//             Console.WriteLine(isMale);
//         }
//     }
// }


// namespace Operators
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
            // int age = 23;
            
            // age++;
            // // age = age + 1;
            // // age += 1;
            // Console.WriteLine(age);

            // age--;
            // Console.WriteLine(age);

            // age += 10;
            // Console.WriteLine(age);

            // age -= 10;
            // Console.WriteLine(age);

            // age *= 2;
            // Console.WriteLine(age);

//             double age = 23;
//             // + - * /
//             age /= 10; //2.3 -> 2
//             Console.WriteLine(age);

//             string name = "Lilla";
//             name += " is programming";

//             char ch = 'a';
//             ch += 'b';
//             Console.WriteLine(ch);

//             Console.WriteLine(name);

//             int i = 0;
//             // i++;
//             // Console.WriteLine(i);

//             Console.WriteLine(i++); //0
//             Console.WriteLine(i);

//         }
//     }
// }


// Remainder

// namespace Modulus
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var firstNum = 10;
//             int secondNum = 3;

//             Console.WriteLine(firstNum / secondNum); //3

//             Console.WriteLine(firstNum % secondNum); //1 - the remainder as 3*3 = 9, 10-9 = 1
//         }
//     }
// } 


// Constants - VAR (variable but only if you sure in the data type) CONST cannot be changed
// namespace Constants 
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             const int vat = 20;
//             const double percentVAT = vat / 100D;

//             int balance = 1000;

//             Console.WriteLine(balance * percentVAT); 

//             Console.WriteLine(vat); 
//         }
//     }
// } 


// odd even checker exercise
// namespace Constants 
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int num1 = 10;   //declaring a variable with int etc...
//             int num2 = 2;
//             int remainder = num1 % num2;
//             System.Console.WriteLine(remainder);

//             num1 = 11;       //no need for the int, as now we are reassigning the variable
//             remainder = num1 % num2;
//             System.Console.WriteLine(remainder);
            
//         }
//     }
// } 


//Console input/Output
// namespace ConsoleIO 
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
            // Console.WriteLine("Hello my name is Lilla!");
            // Console.Write("Enter you name: ");

            // string name;
            // name = Console.ReadLine(); // can be 1 line too; string name = Console.Readline();
            // // Console.WriteLine(name);

            // Console.Write("Enter your age: ");
            // string ageInput = Console.ReadLine(); // these can be in 1 line too; int age = Convert.ToInt32(Console.ReadLine());
            // int age = Convert.ToInt32(ageInput);
            // // Console.WriteLine(age);

            // // Console.Write("Your name is ");
            // // Console.Write(name);
            // // Console.Write("and your age is ");
            // // Console.Write(age + ".");

            // Console.Write("Your name is " + name + " and your age is " + age + ".");
            // System.Console.WriteLine();

            // == > >= < <= != || &&

            // if (age < 0 || age > 150)
            // {
            //     Console.WriteLine("Invalid age!");
            // }
            // else 
            // {
            //     if (age >= 18 && age <= 25)
            //     {
            //         Console.WriteLine("You are between 18 and 25!");
            //     }
            //     else if (age >= 26)
            //     {
            //         Console.WriteLine("You are 26 or older!");
            //     }
            // }

//             Console.Write("Enter the first number: ");
//             string numberAInput = Console.ReadLine();
//             int numberA = Convert.ToInt32(numberAInput);

//             Console.Write("Enter the second number: ");
//             string numberBInput = Console.ReadLine();
//             int numberB = Convert.ToInt32(numberBInput);

//             int answer = numberA * numberB;
//             Console.Write("Value of " + numberA + " x " + numberB + ": ");
//             string answerInput = Console.ReadLine();
//             int actualAnswer = Convert.ToInt32(answerInput);

//             if (answer == actualAnswer)  //=!
//             {
//                 Console.WriteLine("Correct, well done!");
//             }
//             else //if (answer != actualAnswer)   - this is not needed, as basically given
//             {
//                 Console.WriteLine("Incorrect!");
//             }
        
//         }
//     }
// } 


// Switch statement
// namespace ConsoleIO 
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter a day (number) of the week; ");
//             int day = Convert.ToInt32(Console.ReadLine());

            // if (day == 1)
            // {
            //     Console.WriteLine("Monday");
            // }
            // else if (day == 2)
            // {
            //     Console.WriteLine("Tuesday");
            // }
            // else if (day == 3)
            // {
            //     Console.WriteLine("Wednesday");
            // }
            // else if (day == 4)
            // {
            //     Console.WriteLine("Thursday");
            // }
            // else if (day == 5)
            // {
            //     Console.WriteLine("Friday");
            // }
            // else if (day == 6)
            // {
            //     Console.WriteLine("Saturday");
            // }
            // else if (day == 7)
            // {
            //     Console.WriteLine("Sundays");
            // }
            // else
            // {
            //     Console.WriteLine("Invalid, please enter a number between 1 and 7.");
            // }

//             switch (day)
//             {
//                 case 1: Console.WriteLine("Monday");
//                     break;
//                 case 2: Console.WriteLine("Tuesday");
//                     break;
//                 case 3: Console.WriteLine("Wednesday");
//                     break;
//                 case 4: Console.WriteLine("Thursday");
//                     break;
//                 case 5: Console.WriteLine("Friday");
//                     break;
//                 case 6: Console.WriteLine("Saturday");
//                     break;
//                 case 7: Console.WriteLine("Sunday");
//                     break;
//                 default: Console.WriteLine("Invalid, please enter a number between 1 and 7.");
//                     break;
//             }
//         }
//     }
// }


// For loop
// namespace For 
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             /* Console.Write("Hi");
//             Console.Write("Hi");
//             Console.Write("Hi");
//             Console.Write("Hi");
//             Console.Write("Hi"); */

//             Console.Write("What do you want to repeat?: ");
//             string messageInput = Console.ReadLine();
//             string message = messageInput + " ";

//             Console.WriteLine("How many times do you want to repeat it?: ");
//             int loopTimes = Convert.ToInt32(Console.ReadLine());
            

//             if (loopTimes <= 0)
//             {
//                 Console.Write("Please enter a value above 0");
//             }
//             else //>= 1
//             {
//                 for (int i = 0; i < loopTimes; i++)
//                 {
//                     Console.Write(message);
//                 }

//             // for (int i = 0; i <= 10; i += 2)
//             // {
//             //     Console.Write(i);
//             // }
//             }
//         }
//     }
// }


// While loop
// namespace While 
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // for (int i = 0; i < 10; i++)  //  <-- the for loop
//             // {
//             //     Console.Write(i);
//             // }

//             // int i = 0;  // the variable needs to be outside the while loop, where we define it
//             // while (i < 10) // i < 10 is the condition - only that we have inside the while loop
//             // {
//             //     Console.Write(i);
//             //     i++;  // the third part is inside the {}
//             // }   

//             Console.Write("Enter the first number: ");
//             string numberAInput = Console.ReadLine();
//             int numberA = Convert.ToInt32(numberAInput);

//             Console.Write("Enter the second number: ");
//             string numberBInput = Console.ReadLine();
//             int numberB = Convert.ToInt32(numberBInput);

//             int answer = numberA * numberB;
//             int actualAnswer = 0;

//             Console.Write("What's the value of " + numberA + " x " + numberB + "?");
//             Console.WriteLine();

//             while (answer != actualAnswer)
//             {
//                 Console.WriteLine("Enter your answer: ");
//                 string answerInput = Console.ReadLine();
//                 actualAnswer = Convert.ToInt32(answerInput);

//                 if (answer != actualAnswer) 
//                 {
//                     Console.WriteLine("Incorrect!");
//                 }
//             }
//             Console.WriteLine("Well done!");
//         }
//     }
// }

// do while loop is pretty much the same, however the do while loop will always run at least for the first time, even if the condition is not met, as it checks that after the loop is executed. the while loop checks the condition first, and only runs if the condition is met. 


// Conditional operators
// namespace ConditionalOperator
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int age = -10;

//             // if (age >= 0)  <-- the condition
//             // {
//             //     Console.WriteLine("Valid");
//             // }
//             // else
//             // {
//             //     Console.WriteLine("Invalid");
//             // }

//             // condition ? true : false
//             string result = age >= 0 ? "Valid" : "Invalid";
//             Console.WriteLine(result);
//         }
//     }
// }


// Numeric Formatting
// namespace Format
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             double value = 1000D / 12.34D;
//             Console.WriteLine(value);
//             // Console.WriteLine(string.Format("{0} {1}", value, 1000));
//             Console.WriteLine(string.Format("{0:0.00}", value));
//             Console.WriteLine(string.Format("{0:0}", value));
//             Console.WriteLine(string.Format("{0:0.0}", value));
//             Console.WriteLine(string.Format("{0:0.#}", value));  //removes trailing 0s .. in case if that digit would be a 0 of course
//             Console.WriteLine(string.Format("{0:0.00}", value));

//             double money = -10D / 3D;  //3.3333333333333335
//             Console.WriteLine(money);
//             Console.WriteLine(string.Format("£{0:0.00}", money));

//             Console.WriteLine(string.Format("-£10 / £3 = £{0:0.00}", money));
//             Console.WriteLine(money.ToString("C"));    //currency format
//             Console.WriteLine(money.ToString("C0"));   //no decimal places
//             Console.WriteLine(money.ToString("C1"));   //1 decimal place
//             Console.WriteLine(money.ToString("C2"));   //2 decimal places

//             Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));    //currency format - whatever is set up on the laptop that is used
//             Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
//             Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
//             Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("eu-DE")));
//         }
//     }
// }


//TryParse
// namespace tryParse
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             bool success = true;

//             while (success)
//             {
//                 Console.WriteLine("Enter a number: ");
//                 string numInput = Console.ReadLine();
//                 // int num = Convert.ToInt32(numInput);
//                 // int num = 0;  //in case the TryParse is used

//                 // Console.WriteLine(num);   // this cannot deal with the clien accidentally entering a letter, as it will crash the program

//                 // bool success = int.TryParse(numInput, out num);  //this will put the value of numInput into num without the above conversion, and if the user enters a letter, it will alo not crash.

//                 if (int.TryParse(numInput, out int num))   //we integrated this line in the condition: int num = 0;
//                 {
//                     success = false;       //this will stop the loop
//                     Console.WriteLine(num);
//                 }
//                 else
//                 {
//                     Console.WriteLine("Failed to convert!");
//                 }

//             }
            
//         }
//     }
// }

//First Exercise
// namespace TimesTable
// {

//     class Program
//     {
//         /* Ask the user for a number for the table
//            Write a for loop to print x times table */
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a number for the table: ");
//             int number = Convert.ToInt32(Console.ReadLine());

//             for (int i = 1; i <= 10; i++)
//             {
//                 Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
//             }
//         }
//     }
// }


//Fizz Buzz Game
// namespace FizzBuzz
// {

//     class Program
//     {
//         /* Create a for loop from 1 to x (15)
//            3 and 5 FizzBuzz
//            3 = Fizz
//            5 = Buzz
//            else = number */
//         static void Main(string[] args)
//         {
//             for (int i = 1; i <= 100; i++)
//             {
//                 //9 % 3 = 0
//                 if (i % 3 == 0 && i % 5 == 0)
//                 {
//                     Console.WriteLine("FizzBuzz");
//                 }
//                 else if (i % 3 == 0)
//                 {
//                     Console.WriteLine("Fizz");
//                 }
//                 else if (i % 5 == 0)
//                 {
//                     Console.WriteLine("Buzz");
//                 }
//                 else
//                 {
//                     Console.WriteLine(i);
//                 }  
//             }
//         }
//     }
// }


//Verbatim string literal (@) and String Formatting
// namespace Output
// {

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // \t \n \" \\ = \ - these are a escape characters, so to see 1 \ in the console, we need to write 2 \\

//             string path = "C:\\Program Files\\Microsoft\\"; //this is the normal way to write a path
//             string speech = "He said \"something\"";  // in the console it will show: He said "something"

//             // $ + {variable} - this is the way to write a variable in a string
//             // $ "Your name is {name}"
//             // "Your name is " + name  - this is the old way to write a variable in a string

//             path = @"C:\Program Files\Microsoft\" + "\nNew line test";   // if we use the @ - we have to separate the escape characters
//             string text = @"Hello ""someone""";

//             Console.WriteLine(path);
//             Console.WriteLine(speech);
//             Console.WriteLine(text);

//             string name = "Lilla";
//             int age = 34;

//             Console.WriteLine("Your name is {0} and your age is {1}.", name, age);
//             Console.WriteLine("Name: {0}\nAge: {1}", name, age);
//         }
//     }
// }


//String Interpolation
// namespace Interpolation
// {

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string name = "Lilla";
//             int age = 34;

//             Console.WriteLine("Your name is " + name + " and your age is " + age + ".");
//             Console.WriteLine("Your name is {0} and your age is {1}.", name, age);

//             Console.WriteLine($"Your name is {name} and your age is {age}.");
//         }
//     }
// }

//String Concatenation
// namespace Concatenation
// {

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string name = "Lilla";
//             int age = 34;

//             Console.WriteLine("Your name is " + name + " and your age is " + age + ".");
//             Console.WriteLine("Your name is {0} and your age is {1}.", name, age);
//             Console.WriteLine($"Your name is {name} and your age is {age}.");

//             string test = string.Concat("Your name is ", name, " and your age is ", age, ".");
//             System.Console.WriteLine(test);

//             string[] names = new string[] { "Lilla ", "Federico ", "Gina "};
//             System.Console.WriteLine(string.Concat(names));

//         }
//     }
// }


//Empty String 
// namespace Empty
// {

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // string name = "";
//             // System.Console.WriteLine(name);

//             System.Console.Write("Enter your name: ");
//             string name = Console.ReadLine();

//             if (name != string.Empty)   //string.Empty is the same as ""
//             {
//                 System.Console.WriteLine($"Your name is {name}.");
//             }
//             else
//             {
//                 System.Console.WriteLine("Name is empty!");
//             }
//         }
//     }
// }


//String Equals function 
// namespace Equals
// {

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string message = "Hello";
//             string compare = "Hello";

//             if (message.Equals(compare))  //(message == compare)  <-- same thing
//             {
//                System.Console.Write("Same");
//             }
//             else
//             {
//                 System.Console.Write("Different");
//             }

//             System.Console.WriteLine("Enter your name: ");
//             string name = Console.ReadLine();

//             if (!name.Equals(""))   //.Equals checks the value only but == checks the value and the reference also, its place in the memory.
//                                     //    Therefore, it is better to use .Equals, as == can give us confusing or false results. if we compare 
//                                     // an object with a string, even though their value is the same, the == will return false, as they are
//                                     // in different places in the memory.
//             {
//                 System.Console.WriteLine($"Your name is {name}.");
//             }
//             else
//             {
//                 System.Console.WriteLine("Name is empty!");
//             }
//         }
//     }
// }


//String Iteration Looping 
// namespace Loop
// {

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string message = "C# is awesome!";
//             //char[]
//             // System.Console.WriteLine(message);
//             // System.Console.WriteLine(message[0]);  //C
//             // System.Console.WriteLine(message[1]);  //#
//             // System.Console.WriteLine(message[2]);  //(space)
//             // System.Console.WriteLine(message[3]);  //i

//             for (int i = 0; i < message.Length; i ++)
//             {
//                 System.Console.WriteLine(message[i]);
//                 Thread.Sleep(250);   //1000ms = 1 second
//             }
//             Console.WriteLine();
//             Console.WriteLine(message.Contains("C"));  //True

//             bool contains = false;

//             for (int i = 0; i < message.Length; i++)
//             {
//                 if (message[i].Equals('C'))
//                 {
//                     contains = true;
//                 }
//             }

//             Console.WriteLine(contains);
//         }
//     }
// }


//String is Null or Empty function
// namespace InNullOrEmpty
// {

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Enter your name: ");
//             string name = Console.ReadLine();

//             Console.WriteLine($"Your name is {name}.");

//             if (name != "")
//                 System.Console.WriteLine("0");

//             if (!name.Equals(""))
//                 System.Console.WriteLine("1");

//             if (!string.IsNullOrEmpty(name))    //null or "" - the best way to check if a string is empty and also without the 
//                                                 // possibility to crash
//                 System.Console.WriteLine("2");
//         }
//     }
// }


//Exercise 2
namespace PrintingStringInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ask user to input message
               Print in order
               Print in reverse */

            Console.WriteLine("Enter a message: ");
            string message = Console.ReadLine();

            for (int i = 0; i < message.Length; i++)
            {
                System.Console.Write(message[i]);
            }

            System.Console.Write(" - ");

            for (int i = message.Length -1; i >= 0; i--)
            {
                System.Console.Write(message[i]);
            }
        }
    }
}