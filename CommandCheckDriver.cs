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
    class CommandCheckDriver : IRocketCommand
    {

        public string Help
        {
            get { return "Checks a driver if they are blacklisted"; }
        }

        public string Name
        {
            get { return "checkdriver"; }
        }

        public string Syntax
        {
            get { return "/checkdriver <player>"; }
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
                return new List<string>() { "driver.check" };
            }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer user = (UnturnedPlayer)caller;
            UnturnedPlayer driver = UnturnedPlayer.FromName(command[0]);

            if (BlackListedDrivers.Main.Blacklisted.Contains(driver.CSteamID)) { UnturnedChat.Say(user.CSteamID + "User: " + driver.CharacterName + " Is already blacklisted!"); }
            else { UnturnedChat.Say(user.CSteamID + "User: " + driver.CharacterName + " Is not blacklisted!"); }

        }
    }
}
