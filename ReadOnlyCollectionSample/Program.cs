using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyCollectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationUser.ConfigurationConsumer consumer =
                new ConfigurationUser.ConfigurationConsumer();
            consumer.DoSomething();
            Console.ReadLine();
            consumer.BeNaughtyWithConfiguration();
        }
    }
}
