using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program.takeInput();
            //Program.calcFunc();
            validate();
            userArray();

        }
        public static void takeInput() {
            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];



            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    Console.Write(arr[i] + " ");
            }

            Console.Write("\nEven numbers: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.Write(arr[i] + " ");
            }
        }
        static void calcFunc()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Write("Enter a number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter another number: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.Write("Enter an operator (+, -, *, /): ");
                string op = Console.ReadLine();

                double result = 0;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operator!");
                        break;
                }

                Console.WriteLine($"Result: {result}");

                Console.Write("Press 'Q' to quit or any key to continue: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    exit = true;
                }

                Console.WriteLine();
            }
        }
        
      private static void userArray()
        {
        Console.WriteLine("enter the dataype to be inserted");
         string dt=Console.ReadLine();
        Console.WriteLine("enter the size of array");
         int size = Convert.ToInt32(Console.ReadLine());
        if(dt=="int"){
                int[] arr=new int[size];
        for(int i = 0; i < size; i++)
                {
                    arr[i]=Convert.ToInt32(Console.ReadLine());
                }
        }
            if (dt == "float")
            {
                float[] arr = new float[size];
                for (int i = 0; i < size; i++)
                {
                    arr[i] = (float)Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        private static void validate()
        {
            Console.WriteLine("enter the date of joining in the form of dd-MM-yy");
            DateTime date = DateTime.Parse(Console.ReadLine());
            if (date.Month > 13)
            {
                Console.WriteLine("invalid");
            }
            else if (date.Month == 2 && date.Day > 28)
            {
                Console.WriteLine("invalid");
            }
            else if(date.Year< 2000 & date.Year>2050)
            {
                Console.WriteLine("invalid");
            }
            else if(date.Day > 31)
            {
                Console.WriteLine("invalid");
            }
            else
            {
                Console.WriteLine("valid date");
            }
            
        }
               
        }


    }





    

    
        
  


