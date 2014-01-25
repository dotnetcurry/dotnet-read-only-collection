using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationLibrary
{
    public class ConfigurationContainer
    {
        private ReadOnlyDictionary<string, ConfigElement> _configuration;
        private Dictionary<string, ConfigElement> _mutableConfiguration;

        public ReadOnlyDictionary<string, ConfigElement> Configuration
        {
            get
            {
                _configuration =
                    new ReadOnlyDictionary<string, ConfigElement>(_mutableConfiguration);
                return _configuration;
            }
        }

        public ConfigurationContainer()
        {

            _mutableConfiguration = new Dictionary<string, ConfigElement>();
            _mutableConfiguration.Add("key", new ConfigElement { Id=1,  Value="value1"});
            _mutableConfiguration.Add("key1", new ConfigElement { Id = 1, Value = "value1" });
            _mutableConfiguration["key2"] = new ConfigElement { Id = 1, Value = "value1" };
        }

        public bool AddToConfiguration(string key, ConfigElement value)
        {
            if (ConfigurationAllowed(key, value))
            {
                _mutableConfiguration.Add(key, value);
                return true;
            }
            return false;
        }

        private bool ConfigurationAllowed(string key, ConfigElement value)
        {
            // Put in your checks and balances
            // here and return the appropriate result
            return true;
        }
    }
}
