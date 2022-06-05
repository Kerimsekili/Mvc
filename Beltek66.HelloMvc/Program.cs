using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beltek66.HelloMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var d = new Deneme<int>();
            //ArrayList al = new ArrayList();
            //al.Add(1);

            //List<string> list = new List<string>();
            //list.Add("Ali");
            CreateHostBuilder(args).Build().Run();
        }
        public class Deneme<T> where T :struct
        {
            public T sayi;

            public void Print()
            {
                Console.WriteLine(this.sayi);
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
