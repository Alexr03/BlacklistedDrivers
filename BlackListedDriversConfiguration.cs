using Rocket.API;
using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BlackListedDrivers
{
    public class BlackListedDriversConfiguration : IRocketPluginConfiguration
    {
        public bool Save_Local;
        public bool GroupBlacklisting;

        public void LoadDefaults()
        {
            Save_Local = true;
            GroupBlacklisting = false;
        }
    }
}