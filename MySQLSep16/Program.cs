// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using MySQLSep16.DataAccess;
using MySQLSep16.Models;
using System;
using System.Collections.Concurrent;

Console.WriteLine("Hello, World!");

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
    
cardata.CreateCar(car1);
cardata.DeleteCar(cardata.GetCarByID(12));

foreach(CarModel car in cars) { 

    Console.WriteLine($"CarID:{car.CarID}, Year: {car.Year}, Make:{car.Make}, Model: {car.Model}");
}

foreach(int year in CarYear)
{
    Console.WriteLine("Year: " + year);
}

foreach(string make in CarMake)
{
    Console.WriteLine("Make: " + make);
}

foreach(CarModel car in CarSearchYear)
{
    Console.WriteLine($"CarID:{car.CarID}, Year: {car.Year}, Make:{car.Make}, Model: {car.Model}");
}


Console.ReadLine();

