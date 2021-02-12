using System;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var provider = new DiskInfoProvider();
            var results = await provider.CollectAsync();

            foreach (var r in results)
            {
                foreach (var p in r)
                {
                    Console.WriteLine($"{p.Name}: {p.Value}");
                }
                Console.WriteLine("\r");
            }
        }
    }
}