using System;
using System.Threading;
using System.Net.Http;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sending comms via http...");
            string uri = "http://192.168.99.100:8080";

            HttpClient c = new HttpClient();
            c.Timeout = TimeSpan.FromMinutes(1);
            
            var d = c.GetAsync(uri);

            while (true)
            {
                try
                {
                    for (int i = 0; i < 60; i++)
                    {
                        string msg = string.Format("Http input: {0}, {1}", System.Environment.MachineName, i.ToString());
                        System.Threading.Tasks.Task.WaitAll(c.PutAsync(uri, new StringContent(msg)));
                        System.Console.WriteLine(msg);
                        System.Threading.Thread.Sleep(1000);
                    }
                    break;
                }
                catch  (Exception exc)
                {
                    System.Console.WriteLine(string.Format("Logstash sleeps: {0}", exc.ToString()));
                    Thread.Sleep(10000);
                }
            }

            Console.WriteLine("Finished");
        }
    }
}
