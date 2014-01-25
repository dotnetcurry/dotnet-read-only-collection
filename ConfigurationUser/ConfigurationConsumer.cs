using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigurationLibrary;

namespace ConfigurationUser
{
    public class ConfigurationConsumer
    {
        IReadOnlyDictionary<string, ConfigurationLibrary.ConfigElement> _config;

        public ConfigurationConsumer()
        {
            _config = new ConfigurationLibrary
                .ConfigurationContainer().Configuration;
        }

        public void DoSomething()
        {
            if (_config.ContainsKey("key"))
            {
                // Do Something
                Console
                    .WriteLine(string.Format("Did Something, Got - {0}",
                    _config["key"].Value));
            }
            else
            {
                // Do Something Else.
                Console.WriteLine("Did Something Else");
            }
        }

        public void BeNaughtyWithConfiguration()
        {
            IDictionary<string, ConfigElement> convertToReadWrite
                = (IDictionary<string, ConfigElement>)_config;
            ConfigElement element = convertToReadWrite["key"];
            element.Value = "Haa Haa";
            Console.WriteLine(element.Value);
            Console.WriteLine(convertToReadWrite["key"].Value);
            Console.ReadLine();

            convertToReadWrite.Add("Key12345", new ConfigElement { Id = 100, Value = "Haa Haa" });
        }
    }
}
