﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aggregator;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)

        {
            args = new[] { @"C:\Dropbox\jnk\WeSellCars" };

            StringBuilder postTemplate = new StringBuilder();
            postTemplate.AppendLine("---");
            postTemplate.AppendLine("layout: post ");
            postTemplate.AppendLine("title:\"Scraping\" ");
            postTemplate.AppendLine("date: {0} ");
            postTemplate.AppendLine("quote: \"“If you get pulled over for speeding.Tell them your spouse has diarrhoea.” — Phil Dunphy[Phil’s - osophy]\"");
            postTemplate.AppendLine("categories: scraping, auto generatingpost ");
            postTemplate.AppendLine("---");
            postTemplate.AppendLine(" This page is a daily re-generated post, that shows the movement of prices on the www.wesellcars.co.za website.");
            postTemplate.AppendLine("");
            postTemplate.AppendLine("{1}");
            postTemplate.AppendLine("");
            postTemplate.AppendLine("This page was last generated {0}.");

            var aggregateData = new AggregateData(new FileSystemLocation(args[0]));
            var dictionary = aggregateData.Aggregate();

            var html = aggregateData.GetHTML(dictionary);
            var post = string.Format(postTemplate.ToString(), DateTime.Now, html);
        }
    }
}