// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
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
namespace ConsoleIO 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello my name is Lilla!");
            Console.Write("Enter you name: ");

            string name;
            name = Console.ReadLine(); // can be 1 line too; string name = Console.Readline();
            // Console.WriteLine(name);

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine(); // these can be in 1 line too; int age = Convert.ToInt32(Console.ReadLine());
            int age = Convert.ToInt32(ageInput);
            // Console.WriteLine(age);

            // Console.Write("Your name is ");
            // Console.Write(name);
            // Console.Write("and your age is ");
            // Console.Write(age + ".");

            Console.Write("Your name is " + name + " and your age is " + age + ".");
            System.Console.WriteLine();

            // == > >= < <= != || &&

            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }
            else 
            {
                if (age >= 18 && age <= 25)
                {
                    Console.WriteLine("You are between 18 and 25!");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("You are 26 or older!");
                }
            }
        
        }
    }
} 