using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aggregator
{
    public class AggregateData
    {
        private readonly IDataRepository _dataRepository;

        public AggregateData(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public Dictionary<string, IEnumerable<double>> Aggregate()
        {
            var dataItems = _dataRepository.GetDataItems();

            var cars = new Dictionary<string, SortedDictionary<DateTime, double>>();

            foreach (var dataItem in dataItems)
            {
                foreach (var lineItem in dataItem.LineItems)
                {
                    if (!cars.ContainsKey(lineItem.Description))
                    {
                        var p = new SortedDictionary<DateTime, double> { { dataItem.DateTime, lineItem.Price } };
                        cars.Add(lineItem.Description, p);
                    }
                    else
                    {
                        var dictionary = cars[lineItem.Description];
                        dictionary[dataItem.DateTime] = lineItem.Price;
                    }
                }
            }

            var monthAgo = DateTime.Now.AddDays(-30);

            var listedAtLeastMonthAgo = cars.Where(c => c.Value.Keys.Max() > monthAgo);

            return listedAtLeastMonthAgo.ToDictionary(d => d.Key, y => y.Value.Values.Select(f => f));
        }

        public string GetHTML(Dictionary<string, IEnumerable<double>> aggregate)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<ul>");
            foreach (var car in aggregate)
            {
                string Template = "<li><div> {0} <span class=\"sparklines\">{1}</span></div></li>";
                sb.AppendLine(string.Format(Template, car.Key, string.Join(",", car.Value)));
            }
            sb.AppendLine("</ul>");
            sb.AppendLine("<script type=\"text/javascript\"> $('.sparklines').sparkline('html'); </script>");
            return sb.ToString();
        }
    }

    public class DataPoint
    {
        public DataPoint(DateTime dateTime)
        {
            DateTime = dateTime;
            LineItems = new List<LineItem>();
        }

        public DateTime DateTime { get; set; }
        public List<LineItem> LineItems { get; }

        public void AddLineItem(LineItem item)
        {
            LineItems.Add(item);
        }
    }

    public class FileSystemLocation : IDataRepository
    {
        private readonly string _path;

        public FileSystemLocation(string path)
        {
            _path = path;
        }


        public IEnumerable<DataPoint> GetDataItems()
        {
            var dataPoints = new List<DataPoint>();
            var directoryInfo = new DirectoryInfo(_path);
            foreach (var file in directoryInfo.GetFiles())
            {
                var datePart = file.Name.Substring(11);
                var day = Convert.ToInt32(datePart.Substring(0, 2));
                var month = Convert.ToInt32(datePart.Substring(3, 2));
                var year = Convert.ToInt32(datePart.Substring(6, 4));
                DataPoint dPoint = new DataPoint(new DateTime(year, month, day));
                try
                {
                    var streamReader = file.OpenText();
                    var fileContent = streamReader.ReadToEnd();
                    var lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var line in lines)
                    {
                        try
                        {
                            dPoint.LineItems.Add(new LineItem(line));
                        }
                        catch (Exception)
                        {
                            // skip line
                        }
                    }
                }
                catch (Exception)
                {
                    // skip file
                }
                dataPoints.Add(dPoint);
            }
            return dataPoints;
        }
    }

    public class LineItem
    {
        public LineItem(string lineContent)
        {
            var lastFiledSeperator = lineContent.LastIndexOf(',');
            var priceSection = lineContent.Substring(lastFiledSeperator);

            Price = Double.Parse(string.Concat(priceSection.Where(Char.IsDigit)));
            Description = lineContent.Remove(lastFiledSeperator);
        }

        public string Description { get; set; }
        public double Price { get; set; }
    }
    public interface IDataRepository
    {
        IEnumerable<DataPoint> GetDataItems();
    }
}
