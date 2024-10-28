using System;
using System.Transactions;
class Program
{
    public static void Main()
    {
        //home 1
        Console.WriteLine("Введите количество работников");

        int numWorker = int.Parse(Console.ReadLine());

        int resultSalary = 0;

        for (int i = 1; i <= numWorker; i++)
        {
            Console.WriteLine($"Зарптала рабочего номер {i} :");

            int slaryMonth = int.Parse(Console.ReadLine());

            resultSalary += slaryMonth;
        }

        int averageSlary = (resultSalary / numWorker);

        Console.WriteLine($"Средняя зарплата: {averageSlary}");

        //home 2

        Console.WriteLine("enter row: ");

        int quanityRow = int.Parse(Console.ReadLine());

        char star = '*';

        for (int row = 1; row <= quanityRow; row++)
        {
            Console.WriteLine(new string(star, row));
        }

        //home 3

        Console.WriteLine("Enter number: ");

        int limit = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime numbers from 1 to " + limit + ":");

        for (int i = 2; i <= limit; i++)
        {
            bool PrimeCheck = true;
            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    PrimeCheck = false;
                    break;
                }

            }

            if (PrimeCheck)
            {
                Console.WriteLine(i + ",");
                break;
            }
        }
            // home 4



            Console.WriteLine("Enter at least 8 digits to create a password: ");

            string paswordNumber = (Console.ReadLine());

            Console.WriteLine("Enter one special character(!, *, @, $):");

            char paswordChar = char.Parse(Console.ReadLine());

            bool aceptPasword = true;
            while (true)
            {
                if (paswordNumber.Length < 8)
                {
                    aceptPasword = false;
                    Console.WriteLine("Something went wrong, try again");
                    break;
                }
                if (paswordChar == null)
                {
                    aceptPasword = false;
                    Console.WriteLine("Something went wrong, try again");
                    break;
                }
                else
                {
                    Console.WriteLine($"your pasword: {paswordNumber}{paswordChar} acept");
                break;

  
                }
            }

        //home 5
        Console.WriteLine("Fibonacci number:");
        int n = 1;
        int a = 0;
        int b = 1;
        for (int i = 0; i <= n; i++)
        {
            n = a + b;
            a = b;
            b = n;
            Console.WriteLine(n);
        }


        //home 6

        Console.WriteLine("Enter number of hours worked per day: ");
        double? hoursDay = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter hourly rate: ");
        double? rateHours = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter currency(doll, euro ...): ");
        string valute = Console.ReadLine();

        double? payDay = hoursDay * rateHours;

        Console.WriteLine($"Payment per day is: {payDay} {valute}");


        //home 7

        Console.WriteLine("Enter number: ");

        int number = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 0; i <= 10; i++)
        {
            result = number * i;
            Console.WriteLine($"{number} * {i} = {result}");
        }

        //home 8
        Console.WriteLine("Enter number: ");
        bool examination = true;
        int num = int.Parse(Console.ReadLine());

        if (num <= 1)
        {
            examination = false;
        }
        else
        {
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    examination = false;
                    break;
                }
            }
        }
        if (examination)
        {
            Console.WriteLine("Prime number");
        }
        else
        {
            Console.WriteLine("The number is not prime");
        }



    }
}