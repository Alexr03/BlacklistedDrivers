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
    //public sealed class BlacklistedGroup
    //{
    //    [XmlArrayItem("Line")]
    //    public CSteamID Group;
    //}

    public class BlackListedDriversConfiguration : IRocketPluginConfiguration
    {
        public bool Save_Local;
        //[XmlArrayItem("Group")]
        //[XmlArray(ElementName = "Groups")]
        //public List<BlacklistedGroup> BlacklistedGroup;

        public void LoadDefaults()
        {
            Save_Local = true;
        }
    }
}