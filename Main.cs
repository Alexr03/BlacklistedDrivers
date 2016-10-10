using Rocket.Core.Plugins;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Rocket.Unturned.Chat;

namespace BlackListedDrivers
{
    public class Main : RocketPlugin<BlackListedDriversConfiguration>
    {
        public static Main Instance;
        public static List<CSteamID> Blacklisted = new List<CSteamID>();

        protected override void Load()
        {
            Instance = this;
            Rocket.Core.Logging.Logger.Log("Blacklisted Drivers loaded! ~~ Alexr03!");

            Rocket.Unturned.Events.UnturnedPlayerEvents.OnPlayerUpdateStance += UpdatedStance;
        }

        private void UpdatedStance(UnturnedPlayer player, byte stance)
        {
            if(stance == 6)
            {
                if (Blacklisted.Contains(player.CSteamID))
                {
                    player.CurrentVehicle.kickPlayer(0);
                    UnturnedChat.Say(player.CSteamID, "You have been blacklisted from driving.");
                }

                //foreach(CSteamID g in Configuration.Instance.BlacklistedGroup)
                //{
                //    if(player.SteamGroupID == g)
                //    {

                //    }
                //}
            }
        }

        protected override void Unload()
        {
            Rocket.Core.Logging.Logger.Log("Blacklisted Drivers unloaded! ~~ Alexr03!");
        }

        private void FixedUpdate()
        {
        }
    }
}
