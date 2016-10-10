using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackListedDrivers
{
    class CommandAddDriver : IRocketCommand
    {

        public string Help
        {
            get { return "Add a driver to blacklisted!"; }
        }

        public string Name
        {
            get { return "blacklistdriver"; }
        }

        public string Syntax
        {
            get { return "<Player>"; }
        }

        public List<string> Aliases
        {
            get { return new List<string>(); }
        }

        public AllowedCaller AllowedCaller
        {
            get { return AllowedCaller.Both; }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>() { "driver.add" };
            }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer user = (UnturnedPlayer)caller;
            UnturnedPlayer driver = UnturnedPlayer.FromName(command[0]);

            Main.Blacklisted.Add(driver.CSteamID);
            if (Main.Blacklisted.Contains(driver.CSteamID))
            {
                UnturnedChat.Say(user.CSteamID, "Sucessfully blacklisted: " + driver.CharacterName + " From driving");
            }
            else { UnturnedChat.Say(user.CSteamID, "An error occured trying to blacklist: " + driver.CharacterName + " From driving"); }

        }
    }
}
