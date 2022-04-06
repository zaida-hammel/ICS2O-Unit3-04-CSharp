// Created by: Zaida Hammel
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function converts fahrenheit to celsius
        float fahrenheit;
        float celsius;

        Console.WriteLine("This program converts fahrenheit to celsius");
        Console.WriteLine("");
        Console.Write("Enter degrees fahrenheit (°): ");
        fahrenheit = float.Parse(Console.ReadLine());

        celsius = (fahrenheit - 32) * 5/9;

        Console.WriteLine("");
        Console.Write("Degrees in Celsius = " + celsius.ToString("0.00") + "°");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}