using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using Aggregator;
using GitSharp;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using File = System.IO.File;

namespace GetGumtree
{
    class Program
    {
        private static void Main(string[] args)
        {
            var arg0 = @"C:\Dropbox\jnk\WeSellCars\"; // file path
            var arg1 = @"C:\git\apdekock.github.io\"; //repo path
            var arg2 = @"_posts\2015-08-04-weMineData.markdown"; //post path
            var arg3 = @"C:\Program Files\Git\cmd\git.exe"; //git path

            args = new[] { arg0, arg1, arg2, arg3 };

            try
            {

                IWebDriver driver = new ChromeDriver(Path.Combine(Directory.GetCurrentDirectory(), "WebDriverServer"));
                driver.Navigate().GoToUrl("http://www.wesellcars.co.za/");
                var findElement = driver.FindElements(By.CssSelector("#feed_1 > div > div.vehicles.grid > div.item"));
                StringBuilder listOfLines = new StringBuilder();
                foreach (var item in findElement)
                {
                    var lines = item.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    var format = string.Join(",", lines);
                    listOfLines.AppendLine(format);
                    Console.WriteLine(format);
                }

                driver.Close();
                var cTempCarsTxt = @"C:\temp\Dropbox\jnk\WeSellCars\WeSellCars_" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".csv";
                var fileStream = File.Create(cTempCarsTxt);
                fileStream.Close();
                File.WriteAllText(cTempCarsTxt, listOfLines.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
            //Console.ReadLine();
            //try
            //{
            //    List<VehicleAdd> items = new List<VehicleAdd>();
            //    GetItems(items);
            //    var cTempCarsTxt = @"c:\temp\GumtreeCars" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".csv";
            //    var fileStream = File.Create(cTempCarsTxt);
            //    fileStream.Close();
            //    var stringBuilder = new StringBuilder();
            //    foreach (var vehicleAdd in items)
            //    {
            //        stringBuilder.Append(vehicleAdd.Year);
            //        stringBuilder.Append(";");
            //        stringBuilder.Append(vehicleAdd.Title);
            //        stringBuilder.Append(";");
            //        stringBuilder.Append(vehicleAdd.PriceRaw);
            //        stringBuilder.AppendLine();
            //    }
            //    File.WriteAllText(cTempCarsTxt, stringBuilder.ToString());
            //    Console.WriteLine("Done");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();
        }

        private static void GetItems(List<VehicleAdd> items)
        {

            try
            {
                IWebDriver driver = new ChromeDriver(Path.Combine(Directory.GetCurrentDirectory(), "WebDriverServer"));
                driver.Navigate().GoToUrl("http://www.gumtree.co.za/");
                driver.FindElement(By.LinkText("Cars & Bakkies")).Click();
                do
                {
                    items.AddRange(GetData(driver));
                    IWebElement nextElement = driver.FindElement(By.ClassName("pagination")).FindElement(By.ClassName("next"));
                    if (nextElement != null)
                    {
                        driver.Navigate().GoToUrl(nextElement.GetAttribute("href"));
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                driver.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static List<VehicleAdd> GetData(IWebDriver driver)
        {
            var result = new List<VehicleAdd>();
            try
            {
                var resultsView = driver.FindElement(By.ClassName("results"));

                var view = resultsView.FindElements(By.ClassName("view")).Last();

                foreach (var item in view.FindElements(By.ClassName("result")))
                {
                    try
                    {
                        var vehicle = item.FindElement(By.ClassName("title")).Text;
                        var price = item.FindElement(By.ClassName("price")).Text;
                        var vehicleAdd = new VehicleAdd(vehicle, price);
                        result.Add(vehicleAdd);
                        Console.WriteLine(vehicleAdd);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        private class VehicleAdd
        {
            private readonly string _title;
            private readonly string _price;

            public string Year
            {
                get
                {
                    string pattern = @"\b\d{4}\b";
                    var r = new System.Text.RegularExpressions.Regex(pattern);

                    var year = r.Match(_title);
                    if (year.Success)
                    {
                        return r.Match(_title).ToString();
                    }
                    return string.Empty;
                }
            }

            public VehicleAdd(string title, string price)
            {
                _title = title;
                _price = price;
            }

            public string Title
            {
                get { return _title; }
            }

            public string Price
            {
                get { return _price; }
            }

            public string PriceRaw
            {
                get { return string.Join("", Price.ToCharArray().Where(Char.IsDigit)); }
            }

            public override string ToString()
            {
                return string.Format("{0} - {1} - {2}", Year, PriceRaw, Title);
            }
        }
    }
}
