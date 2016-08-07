using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Aggregator;
using GitSharp;
using GitSharp.Commands;
using GitSharp.Core.Transport;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arg0 = @"C:\Dropbox\jnk\WeSellCars\"; // file path
            var arg1 = @"C:\git\apdekock.github.io\"; //repo path
            var arg2 = @"_posts\2015-08-04-weMineData.markdown"; //post path
            var arg3 = @"C:\Program Files\Git\cmd\git.exe"; //git path

            args = new[] { arg0, arg1, arg2, arg3 };

            StringBuilder postTemplate = new StringBuilder();
            postTemplate.AppendLine("---");
            postTemplate.AppendLine("layout: post ");
            postTemplate.AppendLine("title: \"Scraping\" ");
            postTemplate.AppendLine("date: 2016-08-07");
            postTemplate.AppendLine("quote: \"If you get pulled over for speeding.Tell them your spouse has diarrhoea. — Phil Dunphy [Phil’s - osophy]\"");
            postTemplate.AppendLine("categories: scraping, auto generatingpost ");
            postTemplate.AppendLine("---");
            //postTemplate.AppendLine("While investigating Git and GitSharp[link]");
            postTemplate.AppendLine(string.Format("This page is a daily re-generated post [last re-generated  {0}], that shows the movement of prices on the www.wesellcars.co.za website.", DateTime.Now));
            postTemplate.AppendLine("");

            var aggregateData = new AggregateData(new FileSystemLocation(args[0]));
            var dictionary = aggregateData.Aggregate();

            var html = aggregateData.GetHTML(dictionary);
            postTemplate.AppendLine(html);

            // update post file
            FileInfo fi = new FileInfo(args[1] + args[2]);
            var streamWriter = fi.CreateText();
            streamWriter.WriteLine(postTemplate.ToString());

            streamWriter.Flush();
            streamWriter.Dispose();


            Repository repository = new Repository(args[1]);

            repository.Index.Add(args[1] + args[2]);
            Commit commited = repository.Commit(string.Format("Updated {0}", DateTime.Now), new Author("Philip de Kock", "philipdekock@gmail.com"));
            if (commited.IsValid)
            {
                string gitCommand = args[3];
                const string gitPushArgument = @"push origin";
                ProcessStartInfo psi = new ProcessStartInfo(gitCommand, gitPushArgument)
                {
                    WorkingDirectory = args[1],
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
        }
    }
}
