// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using MySQLSep16.DataAccess;
using MySQLSep16.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Spectre.Console;
using System.ComponentModel;
using MySqlX.XDevAPI.Relational;
using Table = Spectre.Console.Table;
using System.Net.Http.Headers;

namespace MySQLSep16.UserInterface
{

    public static class UsedMarketPlace
    {
        public static async Task<string> Main(string[] args)
        {


            //text prompt
            var favorites = AnsiConsole.Prompt(
            new MultiSelectionPrompt<string>()
               .PageSize(10)
            .Title("What are your [green]favorite fruits[/]?")
            .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
            .InstructionsText("[grey](Press [blue][/] to toggle a fruit, [green][/] to accept)[/]")
            .AddChoiceGroup("Berries", new[]
            {
                "Blackcurrant", "Blueberry", "Cloudberry",
                "Elderberry", "Honeyberry", "Mulberry"
            })
            .AddChoices(new[]
            {
                "Apple", "Apricot", "Avocado", "Banana",
                "Cherry", "Cocunut", "Date", "Dragonfruit", "Durian",
                "Egg plant",  "Fig", "Grape", "Guava",
                "Jackfruit", "Jambul", "Kiwano", "Kiwifruit", "Lime", "Lylo",
                "Lychee", "Melon", "Nectarine", "Orange", "Olive"
            }));

            var fruit = favorites.Count == 1 ? favorites[0] : null;
            if (string.IsNullOrWhiteSpace(fruit))
            {
                fruit = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Ok, but if you could only choose [green]one[/]?")
                        .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                        .AddChoices(favorites));
            }

            AnsiConsole.MarkupLine("Your selected: [yellow]{0}[/]", fruit);
            return fruit;


            
        }

    }
}

    /*generating table
            var table = new Table().Centered();

            //editing table properties    
            AnsiConsole.Live(table)
                .Start(ctx =>
                {
                    table.Border = TableBorder.AsciiDoubleHead;
                    table.Width(40);

                    table.AddColumn("");
                    ctx.Refresh();
                    Thread.Sleep(1000);
                    table.AddColumn("   SELECT #   ");
                    ctx.Refresh();
                    Thread.Sleep(1000);

                    table.AddRow(new Panel("1."), new Panel("[green]BUY[/]"));
                    table.AddRow(new Panel("2."), new Panel("[red]SELL[/]"));
                    table.AddRow(new Panel("3."), new Panel("[blue]EXIT[/]"));
                    table.AddEmptyRow();



                });


    AnsiConsole.Markup("[underline red]Hello[/] World!");
        Console.ReadLine();


        var panel = new Panel("Hello world");

        var table = new Table().Centered();

        table.Border = TableBorder.AsciiDoubleHead; 

        await AnsiConsole.Live(table)
            .Cropping(VerticalOverflowCropping.Top)
            .StartAsync(async ctx =>
            {
                table.AddColumn("Car ID");
                ctx.Refresh();
                await Task.Delay(1000);

                table.AddColumn("Brand");
                ctx.Refresh();
                await Task.Delay(500);

                table.AddColumn("Model");
                ctx.Refresh();
                await Task.Delay(500);

                table.AddColumn("Year");
                ctx.Refresh();
                await Task.Delay(500);

                table.AddColumn("Price");
                ctx.Refresh();
                await Task.Delay(500);

                table.AddRow


            });*/






