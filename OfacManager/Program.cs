using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfacManager.Models;
using OfacManager.Lib;

namespace OfacManager
{
	class Program
	{
		static void Main(string[] args)
		{
			//get xml
			Console.WriteLine("Getting XML...");
			string xml = Downloader.GetSdnList();
			
			//parse into object
			Console.WriteLine("Parsing XML...");
			OfacSdnList list = Parser.ParseSdnList(xml);

			//do something with it... :)
			Console.WriteLine("Doing something with my new object...");
			Console.WriteLine(string.Format("Publish Date: {0}", list.PublishInformation.PublishDate.ToLongDateString()));
			foreach (var entry in list.Entries)
			{
				Console.WriteLine(string.Format("{0}: {1}", entry.Type, entry.Name));
			}

			Console.WriteLine("---");
			Console.WriteLine("Press 'Enter' To Exit");
			Console.ReadLine();
		}
	}
}
