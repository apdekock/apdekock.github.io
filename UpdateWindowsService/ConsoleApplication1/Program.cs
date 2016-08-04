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
            var aggregateData = new AggregateData(new FileSystemLocation(args[0]));
            aggregateData.Aggregate();

        }
    }
}
