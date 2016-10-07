using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackListedDrivers
{
    public class BlackListedDriversConfiguration : IRocketPluginConfiguration
    {
        public bool Save_Local;

        public void LoadDefaults()
        {
            Save_Local = true;
        }
    }
}
