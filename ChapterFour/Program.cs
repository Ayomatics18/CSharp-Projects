﻿using System;

namespace ChapterFour
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            //Write a program that reads from the console three numbers of type int and prints their sum.
            Console.Write("Enter the first value: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second value: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third value: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2 + num3;
            Console.WriteLine($"The sum of {num1},{num2} and {num3} is {sum}");
            Console.WriteLine("===== Question 2 ====");
            //Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
            Console.WriteLine("Enter the value of the radius");
            int radius = Convert.ToInt32(Console.ReadLine());
            double area = Math.PI * radius * radius;
            double perimeter = 2 * Math.PI * radius * radius;
            Console.WriteLine($"The value of the area of the circle is {area}");
            Console.WriteLine($"The value of the perimeter of the circle is {perimeter}");
            //Question 3
            /*A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number.
            Write a program that reads information about the company and its manager and then prints it on the console.*/
            //Question 4
            /*Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters 
            and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional 
            positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.*/
            Console.WriteLine("Enter any Hexa number");
            string hexaNum = Console.ReadLine();
            Console.WriteLine("Enter positive fraction number");
            double positiveFractionNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter negative fraction number");
            double negativeFractionNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("|0 {0,-8:X}|", hexaNum);
            Console.WriteLine("|{0,-10:f2}|", positiveFractionNumber);
            Console.WriteLine("|{0,-10:f2}|", negativeFractionNumber);
            Console.WriteLine("===== Question 5 =====");
            /*Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the
            remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.*/
            /*Console.WriteLine("Enter the first number");
            int integer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int integer2 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int c = integer1; c <= integer2; c++);
            {
                if (c % 5 == 0);
                {
                    Console.WriteLine(c);
                    count++;
                }
                
            }
            Console.WriteLine(count.ToString());*/
            //Question 6
            /*Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional
            statements.*/
            Console.WriteLine("Enter your first number");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your first number is {firstnumber} and your second number is {secondnumber}");
            Console.WriteLine($"The larger number is {Math.Max(firstnumber,secondnumber)}");
            //Question 7
            /*Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt 
            the user to enter another number.*/
            Console.WriteLine("Enter the first integer number");
            int firstnom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer number");
            int secondnom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third integer number");
            int thirdnom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the forth integer number");
            int forthnom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fifth integer number");
            int fifthnom = Convert.ToInt32(Console.ReadLine());
            int add = (firstnom + secondnom + thirdnom + forthnom + fifthnom);
            Console.WriteLine("The sum of the five integer numbers is " + add);
            while (true);
                {
                    Console.WriteLine("Enter a valid integer number");
                }
            //Question 8
            //Write a program that reads five numbers from the console and prints the greatest of them.
            Console.WriteLine("Enter the first number: ");
            int firstno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int thirdno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the forth number: ");
            int forthno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fifth number: ");
            int fifthno = Convert.ToInt32(Console.ReadLine());
        
            //Question 9
            //Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.
            //Question 10
            //Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.
            //Question 11
            /*Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 
            89, 144, 233, …*/
            int n = 100;
                int f1 = 0, f2 = 1, i;

            if (n < 1)
            return;
            for (i = 1; i < n; i++)
            {
                Console.Write(f2 +" ");
                int next = f1 + f2;
                f1 = f2;
                f2 = next;
            }
            //Question 12
            //Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …
        }
    }
}
