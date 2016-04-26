---
layout: post
date:   2015-11-12 22:00:00
title:  "Streaming a large amount of data to a CSV file"
quote:  "“Act like a parent, talk like a peer. I call it “peerenting”” — Phil Dunphy"
categories: c# .NET CSV HTTP
---

## The code>

{% highlight c# %}
public class CSVExporter
{
	public static void WriteToCSV<T>(IEnumerable<T> p_Data)
	{
		string attachment = "attachment; filename=AdhocData(" + typeof(T).Name + ")_"+DateTime.Now.ToString("yyyy_MM_dd_HH_mm")+".csv";
		System.Web.HttpContext.Current.Response.Clear();
		System.Web.HttpContext.Current.Response.ClearHeaders();
		System.Web.HttpContext.Current.Response.ClearContent();
		System.Web.HttpContext.Current.Response.AddHeader("content-disposition", attachment);
		System.Web.HttpContext.Current.Response.ContentType = "text/csv";
		System.Web.HttpContext.Current.Response.AddHeader("Pragma", "public");
		WriteColumnName();
		foreach (T item in p_Data)
		{
			WriteUserInfo<T>(item);
		}
		System.Web.HttpContext.Current.Response.End();
	}

	private static void WriteUserInfo<T>(T p_Item)
	{
		StringBuilder strb = new StringBuilder();

		foreach (var prop in p_Item.GetType().GetProperties())
		{
			//AddComma(prop.Name, strb);
			var propValue = prop.GetValue(p_Item, null);
			AddComma((propValue ?? String.Empty).ToString(), strb);
		}

		System.Web.HttpContext.Current.Response.Write(strb.ToString());
		System.Web.HttpContext.Current.Response.Write(Environment.NewLine);
	}

	private static void AddComma(string item, StringBuilder strb)
	{
		strb.Append(item.Replace(',', ' '));
		strb.Append(" ,");
	}

	private static void WriteColumnName()
	{
		StringBuilder strb = new StringBuilder();
		vw_Adhoc_Data adhocDataHeaders = new vw_Adhoc_Data();

		foreach (var prop in adhocDataHeaders.GetType().GetProperties())
		{
			AddComma(prop.Name, strb);
		}

		System.Web.HttpContext.Current.Response.Write(strb.ToString());
		System.Web.HttpContext.Current.Response.Write(Environment.NewLine);
	}
}
{% endhighlight %}