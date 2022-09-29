// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using MySQLSep16.DataAccess;
using MySQLSep16.Models;
using System;
using System.Collections.Concurrent;

<<<<<<< HEAD
Console.WriteLine("Lets test our bank transactions!");
=======

// this is a test for commit
Console.WriteLine("Hello, World!");
>>>>>>> 8b6315dd562c1cc6469aea668533ee5eca946fc9

BankModel transaction = new BankModel
{
    Amt = 1000000,
    txDate = DateTime.Now,
    txID = 1

};

BankData banker = new BankData();

banker.CreateTransaction(transaction);

Console.ReadLine();

static void RunCarStuff()
{
    CarData cardata = new CarData();
    List<CarModel> cars = cardata.GetAllCars();

    List<int> CarYear = cardata.GetYears();

    List<string> CarMake = cardata.GetMake();

    List<CarModel> CarSearchYear = cardata.SearchYear();

    CarModel car1 = new CarModel()
    {
        Year = 2022,
        Make = "Ford",
        Model = "F-150 Lightining"
    };

    //cardata.CreateCar(car1);


    foreach (CarModel car in cars)
    {

        Console.WriteLine($"CarID:{car.CarID}, Year: {car.Year}, Make:{car.Make}, Model: {car.Model}");
    }

    CarModel carHold = cardata.GetCarByID(12);
    carHold.Make = car1.Make;
    carHold.Model = car1.Model;
    carHold.Year = car1.Year;

    cardata.UpdateCar(carHold);

    foreach (int year in CarYear)
    {
        Console.WriteLine("Year: " + year);
    }

    foreach (string make in CarMake)
    {
        Console.WriteLine("Make: " + make);
    }

    foreach (CarModel car in CarSearchYear)
    {
        Console.WriteLine($"CarID:{car.CarID}, Year: {car.Year}, Make:{car.Make}, Model: {car.Model}");
    }
}




