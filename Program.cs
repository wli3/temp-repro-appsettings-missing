using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace appsettingrepro
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
	        .SetBasePath(Directory.GetCurrentDirectory())
	        .AddJsonFile("appsettings.json")
            .Build();

            var dict = new Dictionary<string, string>();
            config.GetSection("section0").Bind(dict);
            Console.WriteLine(dict["key0"]);
        }
    }
}
