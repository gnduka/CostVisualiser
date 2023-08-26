﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Cost Visualiser Program.");
Console.WriteLine("To start, please enter your hourly rate");

float hourlyRate = float.Parse(Console.ReadLine());

Console.WriteLine("What is the cost of the item/service you wish to purchase?");

float costOfProduct = float.Parse(Console.ReadLine());

float minutesOfWorkRequired = (costOfProduct / hourlyRate) * 60;

// multiplication by 60 here to get convert the figure into minutes instead of hours.
// this will make subsequent calculations easier.