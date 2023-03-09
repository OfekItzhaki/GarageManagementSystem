// See https://aka.ms/new-console-template for more information
using GarageManagementSystem.Models;
using GarageManagementSystem.Models.Enums;
using GarageManagementSystem.Services.DataService;
using GarageManagementSystem.Services.GarageService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //// setup our DI
        //var serviceProvider = new ServiceCollection()
        //            .AddLogging()
        //            .AddSingleton<IDataService, DataService>()
        //            .AddSingleton<IGarageService, GarageService>()
        //            .BuildServiceProvider();

        ////configure console logging
        ////serviceProvider
        ////    .GetService<ILoggerFactory>()
        ////    .AddConsole(LogLevel.Debug);

        //var logger = serviceProvider.GetService<ILoggerFactory>()
        //    .CreateLogger<Program>();
        //logger.LogDebug("Starting application");

        ////do the actual work here
        //var garageService = serviceProvider.GetService<GarageService>();

        //logger.LogDebug("All done!");

        StartApp();
    }

    private static void StartApp()
    {
        var dataService = new DataService();
        var garageService = new GarageService(dataService);

        var car = new Car(VehicleType.Car, "34523532", "Engine doesn't work", 1999);
        garageService.InsertVehicle(car);
        var list = garageService.GetVehiclesSortedByYear();

        garageService.ChangeStatus("34523532", Status.Fixed);

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.WriteLine(garageService.GetTotalProfit());
    }
}