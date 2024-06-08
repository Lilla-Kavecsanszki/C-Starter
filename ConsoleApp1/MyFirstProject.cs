// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;  //this is needed for the Lists and Dictionaries
using System.Globalization;   //this is needed for the currency formatting
using System.Linq;   //this is needed for the sorting of the arrays and lists
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;   //this is needed for the string manipulation and formatting 
using System.Threading.Tasks;   //this is needed for the Thread.Sleep function

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
// namespace PrintingStringInReverse
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             /* Ask user to input message
//                Print in order
//                Print in reverse */

//             Console.WriteLine("Enter a message: ");
//             string message = Console.ReadLine();

//             for (int i = 0; i < message.Length; i++)
//             {
//                 System.Console.Write(message[i]);
//             }

//             System.Console.Write(" - ");

//             for (int i = message.Length -1; i >= 0; i--)
//             {
//                 System.Console.Write(message[i]);
//             }
//         }
//     }
// }


//Exercise 3
// namespace PasswordChecker
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             /* Ask user to enter password, and store,
//                Ask user to enter password again, and store,
//                Check if they are both contain something
//                  If so check if they are the same
//                    if they are, print "Password match"
//                    if they are not print "Password do not match"
//                 If they are empty, print "Please enter a password!" */

//             Console.WriteLine("Enter your password: ");
//             string password = Console.ReadLine();

//             Console.WriteLine("Enter your password again: ");
//             string passwordAgain = Console.ReadLine();

//             if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(passwordAgain))  //would we get the same result if we used .Empty? - yes
//             {
//                 if (password.Equals(passwordAgain))
//                 {
//                     Console.WriteLine("Password match!");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Password do not match!");
//                 }
//             }
//             else
//             {

//                 Console.WriteLine("Please enter a password!");
//             }
            
//         }
//     }
// }


//ARRAYS
// namespace arrays
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
            // int num1 = 5;
            // int num2 = 10;
            // int num3 = 15;
            // int num4 = 30;
            //angles

            // int total = num1 + num2 + num3;

            // int angleSum = angle1 + angle2 + angle3;

            // if (angleSum == 180)
            // {
            //     Console.WriteLine("Valid");
            // }
            // else
            // {
            //     Console.WriteLine("Invalid");
            // }
            // console.writeline(angleSum == 180 ? "valid" : "invalid")

            // const int angleCount = 3;
            // int[] angles = new int[angleCount];  //this is an array of 3 integers

            // for (int i = 0; i < angleCount; i++)
            // {
            //     Console.Write($"Enter angle {i}: ");
            //     angles[i] = Convert.ToInt32(Console.ReadLine());
            // }
            
            // int angleSum = 0;

            // foreach (int angle in angles)
            // {
            //     angleSum += angle;
            // }

            // Console.WriteLine(angleSum);

            // Console.WriteLine(angleSum == 180 ? "valid" : "invalid");

            // int[] numbers = new int[5];  //this is an array of 3 integers

            // Console.Write("Enter a number: ");
            // numbers[0] = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Enter a number: ");
            // numbers[1] = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Enter a number: ");
            // numbers[2] = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Enter a number: ");
            // numbers[3] = Convert.ToInt32(Console.ReadLine());
            
            // Console.Write("Enter a number: ");
            // numbers[4] = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine($"{num1} {num2} {num3}");
            // Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.Write("Enter a number: ");
            //     numbers[i] = Convert.ToInt32(Console.ReadLine());
            // }

            // for (int i = 0; i < numbers.Length; i++)       //here you can make a selection of the numbers you want to go through and itereate 
            // {
            //     Console.WriteLine(numbers[i]);
            // }

            // Console.WriteLine();

            // foreach (int num in numbers)
            // {
            //     Console.WriteLine($"{num} ");    //this is the same as the for loop above, however this solution is 
            //                                     // better if you definitely want to go through all the elements in the array
            // }
//         }
//     }
// }


// Array sorting
// namespace arraySorting
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] numbers = new int[]
//             {
//                 1, 2, 3, 4, 6, 5, 7, 8, 9
//             };

//             string test = "";
//             test.Replace(" ", "");   //this will remove all the spaces from the string 

//             Array.Sort(numbers);  //this will sort the array in ascending order

//             foreach (int num in numbers)
//             {
//                 Console.Write($"{num} ");
//             }
//         }
//     }
// }


// Array reversal
// namespace Reverse
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] numbers = new int[]
//             {
//                 1, 2, 3, 4, 5, 6, 7, 8, 9
//             };

//             Array.Reverse(numbers);

//             foreach (var item in numbers)
//             {
//                 Console.Write($"{item} ");
//             }
//         }

//     }
// }


// Array clearing
// namespace Clear
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] numbers = new int[]
//             {
//                 1, 2, 3, 4, 5, 6, 7, 8, 9
//             };

//             // Array.Clear(numbers, 0, numbers.Length);  //this will clear the array from the 0th element to the end of the array
//             Array.Clear(numbers, 4, 3);    //this will clear 3 following elements of the array from the 4th element (not included) 

//             // for (int i = 0; i < numbers.Length; i++)
//             // {
//             //     numbers[i] = default;         //this will clear the array from the 0th element to the end of the array in the same way as the Array.Clear
//             // }

//             foreach (var item in numbers)
//             {
//                 Console.Write($"{item} ");
//             }
//         }
//     }
// }


// Array IndexOf
// namespace IndexOf
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] numbers = new int[]
//             {
//                 90, 199, 22, 50, 30
//             };

//             System.Console.WriteLine("Enter number to search for: ");
//             int search = Convert.ToInt32(Console.ReadLine());

            // int position = Array.IndexOf(numbers, search);  //the parameters are the array and the value we are looking for
            // int position = Array.IndexOf(numbers, search, 2);   //this will start the search from the 2nd element (as in position) of the array
            // int position = Array.IndexOf(numbers, search, 0, 2);  //this will search for the value in the first 2 elements of the array

            // if (position > -1)
            // {
            //     System.Console.WriteLine($"Number {search} has been found at position {position}.");
            // }
            // else
            // {
            //     System.Console.WriteLine("Not found.");
            // }

            // int position = -1;

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     if (numbers[i] == search)
            //     {
            //         position = i;
            //     }

            //     if (position > -1)
            //     {
            //         System.Console.WriteLine($"Number {search} has been found at position {position}.");
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Not found.");
            //     }
//         }
//     }
// }


// List <>
// namespace List
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] numbers = new int[]
//             {
//                 1, 2, 3
//             };
//             // numbers[0] = 1;
//             // numbers[1] = 2;
//             // numbers[2] = 3;

//             List<int> Listnumbers = new List<int>();

//             // Listnumbers.Add(1);
//             // Listnumbers.Add(2);
//             // Listnumbers.Add(3);

//             for (int i = 0; i < 3; i++)
//             {
//                 Console.Write("Enter a number: ");
//                 // int num = Convert.ToInt32(Console.ReadLine());
//                 // Listnumbers.Add(num);
//                 Listnumbers.Add(Convert.ToInt32(Console.ReadLine()));
//             }

//             for (int i = 0; i < Listnumbers.Count; i++)   //because the List is a dynamic array, we can use the Count property instead of the Length
//                                                           //we dont have its actual length, but we can get the number of elements in the List
//             {
//                 Console.WriteLine(Listnumbers[i]);
//             }

//             Listnumbers.RemoveAt(0);   //this will remove the first element of the List

//             Console.WriteLine();

//             foreach (var item in Listnumbers)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }


// Dictionary
// namespace DictionaryApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
            // Dictionary<int, string> names = new Dictionary<int, string>();

            // names.Add(1, "Lilla");
            // names.Add(2, "Federico");
            // names.Add(3, "Gina");


            // Dictionary<int, string> names = new Dictionary<int, string>
            // {
            //     //KeyValuePair<int, string> pair = new KeyValuePair<int, string>(1, "Lilla");
            //     {1, "Lilla"},
            //     {2, "Federico"},
            //     {3, "Gina"}
            // };

            // // Using foreach loop
            // foreach (var item in names)
            // {
            //     Console.WriteLine($"{item.Key} - {item.Value}");
            // }

            // // Using for loop with ElementAt
            // for (int i = 0; i < names.Count; i++)   //same as Lists, Dictionaries also dont have a fix length, so we can use the Count property
            // {
            //     KeyValuePair<int, string> pair = names.ElementAt(i);   //this will give us the key and the value of the element at the i position
            //     Console.WriteLine($"{pair.Key} - {pair.Value}");

            //     // pair.Key;
            //     // pair.Value;
            // }

//             Dictionary<string, string> teachers = new Dictionary<string, string>
//             {
//                 {"C#", "Lilla"},
//                 {"Java", "Federico"},
//                 {"Python", "Gina"}
//             };

//             teachers.Remove("Java");

//             foreach (var item in teachers)
//             {
//                 Console.WriteLine($"{item.Key} - {item.Value}");
//             }

//             Console.WriteLine(teachers["C#"]);

//             if (teachers.TryGetValue("C#", out string teacher))    //almost like a TryParse, but here we are trying to get the value of the key
//             {
//                 Console.WriteLine(teacher);
//                 teachers["C#"] = "Lilla Szabo";
//             }
//             else
//             {
//                 Console.WriteLine("The C# teacher is not found.");
//             }

//             Console.WriteLine(teachers["C#"]);
//         }
//     }
// }


// Exercise: Odd/ Even Number Split
// namespace Split
// {
//     class Program
//     {
//         /* Create 2 lists with integer data type, one for even numbers, one for odd
//         loop from 0-20
//             if number is even, add to even list
//             if number is odd, add to odd list
//         print even list
//         print odd list */
//         static void Main(string[] args)
//         {
//             List<int> odd = new List<int>();
//             List<int> even = new List<int>();

//             for (int i = 0; i <= 1000; i++)
//             {
//                 if (i % 2 == 0)
//                 {
//                     even.Add(i);
//                 }
//                 else
//                 {
//                     odd.Add(i);
//                 }
//             }

//             System.Console.WriteLine("Printing even numbers: ");

//             foreach (var item in even)
//             {
//                 System.Console.Write($"{item} ");
//             }

//             System.Console.WriteLine();

//             System.Console.WriteLine("Printing odd numbers: ");

//             foreach (var item in odd)
//             {
//                 System.Console.Write($"{item} ");
//             }
//         }
//     }
// }


// Exercise: Array of Multiples
// namespace Multiples
// {
//     class Program
//     {
//         /* Define and initialize 2 integers (num and length)
//            (7, 5) -> [7, 14, 21, 28, 35] 
//            Create int array with size lenght
//            loop through and insert the (loop counter x num) into the array 
//            print the final array */
//         static void Main(string[] args)
//         {
//             int num = 7;
//             int length = 5;
//             int[] result = new int[length];
            
//             int counter = 0;

//             for (int i = 1; i <= result.Length; i++, counter++)
//             {
//                 result[counter] = num * i;
//                 // counter++;
//             }

//             foreach (var item in result)
//             {
//                 System.Console.Write($"{item} ");
//             }
//         }
//     }
// }


// Functions
// namespace Function
// {
//     class Test
//     {
//         public static void something()
//         {
//             System.Console.WriteLine("Hello");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)   //in every .NET framework, every C# application is expected to have a Main function, otherwise it will not run
        // {
            // Test.something();  //this is how we call a function from another class - Test, we could call it this way, because it is a static function and 
                               //we also put the public keyword in front of it

            // Test test = new Test();  //this is how we create an object from a class, we have to put this before calling a function from that class,
            // test.something();        //because it was a void function, as this case we didnt put the static keyword in front of it

//             WelcomeMessage();
//             WelcomeMessage();
//             WelcomeMessage();
//         }

//         static void WelcomeMessage()
//         {
//             System.Console.WriteLine("Welcome Lilla!");
//         }
//     }
// }


// Void Function
// namespace Void
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             bool success = int.TryParse("123", out int result);
//             System.Console.WriteLine(success);  // is this a void function? - no, because it returns(!) a value

//             CreateAndPrintArray();   //this is a void function, because it does not return a (new) value - it just does something
//         }

//         static void CreateAndPrintArray()
//         {
//             int[] numbers = new int[]
//             {
//                 0, 1, 2, 3
//             };

//             foreach (var item in numbers)
//             {
//                 System.Console.WriteLine($"{item} ");
//             }
//         }
//     }
// }


// Return Type Functions
// namespace ReturnType
// {
//     class Program
//     {
//         // static string name = "Lilla";   //this is a global variable, because it is outside of the Main function, 
//                                         //so it can be accessed from anywhere in the class
//         static void Main(string[] args)
//         {
//             Console.Title = $"{ReturnName()} - {ReturnAge()}";  //instead of the global 'name;'   //this will change the title of the console window to the value of the name variable
//             PrintIntroduction();
//         }

//         static string ReturnName()
//         {
//             return "Lilla";   //this is a return type function, because it returns a value
//         }

//         static int ReturnAge()
//         {
//             return 34;
//         }

//         static void PrintIntroduction()
//         {
//             // string name = ReturnName();   //also could be, if we want to store the function in a variable first: string name = name; 
//             // System.Console.WriteLine($"{ReturnName()} - {ReturnAge()}");   //again, instead of the global '(name)'

//             //OR

//             string name = ReturnName();
//             string age = ReturnAge().ToString();  //we have to convert the int to a string, because the WriteLine function only accepts strings
//             string output = $"Hello my name is {name} and my age is {age}.";
//             System.Console.WriteLine(output);

//             System.Console.WriteLine($"Hello my name is {ReturnName()} and my age is {ReturnAge()}."); //this is the same as above, however we can 
//                                                   //simply change the values and avoid repetition - DRY principle 
//         }
//     }
// }


//Function Parameters
// namespace Parameters
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine(Add(5, 10));  //this is how we call a function with parameters, because it takes in values

//             /* System.Console.WriteLine("Enter a number: ");
//             int number = Convert.ToInt32(Console.ReadLine()); */

//             int num = ReadInt("number");  //this is how we call a function with parameters, because it takes in values
//             System.Console.WriteLine(num);

//             int angle = ReadInt("angle");  //What are angles? - angles are the values of the corners of a shape  
//             System.Console.WriteLine(angle);

//             int firstNum = ReadInt("first number");
//             int secondNum = ReadInt("second number");
//             int result = Add(firstNum, secondNum);
//             System.Console.WriteLine(result);
//         }

//         static int ReadInt(string message)
//         {
//             System.Console.WriteLine($"Enter a {message}: ");
//             return Convert.ToInt32(Console.ReadLine());
//         }

//         static int Add(int a, int b)   //this is a function with parameters, because it takes in values
//         {
//             return a + b;
//         }
//     }
// }


//Optional Parameters
// namespace OptionalParameters
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int result = Add(5);
//             System.Console.WriteLine(result);
//         }

        // static int Add(int a, int b = 50)  //this is a function with optional parameters, because it has a default value
                                           //if like above 'b' is not specified in Add's parameters, it will take the default value (50).
        // {
        //     return a + b;
        // }

        // static int Add(int a, [Optional] int b)  //this is a function with optional parameters, because it has a default value
        // static int Add(int a, int b = default)  //exact same as above, but with the default keyword
//         {
//             System.Console.WriteLine($"a: {a}, b: {b}");  //'b' is 0, as a default because it is not specified in the parameters
//             return a + b;
//         }
//     }
// }


//Named Parameters
// namespace NamedParameters
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string nameInput = "Lilla";
//             int ageInput = 34;
//             string addressInput = "Firenze";

//             PrintDetails(name:nameInput, age:ageInput, address:addressInput);
//         }

//         static void PrintDetails(string name, int age, string address)
//         {
//             System.Console.WriteLine($"Name: {name}");
//             System.Console.WriteLine($"Age: {age}");
//             System.Console.WriteLine($"Address: {address}");
//         }
//     }
// }


//Out Parameters
// namespace OutParameters
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int num;
//             bool success = test(out num);  // Using the out parameter to get the value and the success status
//             Console.WriteLine(num);        // Output should be 5
//             Console.WriteLine(success);    // Output should be True

//             // int num = 0;
//             // num = test(num); 
//             // bool success = test(out num);  //out parameters are used when we want to return more than one value from a function. 
//                                         // so both 5 and True in this case are returned from the test function
//             System.Console.WriteLine(num);
//             System.Console.WriteLine(success);

//             List<string> shoppingList = new List<string>
//             {
//                 "Coffee", "Milk"
//             };

//             System.Console.WriteLine(shoppingList.IndexOf("Coffe"));
//             // System.Console.WriteLine(findInList("Milk", shoppingList, out int index));
//             // System.Console.WriteLine(index);

//             System.Console.WriteLine("Enter an item to search for: ");
//             string search = Console.ReadLine();

//             if (findInList(search, shoppingList, out int index))
//             {
//                 System.Console.WriteLine($"Found {search} at index {index}");
//             }
//             else
//             {
//                 System.Console.WriteLine("Not found");
//             }

//             // int index = -1;  //-1 is the default value for the IndexOf function, if the value is not found in the List

//         //     for (int i =0; i < shoppingList.Count; i++)
//         //     {
//         //         if (shoppingList[i].ToLower().Equals("milk"))
//         //         {
//         //             index = i;
//         //         }
//         //     } 
//             // System.Console.WriteLine(index);

//             // bool found = index > -1;
//             // System.Console.WriteLine(found? "Found" : "Not found");
//         }

//         static bool findInList(string s, List<string> list, out int index)
//         {
//             index = -1;

//             for (int i = 0; i < list.Count; i++)
//             {
//                 if (list[i].ToLower().Equals(s.ToLower()))
//                 {
//                     index = i;
//                 }
//             }

//             return index > -1;
//         }

//         static bool TryParse(string s, out int result)
//         {
//             {
//                 result = 0;
//                 return true;
//             }
//         }

//         // static int test(int num)
//         static bool test(out int num)
//         {
//             num = 5;
//             return true;
//         }
//     }
// }


//Reference Parameters
// namespace Ref
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // int num = 10;
//             // Assign(ref num);  //with putting the ref keyword in front of the variable, we are passing the reference of the variable, so the value of the variable can be changed
//             // // num = Assign();

//             // System.Console.WriteLine(num);  //this will print 10, because the value of the variable num is not changed in the Assign function
        
//             string name = "Joe";

//             System.Console.WriteLine("Enter your new name: ");
//             string newName = Console.ReadLine();
            
//             if (ChangeName(ref name, newName))
//             {
//                 System.Console.WriteLine($"Your new name is {name}!");
//             }
//             else
//             {
//                 System.Console.WriteLine("New name cannot be empty or null!");
//             }
//         }

//         static bool ChangeName(ref string name, string newName)
//         {
//             if (!string.IsNullOrEmpty(newName))
//             {
//                 name = newName;
//                 return true;
//             }
//             return false;
//         }

//         static void Assign(ref int num)  
//         {
//         {
//             num = 20;  //when using the ref keyword, you dont necessarily have to assign a value to the variable, can also leave it empty
//             // return 20;
//         }
//         }
//     }
// 


//Exercise Area of a triangle
// namespace Exercise
// {
//     class Program
//     {
//         /* Ask user for width and height, store them
//            Create function to calculate the area
//            (width * height) / 2)
//            Call in main and print out the area of the triangle */
//         static void Main(string[] args)
//         {
//             int width = ReadInt("Enter the width of the triangle: ");
//             int height = ReadInt("Enter the height of the triangle: ");

//             // System.Console.WriteLine(width);
//             // System.Console.WriteLine(height);

//             int area = CalculateArea(width, height);
//             System.Console.WriteLine($"The area of the triangle is {area}.");
//         }

//         static int CalculateArea(int width, int height)
//         {
//             return (width * height) / 2;
//         }

//         static int ReadInt(string message)
//         {
//             System.Console.WriteLine(message);
//             return Convert.ToInt32(Console.ReadLine());
//         }
//     }
// }


//Exercise Sum of Int Array
// namespace Exercise
// {
//     class Program
//     {
        /* Create and initialize an int array of numbers
           Create function with SumOfNumbers with the int return type
           int array param
           function should return total of all numbers
           call in main and output the total
           extra: check array lenght
               - return -1 if array is empty
               - check return in main and output message
               - do we need to return -1, how else can we solve this? */
//         static void Main(string[] args)
//         {
//             int[] numbers = new int[]  //int[] numbers = new int[0];  <- this would be an empty array, will return -1
//             {
//                 1, 2, 3, 4, 5
//             };

//             int result = SumOfNumbers(numbers);

//             if (result > -1)
//             {
//                 System.Console.WriteLine($"The total is {result}.");
//             }
//             else
//             {
//                 System.Console.WriteLine("Cannot add up an empty array!");
//             }

//             if (SumOfNumbers(numbers, out int total))
//             {
//                 System.Console.WriteLine($"The total is {result}.");
//             }
//             else
//             {
//                 System.Console.WriteLine("Cannot add up an empty array!");
//             }

//             // System.Console.WriteLine($"The total is {SumOfNumbers(numbers)}.");
//         }

//         static int SumOfNumbers(int[] numbers)
//         {
//             if (numbers.Length > 0)
//             {
//                 int total = 0;

//             foreach (var item in numbers)
//             {
//                 total += item;
//             }

//             return total;
//             }

//             return -1;
//         }

//         static bool SumOfNumbers(int[] numbers, out int total)
//         {
//             total = 0;

//             if (numbers.Length > 0)
//             {
//             foreach (var item in numbers)
//             {
//                 total += item;
//             }

//             return true;
//             }

//             return false;
//         }
//     }
// }


//Exeption Handling
// namespace Exeptions
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //system.formatexception
//             //system.overflowexception

//             bool looping = true;

//             while (looping)
//             {
//                 try
//                 {
//                     System.Console.WriteLine("Enter a number: ");
//                     int num = Convert.ToInt32(Console.ReadLine());
//                     System.Console.WriteLine(num);
//                     looping = false;
//                 }
//                 catch (FormatException e)
//                 {
//                     System.Console.WriteLine($"Error: {e.Message}");
//                 }
//                 catch (OverflowException)
//                 {
//                     System.Console.WriteLine("Number is too large or too small!");
//                 }
//                 catch (Exception e) //e for exeption, is a local variable, we can name it anything, it holds the exeption message
//                 {
//                     // e.Message;   <- this is the message of the exeption, a feature of the exeption
//                     System.Console.WriteLine($"Error: {e.Message}");  //this will print out the error message, always according to and 
//                                                                      //specifically about the exeption, the current case.
//                 }
//             }

//             System.Console.WriteLine("Goodbye!");
//         }
//     }
// }


//Exercise: Custom TryParse
// namespace CustomTryParse
// {
//     class Program
    // {
        /* Create an int and try convert any string to an int
        Notice the error, write a try..catch handle around it
        Catch the error and output the error message
        Without changing the current code
        
        Why is this a bad situation, and how do we know if it's been converted?
        
        Create a custom try parse function
        Find the real function and and copy return type / params
        Read the tooltip it gives you, to give you ideas on what to do */
        // static void Main(string[] args)
        // {
            // bool success = false;

            //     try
            //     {
            //         System.Console.WriteLine("Enter a number: ");
            //         int num = Convert.ToInt32(Console.ReadLine());
            //         success = true;
            //     }
            //     catch (FormatException e)
            //         {
            //             System.Console.WriteLine($"Error: {e.Message}");
            //         }
            //     catch (Exception e)
            //     {
            //         System.Console.WriteLine($"Error: {e.Message}");
            //     }
            
            // System.Console.WriteLine(success ? "Yay" : "Oh no");

//             System.Console.WriteLine("Enter a number: ");
//             if (TryParse(Console.ReadLine(), out int result))  //what does this line mean? - it is calling the TryParse function, and if the 
//                                                               //TryParse function returns true, it will store the value in the result variable
//                                                               //okay, where is the true part? - the true part is in the TryParse function, if the 
//                                                               //this out int result here, is instead of a Console.ReadLine, so it is the value that is returned from the TryParse function
//             {
//                 System.Console.WriteLine("Yay " + result);
//             }
//             else
//             {
//                 System.Console.WriteLine("Oh no!");
//             }
//         }

//         static bool TryParse(string input, out int result)  //would it work the same if we say static int TryParse(string input, out int result)  //no, because we want to return a bool value, so we can check if the function was successful or not 
//         {
//             result = -1;
//             try{
//                 result = Convert.ToInt32(input);
//                 return true;
//             }
//             catch (FormatException)
//             {
//                 // result = -1;  <- this assignment could be here also, the point is to have an assignment for both cases
//                 return false;
//             }
//         }
//     }    
// }


//Debugging
// namespace Debugging
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int age = 34;
//             if (age > 18)
//             {
//                 System.Console.WriteLine(("18+ "));
//             }
//             else if (age > 30)
//             {
//                 System.Console.WriteLine("35+ ");
//             }
//         }
//     }
// }


//Object Oriented Programming 
//Structures - they store data, but they are value types, so they are stored in the stack. They can store different types of data in one structure
//what is the equivalent of a struct in JavaScript? - an object, and in Python? - a dictio
//but then what is the equivalent of a dictionary in pyth
// so both C# struct and dictionary are equivalent to a Python dictionary? 
// namespace Structures
// {
//     class Program
//     {
//         struct Person 
//         {
//             public string name;  //with the public keyword, we can access the name variable from outside of the struct, otherwise we could not if it's private
//             public int age;
//             public int birthMonth;

//             public Person(string name, int age, int birthMonth)  //this is a constructor, it is a function that is called when we create an instance of the struct
//             {
//                 this.name = name;  //this keyword is a reference to the current instance of the struct, 
//                                     //so it is referring to the global variables above, not the local one inside this function
//                 this.age = age;
//                 this.birthMonth = birthMonth;
//             }
//         }
//         static void Main(string[] args)
//         {
//             string name = "Lilla";
//             int age = 34;

            // Person person;  //created an instance of the struct. Instance is an object of the struct - basically a variable of the struct
            // person.name = "Lilla";
            // person.age = 34;
            // person.birthMonth = 5;

            // System.Console.WriteLine($"{name} - {age}");  //these are coming from the local variables above

            // string newName = ReturnPerson(out int newAge);  
            // System.Console.WriteLine($"{newName} - {newAge}");  //due to created instance of the struct, these are also local variables

        //     Person person = ReturnPerson();
        //     System.Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");  //these are coming from the struct
        // }

        // static string ReturnPerson(out int age)  //string function with an out parameter that is going to return an integer
        // {
        //     Person person;
        //     person.name = "Lilla";
        //     person.age = 34;
        //     person.birthMonth = 5;

        //     age = person.age;  //this is the out parameter, because we want to return the value of the age variable

        //     return person.name;  //this is the return value of the function
        // }
        // {
        //     System.Console.WriteLine("Enter your name: ");  //this is the local variable
        //     string name = Console.ReadLine();

        //     System.Console.WriteLine("Enter your age: ");
        //     age = Convert.ToInt32(Console.ReadLine());   //this is the out parameter, because we want to return the value of the age variable

        //     return name;   //this is the return value of the function
        // }

        // static Person ReturnPerson()
        // {
        //     System.Console.WriteLine("Enter your name: ");  
        //     string name = Console.ReadLine();

        //     System.Console.WriteLine("Enter your age: ");
        //     int age = Convert.ToInt32(Console.ReadLine());

        //     System.Console.WriteLine("Enter your birth month: ");
        //     int birthMonth = Convert.ToInt32(Console.ReadLine());

            /* Person person;  

            person.name = name;
            person.age = age;
            person.birthMonth = birthMonth;

            return person; */
//             return new Person(name, age, birthMonth);  //this is the same as above, but it is more common to use this way, because it is more readable
//         }
//     }
// }


// Classes
// namespace Constructor
// {
//     class Program
//     {
//         // struct Person
//         // {
//             // public string name;
//             // public int age;

//             // public Person(string name, int age)
//             // {
//             //     this.name = name;
//             //     this.age = age;
//             // }

//             class Person
//             {
//                 public string name;
//                 public int age;

//                 public Person()
//                 {}

//                 public Person(string name)
//                 {
//                     this.name = name;
//                     this.age = -1;
//                 }

//                 public Person(int age)
//                 {
//                     this.age = age;
//                     this.name = "";
//                 }

//                 public Person(string name, int age)
//                 {
//                     this.name = name;
//                     this.age = age;
//                 }
//             }
//         static void Main(string[] args)  
//         {
//             System.Console.WriteLine("Enter your name: ");
//             string name = Console.ReadLine();  
//             System.Console.WriteLine("Enter your age: ");
//             int age = Convert.ToInt32(Console.ReadLine());

//             Person person = new Person(name, age);
//             System.Console.WriteLine($"{person.name} - {person.age}");

//             if (!string.IsNullOrEmpty(person.name))  //then it's not empty
//             {
//                 System.Console.WriteLine(person.name);  
//             }
//             if (person.age > -1)
//             {
//                 System.Console.WriteLine(person.age);
//             }
//         }
//     }
// }


//Class Functions
// namespace ClassFunctions
// {
//     class Program
//     {
//         //keep all related functions in the same class, and inside the class.. not separated underneath the Main function
//         class Person{
//             public string name;
//             public int age;

//             public Person(string name, int age)
//             {
//                 this.name = name;
//                 this.age = age;
//             }

//             public string ReturnDetails()
//             {
//                 return $"Name: {name}\nAge: {age}";
//             }
//         }

//         static void Main(string[] args)
//         {
//             Person person = new Person("Lilla", 34);
//             // System.Console.WriteLine($"Name: {person.name}/nAge: {person.age}");
//             System.Console.WriteLine(ReturnDetails(person));
//             System.Console.WriteLine(person.ReturnDetails());  //this is calling the function from the class directly (the person class)
//         }

//         // static string ReturnDetails(string name, int age)
//         // {
//         //     return $"Name: {name}/nAge: {age}";
//         // }

//         static string ReturnDetails(Person person)
//         {
//             return $"Name: {person.name}\nAge: {person.age}";
//         }
//     }
// }


//Class Fields
// namespace ClassFields
// {
//     class Program
//     {
//         //keep all related functions in the same class, and inside the class.. not separated underneath the Main function
//         class Person{
//             private string name;  //this is a global variable within this class, can also be called a field
//                                   //can global variables always be called a field, in every situation? - no, only in classes
//             private int age;

//             public Person(string name, int age)  //is this a constructor? - yes, because it is a function that is called when we create an instance of the class
//             {
//                 this.name = name;
//                 this.age = age;
//             }

//             public void SetName(string name)  //this is a function that sets the value of the name variable.
//                                               //setter fucntion is needed here, because the name variable is private, so we cannot access it from outside of the class
//             {
//                 if (!string.IsNullOrEmpty(name))
//                 {
//                     this.name = name;  //this is the reference to the name variable in the class (the private one) to make it accessible from outside of the class
//                 }
//                 else
//                 {
//                     this.name = string.Empty;   // = ""; or "Invalid name"   <- so if it is empty, it will not assign the new value to the name variable but keep it empty
//                 }
//             }

//             public void SetAge(int age)
//             {
//                 // if (age > 0 && age < 150)
//                 // {
//                 //     this.age = age;
//                 // }
//                 // else{
//                 //     this.age = -1;  //just so we know that it is a bad value
//                 // }

//                 //with conditional operator
//                 this.age = (age > 0 && age < 150) ? age : -1;
//             }

//             public string GetName()    //this is a function that returns the value of the name variable
//             {
//                 return name;
//             }

//             // public int GetAge()
//             // {
//             //     return age;;
//             // }

//             //with am arow function
//             public int GetAge() => /*return*/ age;  //when using an arrow function, we put everything from the {} after the arrow, 
//                                                     //with the arrow f. we also cannot use the return keyword, because it is implicit, so simply write the value

//             public string ReturnDetails()
//             {
//                 return $"Name: {name}\nAge: {age}";
//             }
//         }

//         static void Main(string[] args)
//         {
//             Person person = new Person("Lilla", 34);
//             System.Console.WriteLine(person.ReturnDetails());  //this is calling the function from the class directly (the person class)

//             // person.name = "Federico";  //here we can also reassign the value of variables in the class
//             // person.age = 35;
//             person.SetName("Federico");  //this is how we can change the value of the name variable, because it is private, through the setter function (in the class)
//             person.SetAge(200);
//             System.Console.WriteLine(person.ReturnDetails());

//             System.Console.WriteLine($"Your name is {person.GetName()} and your age is {person.GetAge()}.");  //this is how we can get the value of the name variable, because it is private, through the getter function (in the class)
//         }
//     }
// }

//Class variable/ function scope 
//what is the scope of the variables in the class? - the scope of the variables in the class is the class itself, 
//so they can be accessed from anywhere in the class, but not from outside of the class, unless they are public or we use getter and setter functions
//if i want to access and use a variable from another scope, in a different function, then I have to pass the variable as a parameter to the new function
//if i want a variable to be accessable throughout the whole class, then i have to declare it on the top of the class, outside of any function
//in case there are 2 variables with the same name in the class, the one that is declared in the function will be used, because it is the closest to the function
//in other words, the program will always prioritize local variables over global variables
//compile error - when the code is not correct, so it cannot be compiled, so it will not run


//Class Properties
namespace Properties
{
        class Person{
            private string name;  
                                  
            private int age;

            public string Name  //this is a property, it is a special type of function that is used to access a private field and
                                 //behave as new middle men, completely replace the getter and setter functions
                                //  {
                                //     get {
                                //         return name;  //this is the getter function, it is used to get the value of the name variable
                                //     }
                                //     set {
                                //         name = value;  //give it (set) it to value, which is the value that is passed to the property, and a convention to use value
                                //                        //we dont have to specify the type of the value, because it is the same as the type of the property, or its actual value either
                                //     }
                                //  }
                                {
                                    get => name;  //this is the same as above, but with arrow functions
                                    set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name";  
                                }
            public int Age
            {
                // get {
                //     return age;
                // }
                // set {
                //     age = value;
                // }

                get => age;
                set => age = value >= 0 && value < 150 ? value : -1;
            }

            //with arrow functions
            // public string Name {get => name; set => name = value; }  //this is the same as above, but with arrow functions
            // public int Age {get => age; set => age = value; }

            public Person(string name, int age)  //is this a constructor? - yes, because it is a function that is called when we create an instance of the class
                                                 //constructor is a special type of function that is used to initialize the object, so it is called when we create an instance of the class
            {
                // this.name = name;
                // this.age = age;

                Name = name;  //this is how we can access the private field through the property
                Age = age;
            }
        }

        class Program    //this is also a class, so we can have multiple classes in one file, but only one of them can be public
                         //also only one can have the Main function, because it is the entry point of the program, this class
                         //always have to be called Program, because it is the entry point of the program, convention
        {
            static void Main(string[] args)
            {
                Person person = new Person("Lilla", 34);   //so here 'Person' is an object of the class 'Person' so we can access the properties of the class through this object
                
                person.Name = "Federico";  //this is how we can change the value of the name variable, because it is private, through the property (in the class)   
                person.Age = 35;
                System.Console.WriteLine(person.Name);
                System.Console.WriteLine($"Your name is {person.Name} and your age is {person.Age}."); 
            }
        }
        
}


//Auto Properties

namespace Auto
{
    class Person
    {
        public string Name { get; set; }  //this is an auto property, it is a property that does not have a private field, so it is automatically created
                                         //it is a shorthand for the property, so it is a property that does not have a private field, so it is automatically created, 
                                         //behaves like a private field

        //means the same as if we typed this: public string Name {get => name; set => name = value;}
        public int Age { get; set; }
    }
}