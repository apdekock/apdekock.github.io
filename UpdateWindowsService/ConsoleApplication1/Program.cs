using System;
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
            var aggregateData = new AggregateData(new FileSystemLocation(args[0]));
            var dictionary = aggregateData.Aggregate();
            var html = aggregateData.GetHTML(dictionary);
            html += "<script type=\"text/javascript\"> $('.sparklines').sparkline('html'); </script>";
        }
    }
}
